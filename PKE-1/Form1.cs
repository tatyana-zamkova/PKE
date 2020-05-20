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
            HashSet<Cxema> AllIzmer1 = new HashSet<Cxema>();
            HashSet<Cxema> AllIzmer2 = new HashSet<Cxema>();
            private string folderName;
            DialogResult result;
        public Form1()
        {
            InitializeComponent();
            this.dataGridView2.Visible = false;
            this.dataGridView3.Visible = false;
            result = MessageBox.Show("Выберите путь до каталога, содержащего папку верхнего уровня #data","Выбор папки");
            result = folderBrowserDialog1.ShowDialog();
            folderName = folderBrowserDialog1.SelectedPath + @"\#data\#data\card\PKE";
            if (result == DialogResult.OK)
            {
                               
            DirectoryInfo dir = new DirectoryInfo(@folderName);
            this.BringToFront();
            //DirectoryInfo dir = new DirectoryInfo(@"F:\#data\#data\card\PKE");
            try
            {
               
                foreach (var item in dir.GetDirectories())
                {

                    foreach (var it in item.GetDirectories())
                    {

                        foreach (var i in it.GetFiles())
                        {
                            XmlDocument xml = new XmlDocument();
                            xml.Load(@folderName + @"\" + item + @"\" + it + @"\" + i.Name);
                            XmlElement el = xml.DocumentElement;
                            XmlNode uid = el.SelectSingleNode("/RM3_ПКЭ");
                            XmlNode node = el.SelectSingleNode("/RM3_ПКЭ/Param_Check_PKE");
                           
                            Izm attr = new Izm(uid.Attributes["UID"].InnerText, node.Attributes["nameObject"].InnerText, Convert.ToInt64(node.Attributes["TimeStart"].InnerText), Convert.ToInt64(node.Attributes["TimeStop"].InnerText), Convert.ToInt32(node.Attributes["averaging_interval_time"].InnerText), node.Attributes["active_cxema"].InnerText);
                            if (!Izmer.Contains(attr))
                                Izmer.Add(attr);
                         
                                List<string> parametrs1 = new List<string>();
                                List<string> parametrs2 = new List<string>();

                               using (XmlReader x = XmlReader.Create(@"F:\#data\#data\card\PKE\" + item + @"\" + it + @"\" + i.Name))
                                {
                                    while (x.Read())
                                    {
                                        if ((x.NodeType == XmlNodeType.Element) && (x.Name == "Result_Check_PKE"))
                                        {
                                            if (x.HasAttributes)
                                            {
                                                while (x.MoveToNextAttribute())
                                                {
                                                    if (attr.Active_cxema == "1")
                                                    {
                                                        parametrs1.Add(x.Value.ToString());
                                                        Cxema attr1 = new Cxema(uid.Attributes["UID"].InnerText, parametrs1);
                                                        AllIzmer1.Add(attr1);
                                                    }
                                                    if (attr.Active_cxema == "2")
                                                    {  parametrs2.Add(x.Value.ToString());
                                                        Cxema attr2 = new Cxema(uid.Attributes["UID"].InnerText, parametrs2);
                                                        
                                                        AllIzmer2.Add(attr2);
                                                    }
                                                    
                                                }
                                            }

                                        }
                                    }
                                }
                               
                            }
                        }
                    }

                foreach (var s in Izmer)
                    dataGridView1.Rows.Add(s.Name, new DateTime(s.TimeStart * 10000 + new DateTime(1970, 1, 1).Ticks), new DateTime(s.TimeStop * 10000 + new DateTime(1970, 1, 1).Ticks), s.Active_cxema, s.Averaging_interval_time < 60000 ? s.Averaging_interval_time / 1000 + " c" : s.Averaging_interval_time / 60000 + " м", s.UID);
                }
            
   
            catch (IOException exp)
            {
                result = MessageBox.Show(exp.Message.ToString(), "Каталог или файлы не найдены!");
               
            
            }
            }
           
          
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            int n;
           
            SortedSet<Cxema> IzmerCxema1 = new SortedSet<Cxema>(new CompTimeTeck());
            SortedSet<Cxema> IzmerCxema2 = new SortedSet<Cxema>(new CompTimeTeck());
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
                int i = 0;
                List<string[]> str = new List<string[]>(IzmerCxema1.Count);
                foreach (var s in IzmerCxema1)
                {
                    str.Add(new string[8]);
                    str[i][0] = ((new DateTime(Convert.ToInt64(s.Subordinate[1]) * 10000 + new DateTime(1970, 1, 1).Ticks)).ToString());
                    for (int j = 1; j < s.Subordinate.Count - 1; j++)
                        str[i][j] = (s.Subordinate[j + 1]);

                    i++;
                }
                foreach (string[] s in str)
                    dataGridView2.Rows.Add(s);

                
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
                     int i=0;
                     List<string[]> str = new List<string[]>(IzmerCxema2.Count);  
                     foreach (var s in IzmerCxema2){
                         str.Add(new string[26]);
                         str[i][0] = ((new DateTime(Convert.ToInt64(s.Subordinate[1]) * 10000 + new DateTime(1970, 1, 1).Ticks)).ToString());
                         for (int j = 1; j < s.Subordinate.Count-1; j++)
                             str[i][j] = (s.Subordinate[j+1]);
                         
                         i++;
                     }
                      foreach (string[] s in str)
                          dataGridView3.Rows.Add(s);
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
                for (int j = 0; j < (dataGridView1.Columns.Count-1); j++)
                {
                    ExcelWorkSheet.Cells[i + 3, j + 2] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            ExcelApp.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
