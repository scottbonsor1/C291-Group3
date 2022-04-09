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
            this.report1_btn = new System.Windows.Forms.Button();
            this.reportgrid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.report2_btn = new System.Windows.Forms.Button();
            this.reportgrid2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.report3_btn = new System.Windows.Forms.Button();
            this.reportgrid3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.report4_btn = new System.Windows.Forms.Button();
            this.reportgrid4 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.ReportLabel.Location = new System.Drawing.Point(242, 22);
            this.ReportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(75, 24);
            this.ReportLabel.TabIndex = 2;
            this.ReportLabel.Text = "Reports";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(483, 545);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(77, 39);
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
            this.report5.Location = new System.Drawing.Point(12, 72);
            this.report5.Name = "report5";
            this.report5.SelectedIndex = 0;
            this.report5.Size = new System.Drawing.Size(552, 467);
            this.report5.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.report1_btn);
            this.tabPage1.Controls.Add(this.reportgrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(544, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // report1_btn
            // 
            this.report1_btn.Location = new System.Drawing.Point(406, 191);
            this.report1_btn.Name = "report1_btn";
            this.report1_btn.Size = new System.Drawing.Size(82, 56);
            this.report1_btn.TabIndex = 1;
            this.report1_btn.Text = "Execute";
            this.report1_btn.UseVisualStyleBackColor = true;
            this.report1_btn.Click += new System.EventHandler(this.report1_btn_Click);
            // 
            // reportgrid1
            // 
            this.reportgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column21});
            this.reportgrid1.Location = new System.Drawing.Point(0, 0);
            this.reportgrid1.Name = "reportgrid1";
            this.reportgrid1.Size = new System.Drawing.Size(343, 435);
            this.reportgrid1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Car_Type_ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Count";
            this.Column21.Name = "Column21";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.report2_btn);
            this.tabPage2.Controls.Add(this.reportgrid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(544, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // report2_btn
            // 
            this.report2_btn.Location = new System.Drawing.Point(349, 164);
            this.report2_btn.Name = "report2_btn";
            this.report2_btn.Size = new System.Drawing.Size(102, 56);
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
            this.reportgrid2.Name = "reportgrid2";
            this.reportgrid2.Size = new System.Drawing.Size(245, 435);
            this.reportgrid2.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.report3_btn);
            this.tabPage3.Controls.Add(this.reportgrid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(544, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Report 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // report3_btn
            // 
            this.report3_btn.Location = new System.Drawing.Point(406, 177);
            this.report3_btn.Name = "report3_btn";
            this.report3_btn.Size = new System.Drawing.Size(81, 59);
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
            this.Column8,
            this.Column9});
            this.reportgrid3.Location = new System.Drawing.Point(0, 0);
            this.reportgrid3.Name = "reportgrid3";
            this.reportgrid3.Size = new System.Drawing.Size(344, 441);
            this.reportgrid3.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Month";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Category";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total";
            this.Column9.Name = "Column9";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.report4_btn);
            this.tabPage4.Controls.Add(this.reportgrid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(544, 441);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Report 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // report4_btn
            // 
            this.report4_btn.Location = new System.Drawing.Point(408, 177);
            this.report4_btn.Name = "report4_btn";
            this.report4_btn.Size = new System.Drawing.Size(81, 60);
            this.report4_btn.TabIndex = 1;
            this.report4_btn.Text = "Execute";
            this.report4_btn.UseVisualStyleBackColor = true;
            this.report4_btn.Click += new System.EventHandler(this.report4_btn_Click);
            // 
            // reportgrid4
            // 
            this.reportgrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13});
            this.reportgrid4.Location = new System.Drawing.Point(0, 0);
            this.reportgrid4.Name = "reportgrid4";
            this.reportgrid4.Size = new System.Drawing.Size(346, 435);
            this.reportgrid4.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "First Name";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Middle Name";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Last Name";
            this.Column13.Name = "Column13";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.report5_btn);
            this.tabPage5.Controls.Add(this.reportgrid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(544, 441);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Report 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // report5_btn
            // 
            this.report5_btn.Location = new System.Drawing.Point(6, 396);
            this.report5_btn.Name = "report5_btn";
            this.report5_btn.Size = new System.Drawing.Size(77, 39);
            this.report5_btn.TabIndex = 6;
            this.report5_btn.Text = "Execute";
            this.report5_btn.UseVisualStyleBackColor = true;
            this.report5_btn.Click += new System.EventHandler(this.report5_btn_Click);
            // 
            // reportgrid5
            // 
            this.reportgrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportgrid5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column5});
            this.reportgrid5.Location = new System.Drawing.Point(0, 0);
            this.reportgrid5.Name = "reportgrid5";
            this.reportgrid5.Size = new System.Drawing.Size(544, 390);
            this.reportgrid5.TabIndex = 0;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "BID";
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Description";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Year";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Month";
            this.Column19.Name = "Column19";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Rent Value";
            this.Column5.Name = "Column5";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 610);
            this.Controls.Add(this.report5);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.ReportLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
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