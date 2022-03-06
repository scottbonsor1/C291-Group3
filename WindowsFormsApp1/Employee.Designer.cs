namespace WindowsFormsApp1
{
    partial class Employee
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
            this.CustomerBtn = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.carsTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.report_but = new System.Windows.Forms.Button();
            this.rent_but = new System.Windows.Forms.Button();
            this.customer_id = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.Label();
            this.middle_name = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.Label();
            this.street_address1 = new System.Windows.Forms.Label();
            this.street_address2 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.Label();
            this.postal_code = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.insurance = new System.Windows.Forms.Label();
            this.driver_license = new System.Windows.Forms.Label();
            this.membership_status = new System.Windows.Forms.Label();
            this.add_to_db = new System.Windows.Forms.Button();
            this.del_from_db = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.branch_street_add_1_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.TextBox();
            this.branch_street_address_2_txt = new System.Windows.Forms.TextBox();
            this.branch_city_txt = new System.Windows.Forms.TextBox();
            this.branch_province_txt = new System.Windows.Forms.TextBox();
            this.branch_postal_txt = new System.Windows.Forms.TextBox();
            this.branch_phone_num_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.branch_id_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cust_id_txt = new System.Windows.Forms.TextBox();
            this.cust_first_name_txt = new System.Windows.Forms.TextBox();
            this.cust_middle_name_txt = new System.Windows.Forms.TextBox();
            this.cust_last_name_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add1_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add2_txt = new System.Windows.Forms.TextBox();
            this.cust_city_txt = new System.Windows.Forms.TextBox();
            this.cust_province_txt = new System.Windows.Forms.TextBox();
            this.cust_postal_txt = new System.Windows.Forms.TextBox();
            this.cust_dob_txt = new System.Windows.Forms.TextBox();
            this.cust_phone_num_txt = new System.Windows.Forms.TextBox();
            this.cust_insurance_txt = new System.Windows.Forms.TextBox();
            this.cust_license_txt = new System.Windows.Forms.TextBox();
            this.cust_memberStat_txt = new System.Windows.Forms.TextBox();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(515, 11);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(75, 32);
            this.CustomerBtn.TabIndex = 2;
            this.CustomerBtn.Text = "Logout";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.carsTab);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Location = new System.Drawing.Point(10, 11);
            this.Tabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(500, 345);
            this.Tabs.TabIndex = 3;
            // 
            // carsTab
            // 
            this.carsTab.Location = new System.Drawing.Point(4, 22);
            this.carsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carsTab.Name = "carsTab";
            this.carsTab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carsTab.Size = new System.Drawing.Size(492, 319);
            this.carsTab.TabIndex = 0;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(492, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Car Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.branch_id_txt);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.branch_phone_num_txt);
            this.tabPage1.Controls.Add(this.branch_postal_txt);
            this.tabPage1.Controls.Add(this.branch_province_txt);
            this.tabPage1.Controls.Add(this.branch_city_txt);
            this.tabPage1.Controls.Add(this.branch_street_address_2_txt);
            this.tabPage1.Controls.Add(this.description_txt);
            this.tabPage1.Controls.Add(this.branch_street_add_1_txt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(492, 319);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Branches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cust_memberStat_txt);
            this.tabPage3.Controls.Add(this.cust_license_txt);
            this.tabPage3.Controls.Add(this.cust_insurance_txt);
            this.tabPage3.Controls.Add(this.cust_phone_num_txt);
            this.tabPage3.Controls.Add(this.cust_dob_txt);
            this.tabPage3.Controls.Add(this.cust_postal_txt);
            this.tabPage3.Controls.Add(this.cust_province_txt);
            this.tabPage3.Controls.Add(this.cust_city_txt);
            this.tabPage3.Controls.Add(this.cust_street_add2_txt);
            this.tabPage3.Controls.Add(this.cust_street_add1_txt);
            this.tabPage3.Controls.Add(this.cust_last_name_txt);
            this.tabPage3.Controls.Add(this.cust_middle_name_txt);
            this.tabPage3.Controls.Add(this.cust_first_name_txt);
            this.tabPage3.Controls.Add(this.cust_id_txt);
            this.tabPage3.Controls.Add(this.del_from_db);
            this.tabPage3.Controls.Add(this.add_to_db);
            this.tabPage3.Controls.Add(this.membership_status);
            this.tabPage3.Controls.Add(this.dob);
            this.tabPage3.Controls.Add(this.phone_num);
            this.tabPage3.Controls.Add(this.insurance);
            this.tabPage3.Controls.Add(this.driver_license);
            this.tabPage3.Controls.Add(this.postal_code);
            this.tabPage3.Controls.Add(this.province);
            this.tabPage3.Controls.Add(this.city);
            this.tabPage3.Controls.Add(this.street_address2);
            this.tabPage3.Controls.Add(this.street_address1);
            this.tabPage3.Controls.Add(this.last_name);
            this.tabPage3.Controls.Add(this.middle_name);
            this.tabPage3.Controls.Add(this.first_name);
            this.tabPage3.Controls.Add(this.customer_id);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(492, 319);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // report_but
            // 
            this.report_but.Location = new System.Drawing.Point(516, 301);
            this.report_but.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.report_but.Name = "report_but";
            this.report_but.Size = new System.Drawing.Size(75, 52);
            this.report_but.TabIndex = 4;
            this.report_but.Text = "Report";
            this.report_but.UseVisualStyleBackColor = true;
            this.report_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // rent_but
            // 
            this.rent_but.Location = new System.Drawing.Point(516, 142);
            this.rent_but.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rent_but.Name = "rent_but";
            this.rent_but.Size = new System.Drawing.Size(75, 52);
            this.rent_but.TabIndex = 5;
            this.rent_but.Text = "Rent";
            this.rent_but.UseVisualStyleBackColor = true;
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(9, 6);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(65, 13);
            this.customer_id.TabIndex = 0;
            this.customer_id.Text = "Customer ID";
            // 
            // first_name
            // 
            this.first_name.AutoSize = true;
            this.first_name.Location = new System.Drawing.Point(9, 37);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(57, 13);
            this.first_name.TabIndex = 1;
            this.first_name.Text = "First Name";
            this.first_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // middle_name
            // 
            this.middle_name.AutoSize = true;
            this.middle_name.Location = new System.Drawing.Point(9, 68);
            this.middle_name.Name = "middle_name";
            this.middle_name.Size = new System.Drawing.Size(69, 13);
            this.middle_name.TabIndex = 2;
            this.middle_name.Text = "Middle Name";
            // 
            // last_name
            // 
            this.last_name.AutoSize = true;
            this.last_name.Location = new System.Drawing.Point(9, 96);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(58, 13);
            this.last_name.TabIndex = 3;
            this.last_name.Text = "Last Name";
            // 
            // street_address1
            // 
            this.street_address1.AutoSize = true;
            this.street_address1.Location = new System.Drawing.Point(9, 128);
            this.street_address1.Name = "street_address1";
            this.street_address1.Size = new System.Drawing.Size(85, 13);
            this.street_address1.TabIndex = 4;
            this.street_address1.Text = "Street Address 1";
            // 
            // street_address2
            // 
            this.street_address2.AutoSize = true;
            this.street_address2.Location = new System.Drawing.Point(9, 161);
            this.street_address2.Name = "street_address2";
            this.street_address2.Size = new System.Drawing.Size(85, 13);
            this.street_address2.TabIndex = 5;
            this.street_address2.Text = "Street Address 2";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(9, 194);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 6;
            this.city.Text = "City";
            // 
            // province
            // 
            this.province.AutoSize = true;
            this.province.Location = new System.Drawing.Point(9, 226);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(49, 13);
            this.province.TabIndex = 7;
            this.province.Text = "Province";
            this.province.Click += new System.EventHandler(this.label8_Click);
            // 
            // postal_code
            // 
            this.postal_code.AutoSize = true;
            this.postal_code.Location = new System.Drawing.Point(9, 261);
            this.postal_code.Name = "postal_code";
            this.postal_code.Size = new System.Drawing.Size(64, 13);
            this.postal_code.TabIndex = 8;
            this.postal_code.Text = "Postal Code";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(9, 293);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(30, 13);
            this.dob.TabIndex = 6;
            this.dob.Text = "DOB";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Location = new System.Drawing.Point(239, 0);
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(78, 13);
            this.phone_num.TabIndex = 7;
            this.phone_num.Text = "Phone Number";
            // 
            // insurance
            // 
            this.insurance.AutoSize = true;
            this.insurance.Location = new System.Drawing.Point(239, 37);
            this.insurance.Name = "insurance";
            this.insurance.Size = new System.Drawing.Size(54, 13);
            this.insurance.TabIndex = 8;
            this.insurance.Text = "Insurance";
            // 
            // driver_license
            // 
            this.driver_license.AutoSize = true;
            this.driver_license.Location = new System.Drawing.Point(239, 75);
            this.driver_license.Name = "driver_license";
            this.driver_license.Size = new System.Drawing.Size(75, 13);
            this.driver_license.TabIndex = 9;
            this.driver_license.Text = "Driver License";
            // 
            // membership_status
            // 
            this.membership_status.AutoSize = true;
            this.membership_status.Location = new System.Drawing.Point(239, 118);
            this.membership_status.Name = "membership_status";
            this.membership_status.Size = new System.Drawing.Size(97, 13);
            this.membership_status.TabIndex = 10;
            this.membership_status.Text = "Membership Status";
            this.membership_status.Click += new System.EventHandler(this.label14_Click);
            // 
            // add_to_db
            // 
            this.add_to_db.Location = new System.Drawing.Point(253, 198);
            this.add_to_db.Name = "add_to_db";
            this.add_to_db.Size = new System.Drawing.Size(83, 48);
            this.add_to_db.TabIndex = 27;
            this.add_to_db.Text = "Add";
            this.add_to_db.UseVisualStyleBackColor = true;
            this.add_to_db.Click += new System.EventHandler(this.add_to_db_Click);
            // 
            // del_from_db
            // 
            this.del_from_db.Location = new System.Drawing.Point(381, 198);
            this.del_from_db.Name = "del_from_db";
            this.del_from_db.Size = new System.Drawing.Size(83, 48);
            this.del_from_db.TabIndex = 28;
            this.del_from_db.Text = "Delete";
            this.del_from_db.UseVisualStyleBackColor = true;
            this.del_from_db.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Street Address 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stree Address 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Province";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Postal Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number";
            // 
            // branch_street_add_1_txt
            // 
            this.branch_street_add_1_txt.Location = new System.Drawing.Point(93, 80);
            this.branch_street_add_1_txt.Name = "branch_street_add_1_txt";
            this.branch_street_add_1_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_street_add_1_txt.TabIndex = 15;
            // 
            // description_txt
            // 
            this.description_txt.Location = new System.Drawing.Point(93, 44);
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(133, 20);
            this.description_txt.TabIndex = 16;
            // 
            // branch_street_address_2_txt
            // 
            this.branch_street_address_2_txt.Location = new System.Drawing.Point(93, 119);
            this.branch_street_address_2_txt.Name = "branch_street_address_2_txt";
            this.branch_street_address_2_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_street_address_2_txt.TabIndex = 17;
            // 
            // branch_city_txt
            // 
            this.branch_city_txt.Location = new System.Drawing.Point(93, 157);
            this.branch_city_txt.Name = "branch_city_txt";
            this.branch_city_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_city_txt.TabIndex = 18;
            // 
            // branch_province_txt
            // 
            this.branch_province_txt.Location = new System.Drawing.Point(93, 193);
            this.branch_province_txt.Name = "branch_province_txt";
            this.branch_province_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_province_txt.TabIndex = 19;
            // 
            // branch_postal_txt
            // 
            this.branch_postal_txt.Location = new System.Drawing.Point(93, 230);
            this.branch_postal_txt.Name = "branch_postal_txt";
            this.branch_postal_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_postal_txt.TabIndex = 20;
            // 
            // branch_phone_num_txt
            // 
            this.branch_phone_num_txt.Location = new System.Drawing.Point(93, 265);
            this.branch_phone_num_txt.Name = "branch_phone_num_txt";
            this.branch_phone_num_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_phone_num_txt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Branch ID ";
            // 
            // branch_id_txt
            // 
            this.branch_id_txt.Location = new System.Drawing.Point(340, 47);
            this.branch_id_txt.Name = "branch_id_txt";
            this.branch_id_txt.Size = new System.Drawing.Size(133, 20);
            this.branch_id_txt.TabIndex = 23;
            this.branch_id_txt.TextChanged += new System.EventHandler(this.branch_id_txt_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 56);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cust_id_txt
            // 
            this.cust_id_txt.Location = new System.Drawing.Point(100, 6);
            this.cust_id_txt.Name = "cust_id_txt";
            this.cust_id_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_id_txt.TabIndex = 29;
            // 
            // cust_first_name_txt
            // 
            this.cust_first_name_txt.Location = new System.Drawing.Point(100, 37);
            this.cust_first_name_txt.Name = "cust_first_name_txt";
            this.cust_first_name_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_first_name_txt.TabIndex = 30;
            // 
            // cust_middle_name_txt
            // 
            this.cust_middle_name_txt.Location = new System.Drawing.Point(100, 68);
            this.cust_middle_name_txt.Name = "cust_middle_name_txt";
            this.cust_middle_name_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_middle_name_txt.TabIndex = 31;
            // 
            // cust_last_name_txt
            // 
            this.cust_last_name_txt.Location = new System.Drawing.Point(100, 96);
            this.cust_last_name_txt.Name = "cust_last_name_txt";
            this.cust_last_name_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_last_name_txt.TabIndex = 32;
            // 
            // cust_street_add1_txt
            // 
            this.cust_street_add1_txt.Location = new System.Drawing.Point(100, 128);
            this.cust_street_add1_txt.Name = "cust_street_add1_txt";
            this.cust_street_add1_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_street_add1_txt.TabIndex = 33;
            // 
            // cust_street_add2_txt
            // 
            this.cust_street_add2_txt.Location = new System.Drawing.Point(100, 161);
            this.cust_street_add2_txt.Name = "cust_street_add2_txt";
            this.cust_street_add2_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_street_add2_txt.TabIndex = 34;
            // 
            // cust_city_txt
            // 
            this.cust_city_txt.Location = new System.Drawing.Point(100, 194);
            this.cust_city_txt.Name = "cust_city_txt";
            this.cust_city_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_city_txt.TabIndex = 35;
            // 
            // cust_province_txt
            // 
            this.cust_province_txt.Location = new System.Drawing.Point(100, 226);
            this.cust_province_txt.Name = "cust_province_txt";
            this.cust_province_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_province_txt.TabIndex = 36;
            // 
            // cust_postal_txt
            // 
            this.cust_postal_txt.Location = new System.Drawing.Point(100, 261);
            this.cust_postal_txt.Name = "cust_postal_txt";
            this.cust_postal_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_postal_txt.TabIndex = 37;
            this.cust_postal_txt.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // cust_dob_txt
            // 
            this.cust_dob_txt.Location = new System.Drawing.Point(100, 293);
            this.cust_dob_txt.Name = "cust_dob_txt";
            this.cust_dob_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_dob_txt.TabIndex = 38;
            // 
            // cust_phone_num_txt
            // 
            this.cust_phone_num_txt.Location = new System.Drawing.Point(353, 0);
            this.cust_phone_num_txt.Name = "cust_phone_num_txt";
            this.cust_phone_num_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_phone_num_txt.TabIndex = 39;
            // 
            // cust_insurance_txt
            // 
            this.cust_insurance_txt.Location = new System.Drawing.Point(353, 37);
            this.cust_insurance_txt.Name = "cust_insurance_txt";
            this.cust_insurance_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_insurance_txt.TabIndex = 40;
            // 
            // cust_license_txt
            // 
            this.cust_license_txt.Location = new System.Drawing.Point(353, 75);
            this.cust_license_txt.Name = "cust_license_txt";
            this.cust_license_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_license_txt.TabIndex = 41;
            // 
            // cust_memberStat_txt
            // 
            this.cust_memberStat_txt.Location = new System.Drawing.Point(353, 118);
            this.cust_memberStat_txt.Name = "cust_memberStat_txt";
            this.cust_memberStat_txt.Size = new System.Drawing.Size(116, 20);
            this.cust_memberStat_txt.TabIndex = 42;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 387);
            this.Controls.Add(this.rent_but);
            this.Controls.Add(this.report_but);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.CustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button report_but;
        private System.Windows.Forms.Button rent_but;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label postal_code;
        private System.Windows.Forms.Label province;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label street_address2;
        private System.Windows.Forms.Label street_address1;
        private System.Windows.Forms.Label last_name;
        private System.Windows.Forms.Label middle_name;
        private System.Windows.Forms.Label first_name;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.Label membership_status;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label phone_num;
        private System.Windows.Forms.Label insurance;
        private System.Windows.Forms.Label driver_license;
        private System.Windows.Forms.Button del_from_db;
        private System.Windows.Forms.Button add_to_db;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox branch_phone_num_txt;
        private System.Windows.Forms.TextBox branch_postal_txt;
        private System.Windows.Forms.TextBox branch_province_txt;
        private System.Windows.Forms.TextBox branch_city_txt;
        private System.Windows.Forms.TextBox branch_street_address_2_txt;
        private System.Windows.Forms.TextBox description_txt;
        private System.Windows.Forms.TextBox branch_street_add_1_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox branch_id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cust_memberStat_txt;
        private System.Windows.Forms.TextBox cust_license_txt;
        private System.Windows.Forms.TextBox cust_insurance_txt;
        private System.Windows.Forms.TextBox cust_phone_num_txt;
        private System.Windows.Forms.TextBox cust_dob_txt;
        private System.Windows.Forms.TextBox cust_postal_txt;
        private System.Windows.Forms.TextBox cust_province_txt;
        private System.Windows.Forms.TextBox cust_city_txt;
        private System.Windows.Forms.TextBox cust_street_add2_txt;
        private System.Windows.Forms.TextBox cust_street_add1_txt;
        private System.Windows.Forms.TextBox cust_last_name_txt;
        private System.Windows.Forms.TextBox cust_middle_name_txt;
        private System.Windows.Forms.TextBox cust_first_name_txt;
        private System.Windows.Forms.TextBox cust_id_txt;
    }
}