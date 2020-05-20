namespace PKE_1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя объекта";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Время старта";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Время остановки";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Схема проверки";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Интервал измерения";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "UID";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column11,
            this.PA,
            this.QA,
            this.SA,
            this.Freq,
            this.Column13});
            this.dataGridView2.Location = new System.Drawing.Point(1, 244);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(675, 286);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дата / время";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "UA";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "IA";
            this.Column11.Name = "Column11";
            this.Column11.Width = 70;
            // 
            // PA
            // 
            this.PA.HeaderText = "PA";
            this.PA.Name = "PA";
            this.PA.Width = 70;
            // 
            // QA
            // 
            this.QA.HeaderText = "QA";
            this.QA.Name = "QA";
            this.QA.Width = 70;
            // 
            // SA
            // 
            this.SA.HeaderText = "SA";
            this.SA.Name = "SA";
            this.SA.Width = 70;
            // 
            // Freq
            // 
            this.Freq.HeaderText = "Freq";
            this.Freq.Name = "Freq";
            this.Freq.Width = 80;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "sigmaUy";
            this.Column13.Name = "Column13";
            this.Column13.Width = 70;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column30,
            this.Column31,
            this.Column32,
            this.Column33,
            this.Column34,
            this.Column35,
            this.Column36});
            this.dataGridView3.Location = new System.Drawing.Point(1, 243);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1420, 287);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата / время";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "UAB";
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "UBС";
            this.Column10.Name = "Column10";
            this.Column10.Width = 70;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "UCA";
            this.Column14.Name = "Column14";
            this.Column14.Width = 50;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "IAB";
            this.Column15.Name = "Column15";
            this.Column15.Width = 50;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "IBC";
            this.Column16.Name = "Column16";
            this.Column16.Width = 50;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "ICA";
            this.Column17.Name = "Column17";
            this.Column17.Width = 30;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "IA";
            this.Column18.Name = "Column18";
            this.Column18.Width = 30;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "IB";
            this.Column19.Name = "Column19";
            this.Column19.Width = 30;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "IC";
            this.Column20.Name = "Column20";
            this.Column20.Width = 30;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "PO";
            this.Column21.Name = "Column21";
            this.Column21.Width = 30;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "PP";
            this.Column22.Name = "Column22";
            this.Column22.Width = 30;
            // 
            // Column23
            // 
            this.Column23.HeaderText = "QO";
            this.Column23.Name = "Column23";
            this.Column23.Width = 30;
            // 
            // Column24
            // 
            this.Column24.HeaderText = "QP";
            this.Column24.Name = "Column24";
            this.Column24.Width = 30;
            // 
            // Column25
            // 
            this.Column25.HeaderText = "SO";
            this.Column25.Name = "Column25";
            this.Column25.Width = 30;
            // 
            // Column26
            // 
            this.Column26.HeaderText = "SP";
            this.Column26.Name = "Column26";
            this.Column26.Width = 30;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "UO";
            this.Column27.Name = "Column27";
            this.Column27.Width = 50;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "UP";
            this.Column28.Name = "Column28";
            this.Column28.Width = 50;
            // 
            // Column29
            // 
            this.Column29.HeaderText = "IO";
            this.Column29.Name = "Column29";
            this.Column29.Width = 50;
            // 
            // Column30
            // 
            this.Column30.HeaderText = "IP";
            this.Column30.Name = "Column30";
            this.Column30.Width = 50;
            // 
            // Column31
            // 
            this.Column31.HeaderText = "KO";
            this.Column31.Name = "Column31";
            this.Column31.Width = 50;
            // 
            // Column32
            // 
            this.Column32.HeaderText = "Freq";
            this.Column32.Name = "Column32";
            this.Column32.Width = 70;
            // 
            // Column33
            // 
            this.Column33.HeaderText = "sigmaUy";
            this.Column33.Name = "Column33";
            this.Column33.Width = 70;
            // 
            // Column34
            // 
            this.Column34.HeaderText = "sigmaUyAB";
            this.Column34.Name = "Column34";
            this.Column34.Width = 70;
            // 
            // Column35
            // 
            this.Column35.HeaderText = "sigmaUyBC";
            this.Column35.Name = "Column35";
            this.Column35.Width = 70;
            // 
            // Column36
            // 
            this.Column36.HeaderText = "sigmaUyCA";
            this.Column36.Name = "Column36";
            this.Column36.Width = 70;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выгрузить в Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Измерения";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column33;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column35;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column36;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

