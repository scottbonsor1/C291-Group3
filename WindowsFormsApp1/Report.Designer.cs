namespace WindowsFormsApp1
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReportLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.report5 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.report1_btn = new System.Windows.Forms.Button();
            this.reportgrid1 = new System.Windows.Forms.DataGridView();
            this.carTypeIDR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.report2_btn = new System.Windows.Forms.Button();
            this.reportgrid2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.report3_btn = new System.Windows.Forms.Button();
            this.reportgrid3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeIDR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthSelect = new System.Windows.Forms.ComboBox();
            this.report4_btn = new System.Windows.Forms.Button();
            this.reportgrid4 = new System.Windows.Forms.DataGridView();
            this.customerIDTab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.report5_btn = new System.Windows.Forms.Button();
            this.reportgrid5 = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(323, 27);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(98, 29);
            this.ReportLabel.TabIndex = 2;
            this.ReportLabel.Text = "Reports";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(644, 671);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 48);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // report5
            // 
            this.report5.Controls.Add(this.tabPage1);
            this.report5.Controls.Add(this.tabPage2);
            this.report5.Controls.Add(this.tabPage3);
            this.report5.Controls.Add(this.tabPage4);
            this.report5.Controls.Add(this.tabPage5);
            this.report5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.report5.Location = new System.Drawing.Point(16, 89);
            this.report5.Margin = new System.Windows.Forms.Padding(4);
            this.report5.Name = "report5";
            this.report5.SelectedIndex = 0;
            this.report5.Size = new System.Drawing.Size(921, 575);
            this.report5.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.report1_btn);
            this.tabPage1.Controls.Add(this.reportgrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(913, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 86);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find the popularity of rented car types from most popular to least popular.";
            // 
            // report1_btn
            // 
            this.report1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report1_btn.Location = new System.Drawing.Point(687, 257);
            this.report1_btn.Name = "report1_btn";
            this.report1_btn.Size = new System.Drawing.Size(109, 69);
            this.report1_btn.TabIndex = 1;
            this.report1_btn.Text = "Execute";
            this.report1_btn.UseVisualStyleBackColor = true;
            this.report1_btn.Click += new System.EventHandler(this.report1_btn_Click);
            // 
            // reportgrid1
            // 
            this.reportgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carTypeIDR1,
            this.carTypeR1,
            this.countR1});
            this.reportgrid1.Location = new System.Drawing.Point(0, 0);
            this.reportgrid1.Margin = new System.Windows.Forms.Padding(4);
            this.reportgrid1.Name = "reportgrid1";
            this.reportgrid1.RowHeadersWidth = 51;
            this.reportgrid1.Size = new System.Drawing.Size(595, 521);
            this.reportgrid1.TabIndex = 0;
            this.reportgrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportgrid1_CellContentClick);
            // 
            // carTypeIDR1
            // 
            this.carTypeIDR1.HeaderText = "Car Type ID";
            this.carTypeIDR1.MinimumWidth = 6;
            this.carTypeIDR1.Name = "carTypeIDR1";
            this.carTypeIDR1.ReadOnly = true;
            this.carTypeIDR1.Width = 125;
            // 
            // carTypeR1
            // 
            this.carTypeR1.HeaderText = "Car Type";
            this.carTypeR1.MinimumWidth = 6;
            this.carTypeR1.Name = "carTypeR1";
            this.carTypeR1.ReadOnly = true;
            this.carTypeR1.Width = 125;
            // 
            // countR1
            // 
            this.countR1.HeaderText = "Number Of Rentals";
            this.countR1.MinimumWidth = 6;
            this.countR1.Name = "countR1";
            this.countR1.ReadOnly = true;
            this.countR1.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.report2_btn);
            this.tabPage2.Controls.Add(this.reportgrid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(913, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 161);
            this.label3.TabIndex = 3;
            this.label3.Text = "Find the names of customers who have never returned a car to a branch in a city t" +
    "hat differs from their city.";
            // 
            // report2_btn
            // 
            this.report2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report2_btn.Location = new System.Drawing.Point(556, 307);
            this.report2_btn.Name = "report2_btn";
            this.report2_btn.Size = new System.Drawing.Size(136, 69);
            this.report2_btn.TabIndex = 1;
            this.report2_btn.Text = "Execute";
            this.report2_btn.UseVisualStyleBackColor = true;
            this.report2_btn.Click += new System.EventHandler(this.report2_btn_Click);
            // 
            // reportgrid2
            // 
            this.reportgrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.reportgrid2.Location = new System.Drawing.Point(0, 0);
            this.reportgrid2.Margin = new System.Windows.Forms.Padding(4);
            this.reportgrid2.Name = "reportgrid2";
            this.reportgrid2.RowHeadersWidth = 51;
            this.reportgrid2.Size = new System.Drawing.Size(413, 535);
            this.reportgrid2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.report3_btn);
            this.tabPage3.Controls.Add(this.reportgrid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(913, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 91);
            this.label4.TabIndex = 3;
            this.label4.Text = "Find the total amount of rentals made for each car type in each month.";
            // 
            // report3_btn
            // 
            this.report3_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report3_btn.Location = new System.Drawing.Point(691, 280);
            this.report3_btn.Name = "report3_btn";
            this.report3_btn.Size = new System.Drawing.Size(108, 73);
            this.report3_btn.TabIndex = 1;
            this.report3_btn.Text = "Execute";
            this.report3_btn.UseVisualStyleBackColor = true;
            this.report3_btn.Click += new System.EventHandler(this.report3_btn_Click);
            // 
            // reportgrid3
            // 
            this.reportgrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.carTypeIDR3,
            this.totalR3});
            this.reportgrid3.Location = new System.Drawing.Point(0, 0);
            this.reportgrid3.Margin = new System.Windows.Forms.Padding(4);
            this.reportgrid3.Name = "reportgrid3";
            this.reportgrid3.RowHeadersWidth = 51;
            this.reportgrid3.Size = new System.Drawing.Size(596, 543);
            this.reportgrid3.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Month";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // carTypeIDR3
            // 
            this.carTypeIDR3.HeaderText = "Car Type ID";
            this.carTypeIDR3.MinimumWidth = 6;
            this.carTypeIDR3.Name = "carTypeIDR3";
            this.carTypeIDR3.ReadOnly = true;
            this.carTypeIDR3.Width = 125;
            // 
            // totalR3
            // 
            this.totalR3.HeaderText = "Total Number Of Rentals";
            this.totalR3.MinimumWidth = 6;
            this.totalR3.Name = "totalR3";
            this.totalR3.ReadOnly = true;
            this.totalR3.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.monthLabel);
            this.tabPage4.Controls.Add(this.monthSelect);
            this.tabPage4.Controls.Add(this.report4_btn);
            this.tabPage4.Controls.Add(this.reportgrid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(913, 546);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 131);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find all customers who have not rented in the selected month.";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(588, 173);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(67, 25);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Month";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // monthSelect
            // 
            this.monthSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthSelect.FormattingEnabled = true;
            this.monthSelect.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthSelect.Location = new System.Drawing.Point(685, 170);
            this.monthSelect.Margin = new System.Windows.Forms.Padding(4);
            this.monthSelect.Name = "monthSelect";
            this.monthSelect.Size = new System.Drawing.Size(121, 33);
            this.monthSelect.TabIndex = 2;
            this.monthSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // report4_btn
            // 
            this.report4_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report4_btn.Location = new System.Drawing.Point(658, 327);
            this.report4_btn.Name = "report4_btn";
            this.report4_btn.Size = new System.Drawing.Size(108, 74);
            this.report4_btn.TabIndex = 1;
            this.report4_btn.Text = "Execute";
            this.report4_btn.UseVisualStyleBackColor = true;
            this.report4_btn.Click += new System.EventHandler(this.report4_btn_Click);
            // 
            // reportgrid4
            // 
            this.reportgrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDTab,
            this.Column11,
            this.Column12,
            this.Column13});
            this.reportgrid4.Location = new System.Drawing.Point(0, 0);
            this.reportgrid4.Margin = new System.Windows.Forms.Padding(4);
            this.reportgrid4.Name = "reportgrid4";
            this.reportgrid4.RowHeadersWidth = 51;
            this.reportgrid4.Size = new System.Drawing.Size(557, 535);
            this.reportgrid4.TabIndex = 0;
            this.reportgrid4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportgrid4_CellContentClick);
            // 
            // customerIDTab
            // 
            this.customerIDTab.HeaderText = "Customer ID";
            this.customerIDTab.MinimumWidth = 6;
            this.customerIDTab.Name = "customerIDTab";
            this.customerIDTab.ReadOnly = true;
            this.customerIDTab.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "First Name";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Middle Name";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Last Name";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.report5_btn);
            this.tabPage5.Controls.Add(this.reportgrid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(913, 546);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 112);
            this.label5.TabIndex = 7;
            this.label5.Text = "Find the rental amount made monthly for each branch in each month and year.";
            // 
            // report5_btn
            // 
            this.report5_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report5_btn.Location = new System.Drawing.Point(693, 252);
            this.report5_btn.Name = "report5_btn";
            this.report5_btn.Size = new System.Drawing.Size(114, 70);
            this.report5_btn.TabIndex = 6;
            this.report5_btn.Text = "Execute";
            this.report5_btn.UseVisualStyleBackColor = true;
            this.report5_btn.Click += new System.EventHandler(this.report5_btn_Click);
            // 
            // reportgrid5
            // 
            this.reportgrid5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportgrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column5});
            this.reportgrid5.Location = new System.Drawing.Point(0, 0);
            this.reportgrid5.Margin = new System.Windows.Forms.Padding(4);
            this.reportgrid5.Name = "reportgrid5";
            this.reportgrid5.RowHeadersWidth = 51;
            this.reportgrid5.Size = new System.Drawing.Size(615, 559);
            this.reportgrid5.TabIndex = 0;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "BID";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Description";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Year";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Month";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Rent Value";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 609);
            this.Controls.Add(this.report5);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ReportLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.report5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportgrid5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TabControl report5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView reportgrid1;
        private System.Windows.Forms.DataGridView reportgrid2;
        private System.Windows.Forms.DataGridView reportgrid3;
        private System.Windows.Forms.DataGridView reportgrid4;
        private System.Windows.Forms.DataGridView reportgrid5;
        private System.Windows.Forms.Button report1_btn;
        private System.Windows.Forms.Button report2_btn;
        private System.Windows.Forms.Button report3_btn;
        private System.Windows.Forms.Button report4_btn;
        private System.Windows.Forms.Button report5_btn;
        private System.Windows.Forms.ComboBox monthSelect;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeIDR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeIDR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}