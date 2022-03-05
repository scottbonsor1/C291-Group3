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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportDropDown = new System.Windows.Forms.ComboBox();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.executeReportBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(880, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // reportDropDown
            // 
            this.reportDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportDropDown.FormattingEnabled = true;
            this.reportDropDown.Items.AddRange(new object[] {
            "report 1",
            "report 2",
            "report 3",
            "report 4",
            "report 5"});
            this.reportDropDown.Location = new System.Drawing.Point(197, 32);
            this.reportDropDown.Name = "reportDropDown";
            this.reportDropDown.Size = new System.Drawing.Size(345, 33);
            this.reportDropDown.TabIndex = 1;
            this.reportDropDown.Text = "(choose a report)";
            this.reportDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(43, 32);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(92, 29);
            this.ReportLabel.TabIndex = 2;
            this.ReportLabel.Text = "Report:";
            // 
            // executeReportBtn
            // 
            this.executeReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeReportBtn.Location = new System.Drawing.Point(598, 12);
            this.executeReportBtn.Name = "executeReportBtn";
            this.executeReportBtn.Size = new System.Drawing.Size(170, 70);
            this.executeReportBtn.TabIndex = 3;
            this.executeReportBtn.Text = "Execute Report";
            this.executeReportBtn.UseVisualStyleBackColor = true;
            this.executeReportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(798, 25);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 40);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 532);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.executeReportBtn);
            this.Controls.Add(this.ReportLabel);
            this.Controls.Add(this.reportDropDown);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox reportDropDown;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Button executeReportBtn;
        private System.Windows.Forms.Button backBtn;
    }
}