using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace PKE_1
{
    public partial class Form1 : Form
    {       SortedSet<Izm> Izmer = new SortedSet<Izm>(new CompareBox());
            HashSet<Cxema1> AllIzmer1 = new HashSet<Cxema1>();
            HashSet<Cxema2> AllIzmer2 = new HashSet<Cxema2>();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            DirectoryInfo dir = new DirectoryInfo(@"D:\#data\card\PKE");
           
            foreach (var item in dir.GetDirectories())
            {
                          
                foreach (var it in item.GetDirectories())
                {
                                    
                    foreach (var i in it.GetFiles())
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.Load(@"D:\#data\card\PKE\" + item+ @"\" + it + @"\"+ i.Name);
                        XmlElement el = xml.DocumentElement;
                        XmlNode uid = el.SelectSingleNode("/RM3_ПКЭ");
                        XmlNode node = el.SelectSingleNode("/RM3_ПКЭ/Param_Check_PKE");
                        XmlNode node1 = el.SelectSingleNode("/RM3_ПКЭ/Result_Check_PKE");
                        Izm attr = new Izm(uid.Attributes["UID"].InnerText, node.Attributes["nameObject"].InnerText, Convert.ToInt64(node.Attributes["TimeStart"].InnerText), Convert.ToInt64(node.Attributes["TimeStop"].InnerText), Convert.ToInt32(node.Attributes["averaging_interval_time"].InnerText), node.Attributes["active_cxema"].InnerText);
                       if (!Izmer.Contains(attr))
                        Izmer.Add(attr);
                        if(attr.Active_cxema=="1")
                        {
                            Cxema1 attr1 = new Cxema1(uid.Attributes["UID"].InnerText, node1.Attributes["pke_cxema"].InnerText, node1.Attributes["TimeTek"].InnerText, node1.Attributes["UA"].InnerText, node1.Attributes["IA"].InnerText);
                            AllIzmer1.Add(attr1);
                        }
                        if (attr.Active_cxema == "2")
                        {
                            Cxema2 attr2 = new Cxema2(uid.Attributes["UID"].InnerText, node1.Attributes["pke_cxema"].InnerText, node1.Attributes["TimeTek"].InnerText, node1.Attributes["UAB"].InnerText, node1.Attributes["UBC"].InnerText);
                            AllIzmer2.Add(attr2);
                        }
                    }
                }          
      
               
 }
        

             foreach (var s in Izmer)
                 dataGridView1.Rows.Add(s.Name, new DateTime(s.TimeStart * 10000 + new DateTime(1970, 1, 1).Ticks), new DateTime(s.TimeStop * 10000 + new DateTime(1970, 1, 1).Ticks), s.Active_cxema, s.Averaging_interval_time < 60000 ? s.Averaging_interval_time / 1000 + " c" : s.Averaging_interval_time / 60000 + " м", s.UID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            int n;
            SortedSet<Cxema1> IzmerCxema1 = new SortedSet<Cxema1>(new CompTimeTeck());
            SortedSet<Cxema2> IzmerCxema2 = new SortedSet<Cxema2>(new CompTimeTeck());
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                n = Convert.ToInt32(dataGridView1[3, e.RowIndex].Value);

                if (n == 1) 
                { 
                this.dataGridView3.Visible = false; this.dataGridView2.Visible = true;
                
                foreach (var s in AllIzmer1)
                {
                    if (dataGridView1[5, e.RowIndex].Value.ToString() == s.UID)
                    {
                        IzmerCxema1.Add(s);
                    }
                    
                }
                foreach (var s in IzmerCxema1)
                    dataGridView2.Rows.Add(new DateTime(Convert.ToInt64(s.TimeTek) * 10000 + new DateTime(1970, 1, 1).Ticks), s.UA, s.IA);

                
                }
                 else if (n == 2) 
                { 
                     this.dataGridView2.Visible = false; this.dataGridView3.Visible = true;
                     foreach (var s in AllIzmer2)
                     {
                         if (dataGridView1[5, e.RowIndex].Value.ToString() == s.UID)
                         {
                             IzmerCxema2.Add(s);
                         }

                     }
                     foreach (var s in IzmerCxema2)
                         dataGridView3.Rows.Add(new DateTime(Convert.ToInt64(s.TimeTek) * 10000 + new DateTime(1970, 1, 1).Ticks), s.UAB, s.UBC);
                 
                 }
                else { this.dataGridView2.Visible = false; this.dataGridView3.Visible = false; }
              
            }
            IzmerCxema1.Clear();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Cells[1, 3] = "измерения";

            for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
            {
                ExcelWorkSheet.Cells[3, i] = dataGridView1.Columns[i - 2].HeaderText;
            }
            for (int i = 1; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < (dataGridView1.Columns.Count-2); j++)
                {
                    ExcelWorkSheet.Cells[i + 3, j + 2] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            ExcelApp.Visible = true;
        }
    }
}
