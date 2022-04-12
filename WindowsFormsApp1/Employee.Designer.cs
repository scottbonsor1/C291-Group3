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
            this.cars_search_dropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cars_show_all = new System.Windows.Forms.Button();
            this.btn_cars_delete = new System.Windows.Forms.Button();
            this.cars_delete_dropdown = new System.Windows.Forms.ComboBox();
            this.cars_search_attribute_dropdown = new System.Windows.Forms.ComboBox();
            this.cars_search_label = new System.Windows.Forms.Label();
            this.btn_cars_edit = new System.Windows.Forms.Button();
            this.cars_car_type_id_dropdown = new System.Windows.Forms.ComboBox();
            this.cars_car_type_id_label = new System.Windows.Forms.Label();
            this.cars_make_label = new System.Windows.Forms.Label();
            this.cars_make_txt = new System.Windows.Forms.TextBox();
            this.btn_cars_search = new System.Windows.Forms.Button();
            this.btn_cars_add = new System.Windows.Forms.Button();
            this.cars_view = new System.Windows.Forms.DataGridView();
            this.VIN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_SEATS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOUR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSURANCE_NO_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODOMETER_NO_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRANCH_ID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_TYPE_ID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cars_odometer_no_txt = new System.Windows.Forms.TextBox();
            this.cars_no_seats_txt = new System.Windows.Forms.TextBox();
            this.cars_colour_txt = new System.Windows.Forms.TextBox();
            this.cars_insurance_no_txt = new System.Windows.Forms.TextBox();
            this.cars_year_txt = new System.Windows.Forms.TextBox();
            this.cars_model_txt = new System.Windows.Forms.TextBox();
            this.cars_odometer_label = new System.Windows.Forms.Label();
            this.cars_no_seats_label = new System.Windows.Forms.Label();
            this.cars_colour_label = new System.Windows.Forms.Label();
            this.cars_insurance_no_label = new System.Windows.Forms.Label();
            this.cars_year_label = new System.Windows.Forms.Label();
            this.cars_model_label = new System.Windows.Forms.Label();
            this.cars_vin_label = new System.Windows.Forms.Label();
            this.cars_branch_id_dropdown = new System.Windows.Forms.ComboBox();
            this.cars_vin_text = new System.Windows.Forms.TextBox();
            this.cars_branch_id_label = new System.Windows.Forms.Label();
            this.carTypeTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mCostS2 = new System.Windows.Forms.TextBox();
            this.mCostS1 = new System.Windows.Forms.TextBox();
            this.wCostS2 = new System.Windows.Forms.TextBox();
            this.wCostS1 = new System.Windows.Forms.TextBox();
            this.dCostS2 = new System.Windows.Forms.TextBox();
            this.dCostS1 = new System.Windows.Forms.TextBox();
            this.descS = new System.Windows.Forms.TextBox();
            this.editTypeBut = new System.Windows.Forms.Button();
            this.delTypeBut = new System.Windows.Forms.Button();
            this.DailyRentLabel = new System.Windows.Forms.Label();
            this.WeeklyRentLabel = new System.Windows.Forms.Label();
            this.MonthlyRentLabel = new System.Windows.Forms.Label();
            this.mRent = new System.Windows.Forms.TextBox();
            this.wRent = new System.Windows.Forms.TextBox();
            this.modelS = new System.Windows.Forms.TextBox();
            this.dRent = new System.Windows.Forms.TextBox();
            this.typeDesc = new System.Windows.Forms.TextBox();
            this.modelID = new System.Windows.Forms.TextBox();
            this.rentalCostSLabel = new System.Windows.Forms.Label();
            this.typeSDescLabel = new System.Windows.Forms.Label();
            this.modelSLabel = new System.Windows.Forms.Label();
            this.rentalCostLabel = new System.Windows.Forms.Label();
            this.typeDescLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.typeSBut = new System.Windows.Forms.Button();
            this.addTypeBut = new System.Windows.Forms.Button();
            this.carTypeView = new System.Windows.Forms.DataGridView();
            this.MODEL_ID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENTAL_CLASS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAILY_RENTAL_COST_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEEKLY_RENTAL_COST_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTHLY_RENTAL_COST_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.branch_search_text_box = new System.Windows.Forms.TextBox();
            this.branch_search_box = new System.Windows.Forms.ComboBox();
            this.branch_search_label = new System.Windows.Forms.Label();
            this.branch_edit_but = new System.Windows.Forms.Button();
            this.branch_refresh_but = new System.Windows.Forms.Button();
            this.branch_id_LU_label = new System.Windows.Forms.Label();
            this.branch_id_LU_txt = new System.Windows.Forms.TextBox();
            this.branch_search_but = new System.Windows.Forms.Button();
            this.branch_del_but = new System.Windows.Forms.Button();
            this.branch_add_but = new System.Windows.Forms.Button();
            this.branch_view = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch_id_txt = new System.Windows.Forms.TextBox();
            this.branch_phone_num_txt = new System.Windows.Forms.TextBox();
            this.branch_pCode_txt = new System.Windows.Forms.TextBox();
            this.branch_province_txt = new System.Windows.Forms.TextBox();
            this.branch_city_txt = new System.Windows.Forms.TextBox();
            this.branch_street_add2_txt = new System.Windows.Forms.TextBox();
            this.branch_street_add1_txt = new System.Windows.Forms.TextBox();
            this.branch_descrip_txt = new System.Windows.Forms.TextBox();
            this.branch_phone_num_label = new System.Windows.Forms.Label();
            this.branch_pCode_label = new System.Windows.Forms.Label();
            this.branch_province_label = new System.Windows.Forms.Label();
            this.branch_city_label = new System.Windows.Forms.Label();
            this.branch_street_add2_label = new System.Windows.Forms.Label();
            this.branch_street_add1_label = new System.Windows.Forms.Label();
            this.branch_dscrip_label = new System.Windows.Forms.Label();
            this.branch_id_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cust_del_but = new System.Windows.Forms.Button();
            this.cust_box_search = new System.Windows.Forms.ComboBox();
            this.cust_id_search_label = new System.Windows.Forms.Label();
            this.cust_id_LU_txt = new System.Windows.Forms.TextBox();
            this.cust_search_box_txt = new System.Windows.Forms.TextBox();
            this.cust_search_box = new System.Windows.Forms.Label();
            this.cust_search_but = new System.Windows.Forms.Button();
            this.cust_refresh_but = new System.Windows.Forms.Button();
            this.cust_edit_but = new System.Windows.Forms.Button();
            this.customer_view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_add_but = new System.Windows.Forms.Button();
            this.cust_drivers_txt = new System.Windows.Forms.TextBox();
            this.cust_insurance_txt = new System.Windows.Forms.TextBox();
            this.cust_phone_num_txt = new System.Windows.Forms.TextBox();
            this.cust_dob_txt = new System.Windows.Forms.TextBox();
            this.cust_pCode_txt = new System.Windows.Forms.TextBox();
            this.cust_prov_txt = new System.Windows.Forms.TextBox();
            this.cust_city_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add2_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add1_txt = new System.Windows.Forms.TextBox();
            this.cust_last_name_txt = new System.Windows.Forms.TextBox();
            this.cust_mid_name_txt = new System.Windows.Forms.TextBox();
            this.cust_first_name_txt = new System.Windows.Forms.TextBox();
            this.cust_custID_txt = new System.Windows.Forms.TextBox();
            this.cust_drivers_label = new System.Windows.Forms.Label();
            this.cust_insurance_label = new System.Windows.Forms.Label();
            this.cust_phone_num_label = new System.Windows.Forms.Label();
            this.cust_dob_label = new System.Windows.Forms.Label();
            this.cust_pCode_label = new System.Windows.Forms.Label();
            this.cust_province_label = new System.Windows.Forms.Label();
            this.cust_city_label = new System.Windows.Forms.Label();
            this.cust_street_add2_label = new System.Windows.Forms.Label();
            this.cust_street_add1_label = new System.Windows.Forms.Label();
            this.cust_last_name_label = new System.Windows.Forms.Label();
            this.cust_mid_name_label = new System.Windows.Forms.Label();
            this.cust_f_name_label = new System.Windows.Forms.Label();
            this.cust_custID_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.carsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cars_view)).BeginInit();
            this.carTypeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_view)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_view)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(1707, 809);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(100, 39);
            this.CustomerBtn.TabIndex = 2;
            this.CustomerBtn.Text = "Logout";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.carsTab);
            this.Tabs.Controls.Add(this.carTypeTab);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Location = new System.Drawing.Point(13, 14);
            this.Tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1844, 753);
            this.Tabs.TabIndex = 3;
            // 
            // carsTab
            // 
            this.carsTab.Controls.Add(this.cars_search_dropdown);
            this.carsTab.Controls.Add(this.label1);
            this.carsTab.Controls.Add(this.btn_cars_show_all);
            this.carsTab.Controls.Add(this.btn_cars_delete);
            this.carsTab.Controls.Add(this.cars_delete_dropdown);
            this.carsTab.Controls.Add(this.cars_search_attribute_dropdown);
            this.carsTab.Controls.Add(this.cars_search_label);
            this.carsTab.Controls.Add(this.btn_cars_edit);
            this.carsTab.Controls.Add(this.cars_car_type_id_dropdown);
            this.carsTab.Controls.Add(this.cars_car_type_id_label);
            this.carsTab.Controls.Add(this.cars_make_label);
            this.carsTab.Controls.Add(this.cars_make_txt);
            this.carsTab.Controls.Add(this.btn_cars_search);
            this.carsTab.Controls.Add(this.btn_cars_add);
            this.carsTab.Controls.Add(this.cars_view);
            this.carsTab.Controls.Add(this.cars_odometer_no_txt);
            this.carsTab.Controls.Add(this.cars_no_seats_txt);
            this.carsTab.Controls.Add(this.cars_colour_txt);
            this.carsTab.Controls.Add(this.cars_insurance_no_txt);
            this.carsTab.Controls.Add(this.cars_year_txt);
            this.carsTab.Controls.Add(this.cars_model_txt);
            this.carsTab.Controls.Add(this.cars_odometer_label);
            this.carsTab.Controls.Add(this.cars_no_seats_label);
            this.carsTab.Controls.Add(this.cars_colour_label);
            this.carsTab.Controls.Add(this.cars_insurance_no_label);
            this.carsTab.Controls.Add(this.cars_year_label);
            this.carsTab.Controls.Add(this.cars_model_label);
            this.carsTab.Controls.Add(this.cars_vin_label);
            this.carsTab.Controls.Add(this.cars_branch_id_dropdown);
            this.carsTab.Controls.Add(this.cars_vin_text);
            this.carsTab.Controls.Add(this.cars_branch_id_label);
            this.carsTab.Location = new System.Drawing.Point(4, 25);
            this.carsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsTab.Name = "carsTab";
            this.carsTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carsTab.Size = new System.Drawing.Size(1836, 724);
            this.carsTab.TabIndex = 0;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            this.carsTab.Click += new System.EventHandler(this.carsTab_Click);
            // 
            // cars_search_dropdown
            // 
            this.cars_search_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_search_dropdown.FormattingEnabled = true;
            this.cars_search_dropdown.Location = new System.Drawing.Point(749, 619);
            this.cars_search_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_dropdown.Name = "cars_search_dropdown";
            this.cars_search_dropdown.Size = new System.Drawing.Size(160, 28);
            this.cars_search_dropdown.TabIndex = 41;
            this.cars_search_dropdown.Tag = "carTypeOptions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1212, 623);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "VIN:";
            // 
            // btn_cars_show_all
            // 
            this.btn_cars_show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_show_all.Location = new System.Drawing.Point(1639, 638);
            this.btn_cars_show_all.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars_show_all.Name = "btn_cars_show_all";
            this.btn_cars_show_all.Size = new System.Drawing.Size(125, 37);
            this.btn_cars_show_all.TabIndex = 39;
            this.btn_cars_show_all.Text = "Show All";
            this.btn_cars_show_all.UseVisualStyleBackColor = true;
            this.btn_cars_show_all.Click += new System.EventHandler(this.btn_cars_show_all_Click);
            // 
            // btn_cars_delete
            // 
            this.btn_cars_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_delete.Location = new System.Drawing.Point(1281, 656);
            this.btn_cars_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars_delete.Name = "btn_cars_delete";
            this.btn_cars_delete.Size = new System.Drawing.Size(125, 37);
            this.btn_cars_delete.TabIndex = 38;
            this.btn_cars_delete.Text = "Delete";
            this.btn_cars_delete.UseVisualStyleBackColor = true;
            this.btn_cars_delete.Click += new System.EventHandler(this.btn_cars_delete_Click);
            // 
            // cars_delete_dropdown
            // 
            this.cars_delete_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_delete_dropdown.FormattingEnabled = true;
            this.cars_delete_dropdown.Location = new System.Drawing.Point(1265, 619);
            this.cars_delete_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.cars_delete_dropdown.Name = "cars_delete_dropdown";
            this.cars_delete_dropdown.Size = new System.Drawing.Size(160, 28);
            this.cars_delete_dropdown.TabIndex = 37;
            this.cars_delete_dropdown.Tag = "carTypeOptions";
            this.cars_delete_dropdown.Text = "--- Select ---";
            // 
            // cars_search_attribute_dropdown
            // 
            this.cars_search_attribute_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_search_attribute_dropdown.FormattingEnabled = true;
            this.cars_search_attribute_dropdown.Items.AddRange(new object[] {
            "VIN",
            "Make",
            "Model",
            "Year",
            "No_of_Seats",
            "Colour",
            "Insurance_No",
            "Odometer_No",
            "Branch_ID",
            "Car_Type_ID"});
            this.cars_search_attribute_dropdown.Location = new System.Drawing.Point(565, 619);
            this.cars_search_attribute_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.cars_search_attribute_dropdown.Name = "cars_search_attribute_dropdown";
            this.cars_search_attribute_dropdown.Size = new System.Drawing.Size(160, 28);
            this.cars_search_attribute_dropdown.TabIndex = 35;
            this.cars_search_attribute_dropdown.Tag = "carTypeOptions";
            this.cars_search_attribute_dropdown.Text = "--- Select ---";
            this.cars_search_attribute_dropdown.SelectedIndexChanged += new System.EventHandler(this.cars_search_attribute_dropdown_SelectedIndexChanged);
            // 
            // cars_search_label
            // 
            this.cars_search_label.AutoSize = true;
            this.cars_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_search_label.Location = new System.Drawing.Point(455, 623);
            this.cars_search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_search_label.Name = "cars_search_label";
            this.cars_search_label.Size = new System.Drawing.Size(92, 20);
            this.cars_search_label.TabIndex = 34;
            this.cars_search_label.Text = "Search By:";
            // 
            // btn_cars_edit
            // 
            this.btn_cars_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_edit.Location = new System.Drawing.Point(189, 558);
            this.btn_cars_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars_edit.Name = "btn_cars_edit";
            this.btn_cars_edit.Size = new System.Drawing.Size(125, 42);
            this.btn_cars_edit.TabIndex = 33;
            this.btn_cars_edit.Text = "Edit Car";
            this.btn_cars_edit.UseVisualStyleBackColor = true;
            this.btn_cars_edit.Click += new System.EventHandler(this.btn_cars_edit_Click);
            // 
            // cars_car_type_id_dropdown
            // 
            this.cars_car_type_id_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_car_type_id_dropdown.FormattingEnabled = true;
            this.cars_car_type_id_dropdown.Location = new System.Drawing.Point(172, 487);
            this.cars_car_type_id_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.cars_car_type_id_dropdown.Name = "cars_car_type_id_dropdown";
            this.cars_car_type_id_dropdown.Size = new System.Drawing.Size(160, 28);
            this.cars_car_type_id_dropdown.TabIndex = 32;
            this.cars_car_type_id_dropdown.Tag = "carTypeOptions";
            // 
            // cars_car_type_id_label
            // 
            this.cars_car_type_id_label.AutoSize = true;
            this.cars_car_type_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_car_type_id_label.Location = new System.Drawing.Point(21, 490);
            this.cars_car_type_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_car_type_id_label.Name = "cars_car_type_id_label";
            this.cars_car_type_id_label.Size = new System.Drawing.Size(99, 20);
            this.cars_car_type_id_label.TabIndex = 31;
            this.cars_car_type_id_label.Text = "Car Type ID";
            // 
            // cars_make_label
            // 
            this.cars_make_label.AutoSize = true;
            this.cars_make_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_make_label.Location = new System.Drawing.Point(21, 96);
            this.cars_make_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_make_label.Name = "cars_make_label";
            this.cars_make_label.Size = new System.Drawing.Size(49, 20);
            this.cars_make_label.TabIndex = 30;
            this.cars_make_label.Text = "Make";
            // 
            // cars_make_txt
            // 
            this.cars_make_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_make_txt.Location = new System.Drawing.Point(172, 92);
            this.cars_make_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_make_txt.Name = "cars_make_txt";
            this.cars_make_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_make_txt.TabIndex = 29;
            // 
            // btn_cars_search
            // 
            this.btn_cars_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_search.Location = new System.Drawing.Point(579, 656);
            this.btn_cars_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars_search.Name = "btn_cars_search";
            this.btn_cars_search.Size = new System.Drawing.Size(125, 37);
            this.btn_cars_search.TabIndex = 28;
            this.btn_cars_search.Text = "Search";
            this.btn_cars_search.UseVisualStyleBackColor = true;
            this.btn_cars_search.Click += new System.EventHandler(this.btn_cars_search_Click);
            // 
            // btn_cars_add
            // 
            this.btn_cars_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars_add.Location = new System.Drawing.Point(25, 558);
            this.btn_cars_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cars_add.Name = "btn_cars_add";
            this.btn_cars_add.Size = new System.Drawing.Size(125, 42);
            this.btn_cars_add.TabIndex = 27;
            this.btn_cars_add.Text = "Add Car";
            this.btn_cars_add.UseVisualStyleBackColor = true;
            this.btn_cars_add.Click += new System.EventHandler(this.btn_cars_add_Click);
            // 
            // cars_view
            // 
            this.cars_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cars_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cars_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN_COL,
            this.MAKE_COL,
            this.MODEL_COL,
            this.YEAR_COL,
            this.NO_SEATS_COL,
            this.COLOUR_COL,
            this.INSURANCE_NO_COL,
            this.ODOMETER_NO_COL,
            this.BRANCH_ID_COL,
            this.CAR_TYPE_ID_COL});
            this.cars_view.Location = new System.Drawing.Point(341, 0);
            this.cars_view.Margin = new System.Windows.Forms.Padding(4);
            this.cars_view.Name = "cars_view";
            this.cars_view.RowHeadersWidth = 51;
            this.cars_view.Size = new System.Drawing.Size(1447, 599);
            this.cars_view.TabIndex = 17;
            this.cars_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cars_view_CellContentClick);
            // 
            // VIN_COL
            // 
            this.VIN_COL.HeaderText = "VIN";
            this.VIN_COL.MinimumWidth = 6;
            this.VIN_COL.Name = "VIN_COL";
            this.VIN_COL.ReadOnly = true;
            // 
            // MAKE_COL
            // 
            this.MAKE_COL.HeaderText = "Make";
            this.MAKE_COL.MinimumWidth = 6;
            this.MAKE_COL.Name = "MAKE_COL";
            this.MAKE_COL.ReadOnly = true;
            // 
            // MODEL_COL
            // 
            this.MODEL_COL.HeaderText = "Model";
            this.MODEL_COL.MinimumWidth = 6;
            this.MODEL_COL.Name = "MODEL_COL";
            this.MODEL_COL.ReadOnly = true;
            // 
            // YEAR_COL
            // 
            this.YEAR_COL.HeaderText = "Year";
            this.YEAR_COL.MinimumWidth = 6;
            this.YEAR_COL.Name = "YEAR_COL";
            this.YEAR_COL.ReadOnly = true;
            // 
            // NO_SEATS_COL
            // 
            this.NO_SEATS_COL.HeaderText = "No. of Seats";
            this.NO_SEATS_COL.MinimumWidth = 6;
            this.NO_SEATS_COL.Name = "NO_SEATS_COL";
            this.NO_SEATS_COL.ReadOnly = true;
            // 
            // COLOUR_COL
            // 
            this.COLOUR_COL.HeaderText = "Colour";
            this.COLOUR_COL.MinimumWidth = 6;
            this.COLOUR_COL.Name = "COLOUR_COL";
            this.COLOUR_COL.ReadOnly = true;
            // 
            // INSURANCE_NO_COL
            // 
            this.INSURANCE_NO_COL.HeaderText = "Insurance No.";
            this.INSURANCE_NO_COL.MinimumWidth = 6;
            this.INSURANCE_NO_COL.Name = "INSURANCE_NO_COL";
            this.INSURANCE_NO_COL.ReadOnly = true;
            // 
            // ODOMETER_NO_COL
            // 
            this.ODOMETER_NO_COL.HeaderText = "Odometer No.";
            this.ODOMETER_NO_COL.MinimumWidth = 6;
            this.ODOMETER_NO_COL.Name = "ODOMETER_NO_COL";
            this.ODOMETER_NO_COL.ReadOnly = true;
            // 
            // BRANCH_ID_COL
            // 
            this.BRANCH_ID_COL.HeaderText = "Branch ID";
            this.BRANCH_ID_COL.MinimumWidth = 6;
            this.BRANCH_ID_COL.Name = "BRANCH_ID_COL";
            // 
            // CAR_TYPE_ID_COL
            // 
            this.CAR_TYPE_ID_COL.HeaderText = "Car Type ID";
            this.CAR_TYPE_ID_COL.MinimumWidth = 6;
            this.CAR_TYPE_ID_COL.Name = "CAR_TYPE_ID_COL";
            // 
            // cars_odometer_no_txt
            // 
            this.cars_odometer_no_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_odometer_no_txt.Location = new System.Drawing.Point(172, 388);
            this.cars_odometer_no_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_odometer_no_txt.Name = "cars_odometer_no_txt";
            this.cars_odometer_no_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_odometer_no_txt.TabIndex = 16;
            // 
            // cars_no_seats_txt
            // 
            this.cars_no_seats_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_no_seats_txt.Location = new System.Drawing.Point(172, 240);
            this.cars_no_seats_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_no_seats_txt.Name = "cars_no_seats_txt";
            this.cars_no_seats_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_no_seats_txt.TabIndex = 15;
            // 
            // cars_colour_txt
            // 
            this.cars_colour_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_colour_txt.Location = new System.Drawing.Point(172, 289);
            this.cars_colour_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_colour_txt.Name = "cars_colour_txt";
            this.cars_colour_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_colour_txt.TabIndex = 14;
            // 
            // cars_insurance_no_txt
            // 
            this.cars_insurance_no_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_insurance_no_txt.Location = new System.Drawing.Point(172, 338);
            this.cars_insurance_no_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_insurance_no_txt.Name = "cars_insurance_no_txt";
            this.cars_insurance_no_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_insurance_no_txt.TabIndex = 13;
            // 
            // cars_year_txt
            // 
            this.cars_year_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_year_txt.Location = new System.Drawing.Point(172, 191);
            this.cars_year_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_year_txt.Name = "cars_year_txt";
            this.cars_year_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_year_txt.TabIndex = 12;
            // 
            // cars_model_txt
            // 
            this.cars_model_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_model_txt.Location = new System.Drawing.Point(172, 142);
            this.cars_model_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cars_model_txt.Name = "cars_model_txt";
            this.cars_model_txt.Size = new System.Drawing.Size(160, 26);
            this.cars_model_txt.TabIndex = 11;
            // 
            // cars_odometer_label
            // 
            this.cars_odometer_label.AutoSize = true;
            this.cars_odometer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_odometer_label.Location = new System.Drawing.Point(21, 391);
            this.cars_odometer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_odometer_label.Name = "cars_odometer_label";
            this.cars_odometer_label.Size = new System.Drawing.Size(113, 20);
            this.cars_odometer_label.TabIndex = 10;
            this.cars_odometer_label.Text = "Odometer No.";
            this.cars_odometer_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // cars_no_seats_label
            // 
            this.cars_no_seats_label.AutoSize = true;
            this.cars_no_seats_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_no_seats_label.Location = new System.Drawing.Point(21, 244);
            this.cars_no_seats_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_no_seats_label.Name = "cars_no_seats_label";
            this.cars_no_seats_label.Size = new System.Drawing.Size(101, 20);
            this.cars_no_seats_label.TabIndex = 9;
            this.cars_no_seats_label.Text = "No. of Seats";
            // 
            // cars_colour_label
            // 
            this.cars_colour_label.AutoSize = true;
            this.cars_colour_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_colour_label.Location = new System.Drawing.Point(21, 293);
            this.cars_colour_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_colour_label.Name = "cars_colour_label";
            this.cars_colour_label.Size = new System.Drawing.Size(58, 20);
            this.cars_colour_label.TabIndex = 8;
            this.cars_colour_label.Text = "Colour";
            // 
            // cars_insurance_no_label
            // 
            this.cars_insurance_no_label.AutoSize = true;
            this.cars_insurance_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_insurance_no_label.Location = new System.Drawing.Point(21, 342);
            this.cars_insurance_no_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_insurance_no_label.Name = "cars_insurance_no_label";
            this.cars_insurance_no_label.Size = new System.Drawing.Size(112, 20);
            this.cars_insurance_no_label.TabIndex = 7;
            this.cars_insurance_no_label.Text = "Insurance No.";
            // 
            // cars_year_label
            // 
            this.cars_year_label.AutoSize = true;
            this.cars_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_year_label.Location = new System.Drawing.Point(21, 194);
            this.cars_year_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_year_label.Name = "cars_year_label";
            this.cars_year_label.Size = new System.Drawing.Size(43, 20);
            this.cars_year_label.TabIndex = 6;
            this.cars_year_label.Text = "Year";
            // 
            // cars_model_label
            // 
            this.cars_model_label.AutoSize = true;
            this.cars_model_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_model_label.Location = new System.Drawing.Point(21, 145);
            this.cars_model_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_model_label.Name = "cars_model_label";
            this.cars_model_label.Size = new System.Drawing.Size(54, 20);
            this.cars_model_label.TabIndex = 5;
            this.cars_model_label.Text = "Model";
            this.cars_model_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cars_vin_label
            // 
            this.cars_vin_label.AutoSize = true;
            this.cars_vin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_vin_label.Location = new System.Drawing.Point(21, 47);
            this.cars_vin_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_vin_label.Name = "cars_vin_label";
            this.cars_vin_label.Size = new System.Drawing.Size(36, 20);
            this.cars_vin_label.TabIndex = 4;
            this.cars_vin_label.Text = "VIN";
            this.cars_vin_label.Click += new System.EventHandler(this.vin_Click);
            // 
            // cars_branch_id_dropdown
            // 
            this.cars_branch_id_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_branch_id_dropdown.FormattingEnabled = true;
            this.cars_branch_id_dropdown.Location = new System.Drawing.Point(172, 437);
            this.cars_branch_id_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.cars_branch_id_dropdown.Name = "cars_branch_id_dropdown";
            this.cars_branch_id_dropdown.Size = new System.Drawing.Size(160, 28);
            this.cars_branch_id_dropdown.TabIndex = 3;
            this.cars_branch_id_dropdown.Tag = "carTypeOptions";
            this.cars_branch_id_dropdown.SelectedIndexChanged += new System.EventHandler(this.cars_branch_id_dropdown_SelectedIndexChanged);
            // 
            // cars_vin_text
            // 
            this.cars_vin_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_vin_text.Location = new System.Drawing.Point(172, 43);
            this.cars_vin_text.Margin = new System.Windows.Forms.Padding(4);
            this.cars_vin_text.Name = "cars_vin_text";
            this.cars_vin_text.Size = new System.Drawing.Size(160, 26);
            this.cars_vin_text.TabIndex = 2;
            // 
            // cars_branch_id_label
            // 
            this.cars_branch_id_label.AutoSize = true;
            this.cars_branch_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_branch_id_label.Location = new System.Drawing.Point(21, 441);
            this.cars_branch_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cars_branch_id_label.Name = "cars_branch_id_label";
            this.cars_branch_id_label.Size = new System.Drawing.Size(85, 20);
            this.cars_branch_id_label.TabIndex = 1;
            this.cars_branch_id_label.Text = "Branch ID";
            this.cars_branch_id_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // carTypeTab
            // 
            this.carTypeTab.Controls.Add(this.label4);
            this.carTypeTab.Controls.Add(this.label3);
            this.carTypeTab.Controls.Add(this.label2);
            this.carTypeTab.Controls.Add(this.mCostS2);
            this.carTypeTab.Controls.Add(this.mCostS1);
            this.carTypeTab.Controls.Add(this.wCostS2);
            this.carTypeTab.Controls.Add(this.wCostS1);
            this.carTypeTab.Controls.Add(this.dCostS2);
            this.carTypeTab.Controls.Add(this.dCostS1);
            this.carTypeTab.Controls.Add(this.descS);
            this.carTypeTab.Controls.Add(this.editTypeBut);
            this.carTypeTab.Controls.Add(this.delTypeBut);
            this.carTypeTab.Controls.Add(this.DailyRentLabel);
            this.carTypeTab.Controls.Add(this.WeeklyRentLabel);
            this.carTypeTab.Controls.Add(this.MonthlyRentLabel);
            this.carTypeTab.Controls.Add(this.mRent);
            this.carTypeTab.Controls.Add(this.wRent);
            this.carTypeTab.Controls.Add(this.modelS);
            this.carTypeTab.Controls.Add(this.dRent);
            this.carTypeTab.Controls.Add(this.typeDesc);
            this.carTypeTab.Controls.Add(this.modelID);
            this.carTypeTab.Controls.Add(this.rentalCostSLabel);
            this.carTypeTab.Controls.Add(this.typeSDescLabel);
            this.carTypeTab.Controls.Add(this.modelSLabel);
            this.carTypeTab.Controls.Add(this.rentalCostLabel);
            this.carTypeTab.Controls.Add(this.typeDescLabel);
            this.carTypeTab.Controls.Add(this.ModelLabel);
            this.carTypeTab.Controls.Add(this.typeSBut);
            this.carTypeTab.Controls.Add(this.addTypeBut);
            this.carTypeTab.Controls.Add(this.carTypeView);
            this.carTypeTab.Location = new System.Drawing.Point(4, 25);
            this.carTypeTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carTypeTab.Name = "carTypeTab";
            this.carTypeTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carTypeTab.Size = new System.Drawing.Size(1836, 724);
            this.carTypeTab.TabIndex = 1;
            this.carTypeTab.Text = "Car Type";
            this.carTypeTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 574);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Monthly Rental Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 574);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Weekly Rental Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 574);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Daily Rental Cost";
            // 
            // mCostS2
            // 
            this.mCostS2.Location = new System.Drawing.Point(489, 665);
            this.mCostS2.Margin = new System.Windows.Forms.Padding(4);
            this.mCostS2.Name = "mCostS2";
            this.mCostS2.Size = new System.Drawing.Size(132, 22);
            this.mCostS2.TabIndex = 29;
            // 
            // mCostS1
            // 
            this.mCostS1.Location = new System.Drawing.Point(489, 610);
            this.mCostS1.Margin = new System.Windows.Forms.Padding(4);
            this.mCostS1.Name = "mCostS1";
            this.mCostS1.Size = new System.Drawing.Size(132, 22);
            this.mCostS1.TabIndex = 28;
            // 
            // wCostS2
            // 
            this.wCostS2.Location = new System.Drawing.Point(268, 665);
            this.wCostS2.Margin = new System.Windows.Forms.Padding(4);
            this.wCostS2.Name = "wCostS2";
            this.wCostS2.Size = new System.Drawing.Size(132, 22);
            this.wCostS2.TabIndex = 27;
            // 
            // wCostS1
            // 
            this.wCostS1.Location = new System.Drawing.Point(268, 610);
            this.wCostS1.Margin = new System.Windows.Forms.Padding(4);
            this.wCostS1.Name = "wCostS1";
            this.wCostS1.Size = new System.Drawing.Size(132, 22);
            this.wCostS1.TabIndex = 26;
            // 
            // dCostS2
            // 
            this.dCostS2.Location = new System.Drawing.Point(43, 665);
            this.dCostS2.Margin = new System.Windows.Forms.Padding(4);
            this.dCostS2.Name = "dCostS2";
            this.dCostS2.Size = new System.Drawing.Size(132, 22);
            this.dCostS2.TabIndex = 25;
            // 
            // dCostS1
            // 
            this.dCostS1.Location = new System.Drawing.Point(43, 610);
            this.dCostS1.Margin = new System.Windows.Forms.Padding(4);
            this.dCostS1.Name = "dCostS1";
            this.dCostS1.Size = new System.Drawing.Size(132, 22);
            this.dCostS1.TabIndex = 24;
            // 
            // descS
            // 
            this.descS.Location = new System.Drawing.Point(257, 481);
            this.descS.Margin = new System.Windows.Forms.Padding(4);
            this.descS.Name = "descS";
            this.descS.Size = new System.Drawing.Size(132, 22);
            this.descS.TabIndex = 23;
            // 
            // editTypeBut
            // 
            this.editTypeBut.Location = new System.Drawing.Point(508, 335);
            this.editTypeBut.Margin = new System.Windows.Forms.Padding(4);
            this.editTypeBut.Name = "editTypeBut";
            this.editTypeBut.Size = new System.Drawing.Size(117, 28);
            this.editTypeBut.TabIndex = 22;
            this.editTypeBut.Text = "Edit Car Type";
            this.editTypeBut.UseVisualStyleBackColor = true;
            this.editTypeBut.Click += new System.EventHandler(this.editCarTypeButClick);
            // 
            // delTypeBut
            // 
            this.delTypeBut.Location = new System.Drawing.Point(268, 335);
            this.delTypeBut.Margin = new System.Windows.Forms.Padding(4);
            this.delTypeBut.Name = "delTypeBut";
            this.delTypeBut.Size = new System.Drawing.Size(133, 28);
            this.delTypeBut.TabIndex = 21;
            this.delTypeBut.Text = "Delete Car Type";
            this.delTypeBut.UseVisualStyleBackColor = true;
            this.delTypeBut.Click += new System.EventHandler(this.delCarTypeButClick);
            // 
            // DailyRentLabel
            // 
            this.DailyRentLabel.AutoSize = true;
            this.DailyRentLabel.Location = new System.Drawing.Point(63, 185);
            this.DailyRentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DailyRentLabel.Name = "DailyRentLabel";
            this.DailyRentLabel.Size = new System.Drawing.Size(110, 16);
            this.DailyRentLabel.TabIndex = 19;
            this.DailyRentLabel.Text = "Daily Rental Cost";
            // 
            // WeeklyRentLabel
            // 
            this.WeeklyRentLabel.AutoSize = true;
            this.WeeklyRentLabel.Location = new System.Drawing.Point(267, 185);
            this.WeeklyRentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeeklyRentLabel.Name = "WeeklyRentLabel";
            this.WeeklyRentLabel.Size = new System.Drawing.Size(125, 16);
            this.WeeklyRentLabel.TabIndex = 18;
            this.WeeklyRentLabel.Text = "Weekly Rental Cost";
            // 
            // MonthlyRentLabel
            // 
            this.MonthlyRentLabel.AutoSize = true;
            this.MonthlyRentLabel.Location = new System.Drawing.Point(489, 185);
            this.MonthlyRentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthlyRentLabel.Name = "MonthlyRentLabel";
            this.MonthlyRentLabel.Size = new System.Drawing.Size(125, 16);
            this.MonthlyRentLabel.TabIndex = 17;
            this.MonthlyRentLabel.Text = "Monthly Rental Cost";
            // 
            // mRent
            // 
            this.mRent.Location = new System.Drawing.Point(493, 239);
            this.mRent.Margin = new System.Windows.Forms.Padding(4);
            this.mRent.Name = "mRent";
            this.mRent.Size = new System.Drawing.Size(132, 22);
            this.mRent.TabIndex = 16;
            // 
            // wRent
            // 
            this.wRent.Location = new System.Drawing.Point(268, 239);
            this.wRent.Margin = new System.Windows.Forms.Padding(4);
            this.wRent.Name = "wRent";
            this.wRent.Size = new System.Drawing.Size(132, 22);
            this.wRent.TabIndex = 15;
            // 
            // modelS
            // 
            this.modelS.Location = new System.Drawing.Point(43, 481);
            this.modelS.Margin = new System.Windows.Forms.Padding(4);
            this.modelS.Name = "modelS";
            this.modelS.Size = new System.Drawing.Size(132, 22);
            this.modelS.TabIndex = 14;
            // 
            // dRent
            // 
            this.dRent.Location = new System.Drawing.Point(43, 239);
            this.dRent.Margin = new System.Windows.Forms.Padding(4);
            this.dRent.Name = "dRent";
            this.dRent.Size = new System.Drawing.Size(132, 22);
            this.dRent.TabIndex = 13;
            // 
            // typeDesc
            // 
            this.typeDesc.Location = new System.Drawing.Point(399, 58);
            this.typeDesc.Margin = new System.Windows.Forms.Padding(4);
            this.typeDesc.Name = "typeDesc";
            this.typeDesc.Size = new System.Drawing.Size(132, 22);
            this.typeDesc.TabIndex = 12;
            // 
            // modelID
            // 
            this.modelID.Location = new System.Drawing.Point(125, 58);
            this.modelID.Margin = new System.Windows.Forms.Padding(4);
            this.modelID.Name = "modelID";
            this.modelID.Size = new System.Drawing.Size(132, 22);
            this.modelID.TabIndex = 11;
            // 
            // rentalCostSLabel
            // 
            this.rentalCostSLabel.AutoSize = true;
            this.rentalCostSLabel.Location = new System.Drawing.Point(288, 539);
            this.rentalCostSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentalCostSLabel.Name = "rentalCostSLabel";
            this.rentalCostSLabel.Size = new System.Drawing.Size(86, 16);
            this.rentalCostSLabel.TabIndex = 8;
            this.rentalCostSLabel.Text = "Rental Costs:";
            // 
            // typeSDescLabel
            // 
            this.typeSDescLabel.AutoSize = true;
            this.typeSDescLabel.Location = new System.Drawing.Point(291, 427);
            this.typeSDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeSDescLabel.Name = "typeSDescLabel";
            this.typeSDescLabel.Size = new System.Drawing.Size(75, 16);
            this.typeSDescLabel.TabIndex = 7;
            this.typeSDescLabel.Text = "Description";
            this.typeSDescLabel.Click += new System.EventHandler(this.rentalClassSLabel_Click);
            // 
            // modelSLabel
            // 
            this.modelSLabel.AutoSize = true;
            this.modelSLabel.Location = new System.Drawing.Point(63, 427);
            this.modelSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modelSLabel.Name = "modelSLabel";
            this.modelSLabel.Size = new System.Drawing.Size(61, 16);
            this.modelSLabel.TabIndex = 6;
            this.modelSLabel.Text = "Model ID";
            // 
            // rentalCostLabel
            // 
            this.rentalCostLabel.AutoSize = true;
            this.rentalCostLabel.Location = new System.Drawing.Point(291, 137);
            this.rentalCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentalCostLabel.Name = "rentalCostLabel";
            this.rentalCostLabel.Size = new System.Drawing.Size(86, 16);
            this.rentalCostLabel.TabIndex = 5;
            this.rentalCostLabel.Text = "Rental Costs:";
            // 
            // typeDescLabel
            // 
            this.typeDescLabel.AutoSize = true;
            this.typeDescLabel.Location = new System.Drawing.Point(423, 21);
            this.typeDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeDescLabel.Name = "typeDescLabel";
            this.typeDescLabel.Size = new System.Drawing.Size(75, 16);
            this.typeDescLabel.TabIndex = 4;
            this.typeDescLabel.Text = "Description";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(155, 21);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(61, 16);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model ID";
            this.ModelLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // typeSBut
            // 
            this.typeSBut.Location = new System.Drawing.Point(657, 629);
            this.typeSBut.Margin = new System.Windows.Forms.Padding(4);
            this.typeSBut.Name = "typeSBut";
            this.typeSBut.Size = new System.Drawing.Size(127, 28);
            this.typeSBut.TabIndex = 2;
            this.typeSBut.Text = "Search Car Type";
            this.typeSBut.UseVisualStyleBackColor = true;
            this.typeSBut.Click += new System.EventHandler(this.searchCarTypeButClick);
            // 
            // addTypeBut
            // 
            this.addTypeBut.Location = new System.Drawing.Point(43, 335);
            this.addTypeBut.Margin = new System.Windows.Forms.Padding(4);
            this.addTypeBut.Name = "addTypeBut";
            this.addTypeBut.Size = new System.Drawing.Size(112, 28);
            this.addTypeBut.TabIndex = 1;
            this.addTypeBut.Text = "Add Car Type";
            this.addTypeBut.UseVisualStyleBackColor = true;
            this.addTypeBut.Click += new System.EventHandler(this.addCarTypeButClick);
            // 
            // carTypeView
            // 
            this.carTypeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carTypeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MODEL_ID_COL,
            this.RENTAL_CLASS_COL,
            this.DAILY_RENTAL_COST_COL,
            this.WEEKLY_RENTAL_COST_COL,
            this.MONTHLY_RENTAL_COST_COL});
            this.carTypeView.Location = new System.Drawing.Point(792, 42);
            this.carTypeView.Margin = new System.Windows.Forms.Padding(4);
            this.carTypeView.Name = "carTypeView";
            this.carTypeView.RowHeadersWidth = 51;
            this.carTypeView.Size = new System.Drawing.Size(905, 673);
            this.carTypeView.TabIndex = 0;
            this.carTypeView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // MODEL_ID_COL
            // 
            this.MODEL_ID_COL.HeaderText = "Model ID";
            this.MODEL_ID_COL.MinimumWidth = 6;
            this.MODEL_ID_COL.Name = "MODEL_ID_COL";
            this.MODEL_ID_COL.ReadOnly = true;
            this.MODEL_ID_COL.Width = 125;
            // 
            // RENTAL_CLASS_COL
            // 
            this.RENTAL_CLASS_COL.HeaderText = "Rental Class";
            this.RENTAL_CLASS_COL.MinimumWidth = 6;
            this.RENTAL_CLASS_COL.Name = "RENTAL_CLASS_COL";
            this.RENTAL_CLASS_COL.ReadOnly = true;
            this.RENTAL_CLASS_COL.Width = 125;
            // 
            // DAILY_RENTAL_COST_COL
            // 
            this.DAILY_RENTAL_COST_COL.HeaderText = "Daily Rental Cost";
            this.DAILY_RENTAL_COST_COL.MinimumWidth = 6;
            this.DAILY_RENTAL_COST_COL.Name = "DAILY_RENTAL_COST_COL";
            this.DAILY_RENTAL_COST_COL.ReadOnly = true;
            this.DAILY_RENTAL_COST_COL.Width = 125;
            // 
            // WEEKLY_RENTAL_COST_COL
            // 
            this.WEEKLY_RENTAL_COST_COL.HeaderText = "Weekly Rental Cost";
            this.WEEKLY_RENTAL_COST_COL.MinimumWidth = 6;
            this.WEEKLY_RENTAL_COST_COL.Name = "WEEKLY_RENTAL_COST_COL";
            this.WEEKLY_RENTAL_COST_COL.ReadOnly = true;
            this.WEEKLY_RENTAL_COST_COL.Width = 125;
            // 
            // MONTHLY_RENTAL_COST_COL
            // 
            this.MONTHLY_RENTAL_COST_COL.HeaderText = "Monthly Rental Cost";
            this.MONTHLY_RENTAL_COST_COL.MinimumWidth = 6;
            this.MONTHLY_RENTAL_COST_COL.Name = "MONTHLY_RENTAL_COST_COL";
            this.MONTHLY_RENTAL_COST_COL.ReadOnly = true;
            this.MONTHLY_RENTAL_COST_COL.Width = 125;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.branch_search_text_box);
            this.tabPage1.Controls.Add(this.branch_search_box);
            this.tabPage1.Controls.Add(this.branch_search_label);
            this.tabPage1.Controls.Add(this.branch_edit_but);
            this.tabPage1.Controls.Add(this.branch_refresh_but);
            this.tabPage1.Controls.Add(this.branch_id_LU_label);
            this.tabPage1.Controls.Add(this.branch_id_LU_txt);
            this.tabPage1.Controls.Add(this.branch_search_but);
            this.tabPage1.Controls.Add(this.branch_del_but);
            this.tabPage1.Controls.Add(this.branch_add_but);
            this.tabPage1.Controls.Add(this.branch_view);
            this.tabPage1.Controls.Add(this.branch_id_txt);
            this.tabPage1.Controls.Add(this.branch_phone_num_txt);
            this.tabPage1.Controls.Add(this.branch_pCode_txt);
            this.tabPage1.Controls.Add(this.branch_province_txt);
            this.tabPage1.Controls.Add(this.branch_city_txt);
            this.tabPage1.Controls.Add(this.branch_street_add2_txt);
            this.tabPage1.Controls.Add(this.branch_street_add1_txt);
            this.tabPage1.Controls.Add(this.branch_descrip_txt);
            this.tabPage1.Controls.Add(this.branch_phone_num_label);
            this.tabPage1.Controls.Add(this.branch_pCode_label);
            this.tabPage1.Controls.Add(this.branch_province_label);
            this.tabPage1.Controls.Add(this.branch_city_label);
            this.tabPage1.Controls.Add(this.branch_street_add2_label);
            this.tabPage1.Controls.Add(this.branch_street_add1_label);
            this.tabPage1.Controls.Add(this.branch_dscrip_label);
            this.tabPage1.Controls.Add(this.branch_id_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1836, 724);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Branches";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // branch_search_text_box
            // 
            this.branch_search_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_text_box.Location = new System.Drawing.Point(869, 590);
            this.branch_search_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.branch_search_text_box.Name = "branch_search_text_box";
            this.branch_search_text_box.Size = new System.Drawing.Size(167, 26);
            this.branch_search_text_box.TabIndex = 26;
            // 
            // branch_search_box
            // 
            this.branch_search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_box.FormattingEnabled = true;
            this.branch_search_box.Items.AddRange(new object[] {
            "Branch ID",
            "Description",
            "Street Address 1",
            "Street Address 2",
            "City",
            "Province",
            "Postal Code",
            "Phone Number"});
            this.branch_search_box.Location = new System.Drawing.Point(613, 590);
            this.branch_search_box.Margin = new System.Windows.Forms.Padding(4);
            this.branch_search_box.Name = "branch_search_box";
            this.branch_search_box.Size = new System.Drawing.Size(228, 28);
            this.branch_search_box.TabIndex = 25;
            this.branch_search_box.Text = "--- Select ---";
            this.branch_search_box.SelectedIndexChanged += new System.EventHandler(this.branch_search_box_SelectedIndexChanged);
            // 
            // branch_search_label
            // 
            this.branch_search_label.AutoSize = true;
            this.branch_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_label.Location = new System.Drawing.Point(509, 593);
            this.branch_search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_search_label.Name = "branch_search_label";
            this.branch_search_label.Size = new System.Drawing.Size(89, 20);
            this.branch_search_label.TabIndex = 24;
            this.branch_search_label.Text = "Search by:";
            // 
            // branch_edit_but
            // 
            this.branch_edit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_edit_but.Location = new System.Drawing.Point(255, 567);
            this.branch_edit_but.Margin = new System.Windows.Forms.Padding(4);
            this.branch_edit_but.Name = "branch_edit_but";
            this.branch_edit_but.Size = new System.Drawing.Size(127, 76);
            this.branch_edit_but.TabIndex = 23;
            this.branch_edit_but.Text = "Edit";
            this.branch_edit_but.UseVisualStyleBackColor = true;
            this.branch_edit_but.Click += new System.EventHandler(this.branch_edit_but_Click);
            // 
            // branch_refresh_but
            // 
            this.branch_refresh_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_refresh_but.Location = new System.Drawing.Point(1580, 610);
            this.branch_refresh_but.Margin = new System.Windows.Forms.Padding(4);
            this.branch_refresh_but.Name = "branch_refresh_but";
            this.branch_refresh_but.Size = new System.Drawing.Size(128, 73);
            this.branch_refresh_but.TabIndex = 22;
            this.branch_refresh_but.Text = "Refresh";
            this.branch_refresh_but.UseVisualStyleBackColor = true;
            this.branch_refresh_but.Click += new System.EventHandler(this.branch_refresh_but_Click);
            // 
            // branch_id_LU_label
            // 
            this.branch_id_LU_label.AutoSize = true;
            this.branch_id_LU_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_LU_label.Location = new System.Drawing.Point(1131, 597);
            this.branch_id_LU_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_id_LU_label.Name = "branch_id_LU_label";
            this.branch_id_LU_label.Size = new System.Drawing.Size(163, 20);
            this.branch_id_LU_label.TabIndex = 21;
            this.branch_id_LU_label.Text = "Branch ID to Delete:";
            this.branch_id_LU_label.Click += new System.EventHandler(this.label9_Click);
            // 
            // branch_id_LU_txt
            // 
            this.branch_id_LU_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_LU_txt.Location = new System.Drawing.Point(1305, 593);
            this.branch_id_LU_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_id_LU_txt.Name = "branch_id_LU_txt";
            this.branch_id_LU_txt.Size = new System.Drawing.Size(132, 26);
            this.branch_id_LU_txt.TabIndex = 20;
            // 
            // branch_search_but
            // 
            this.branch_search_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_but.Location = new System.Drawing.Point(892, 631);
            this.branch_search_but.Margin = new System.Windows.Forms.Padding(4);
            this.branch_search_but.Name = "branch_search_but";
            this.branch_search_but.Size = new System.Drawing.Size(128, 69);
            this.branch_search_but.TabIndex = 19;
            this.branch_search_but.Text = "Search";
            this.branch_search_but.UseVisualStyleBackColor = true;
            this.branch_search_but.Click += new System.EventHandler(this.branch_search_but_Click);
            // 
            // branch_del_but
            // 
            this.branch_del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_del_but.Location = new System.Drawing.Point(1305, 628);
            this.branch_del_but.Margin = new System.Windows.Forms.Padding(4);
            this.branch_del_but.Name = "branch_del_but";
            this.branch_del_but.Size = new System.Drawing.Size(131, 73);
            this.branch_del_but.TabIndex = 18;
            this.branch_del_but.Text = "Delete";
            this.branch_del_but.UseVisualStyleBackColor = true;
            this.branch_del_but.Click += new System.EventHandler(this.branch_del_but_Click);
            // 
            // branch_add_but
            // 
            this.branch_add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_add_but.Location = new System.Drawing.Point(51, 569);
            this.branch_add_but.Margin = new System.Windows.Forms.Padding(4);
            this.branch_add_but.Name = "branch_add_but";
            this.branch_add_but.Size = new System.Drawing.Size(127, 76);
            this.branch_add_but.TabIndex = 17;
            this.branch_add_but.Text = "Add";
            this.branch_add_but.UseVisualStyleBackColor = true;
            this.branch_add_but.Click += new System.EventHandler(this.branch_add_but_Click);
            // 
            // branch_view
            // 
            this.branch_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branch_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.branch_view.Location = new System.Drawing.Point(411, 27);
            this.branch_view.Margin = new System.Windows.Forms.Padding(4);
            this.branch_view.Name = "branch_view";
            this.branch_view.RowHeadersWidth = 51;
            this.branch_view.Size = new System.Drawing.Size(1352, 500);
            this.branch_view.TabIndex = 16;
            this.branch_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branch_view_CellContentClick);
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Branch ID";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Description";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Street Address 1";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.Width = 125;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Street Address 2";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            this.Column18.Width = 125;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "City";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            this.Column19.Width = 125;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Province";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.Width = 125;
            // 
            // Column21
            // 
            this.Column21.HeaderText = "Postal Code";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            this.Column21.Width = 125;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Phone Number";
            this.Column22.MinimumWidth = 6;
            this.Column22.Name = "Column22";
            this.Column22.Width = 125;
            // 
            // branch_id_txt
            // 
            this.branch_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_txt.Location = new System.Drawing.Point(200, 41);
            this.branch_id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_id_txt.Name = "branch_id_txt";
            this.branch_id_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_id_txt.TabIndex = 15;
            // 
            // branch_phone_num_txt
            // 
            this.branch_phone_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_phone_num_txt.Location = new System.Drawing.Point(200, 498);
            this.branch_phone_num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_phone_num_txt.Name = "branch_phone_num_txt";
            this.branch_phone_num_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_phone_num_txt.TabIndex = 14;
            // 
            // branch_pCode_txt
            // 
            this.branch_pCode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_pCode_txt.Location = new System.Drawing.Point(200, 423);
            this.branch_pCode_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_pCode_txt.Name = "branch_pCode_txt";
            this.branch_pCode_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_pCode_txt.TabIndex = 13;
            // 
            // branch_province_txt
            // 
            this.branch_province_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_province_txt.Location = new System.Drawing.Point(200, 354);
            this.branch_province_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_province_txt.Name = "branch_province_txt";
            this.branch_province_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_province_txt.TabIndex = 12;
            // 
            // branch_city_txt
            // 
            this.branch_city_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_city_txt.Location = new System.Drawing.Point(200, 284);
            this.branch_city_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_city_txt.Name = "branch_city_txt";
            this.branch_city_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_city_txt.TabIndex = 11;
            // 
            // branch_street_add2_txt
            // 
            this.branch_street_add2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add2_txt.Location = new System.Drawing.Point(200, 218);
            this.branch_street_add2_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_street_add2_txt.Name = "branch_street_add2_txt";
            this.branch_street_add2_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_street_add2_txt.TabIndex = 10;
            // 
            // branch_street_add1_txt
            // 
            this.branch_street_add1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add1_txt.Location = new System.Drawing.Point(200, 153);
            this.branch_street_add1_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_street_add1_txt.Name = "branch_street_add1_txt";
            this.branch_street_add1_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_street_add1_txt.TabIndex = 9;
            // 
            // branch_descrip_txt
            // 
            this.branch_descrip_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_descrip_txt.Location = new System.Drawing.Point(200, 90);
            this.branch_descrip_txt.Margin = new System.Windows.Forms.Padding(4);
            this.branch_descrip_txt.Name = "branch_descrip_txt";
            this.branch_descrip_txt.Size = new System.Drawing.Size(201, 27);
            this.branch_descrip_txt.TabIndex = 8;
            // 
            // branch_phone_num_label
            // 
            this.branch_phone_num_label.AutoSize = true;
            this.branch_phone_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_phone_num_label.Location = new System.Drawing.Point(40, 498);
            this.branch_phone_num_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_phone_num_label.Name = "branch_phone_num_label";
            this.branch_phone_num_label.Size = new System.Drawing.Size(120, 20);
            this.branch_phone_num_label.TabIndex = 7;
            this.branch_phone_num_label.Text = "Phone Number";
            // 
            // branch_pCode_label
            // 
            this.branch_pCode_label.AutoSize = true;
            this.branch_pCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_pCode_label.Location = new System.Drawing.Point(40, 423);
            this.branch_pCode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_pCode_label.Name = "branch_pCode_label";
            this.branch_pCode_label.Size = new System.Drawing.Size(100, 20);
            this.branch_pCode_label.TabIndex = 6;
            this.branch_pCode_label.Text = "Postal Code";
            // 
            // branch_province_label
            // 
            this.branch_province_label.AutoSize = true;
            this.branch_province_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_province_label.Location = new System.Drawing.Point(40, 354);
            this.branch_province_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_province_label.Name = "branch_province_label";
            this.branch_province_label.Size = new System.Drawing.Size(74, 20);
            this.branch_province_label.TabIndex = 5;
            this.branch_province_label.Text = "Province";
            // 
            // branch_city_label
            // 
            this.branch_city_label.AutoSize = true;
            this.branch_city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_city_label.Location = new System.Drawing.Point(40, 284);
            this.branch_city_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_city_label.Name = "branch_city_label";
            this.branch_city_label.Size = new System.Drawing.Size(38, 20);
            this.branch_city_label.TabIndex = 4;
            this.branch_city_label.Text = "City";
            // 
            // branch_street_add2_label
            // 
            this.branch_street_add2_label.AutoSize = true;
            this.branch_street_add2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add2_label.Location = new System.Drawing.Point(40, 218);
            this.branch_street_add2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_street_add2_label.Name = "branch_street_add2_label";
            this.branch_street_add2_label.Size = new System.Drawing.Size(135, 20);
            this.branch_street_add2_label.TabIndex = 3;
            this.branch_street_add2_label.Text = "Street Address 2";
            // 
            // branch_street_add1_label
            // 
            this.branch_street_add1_label.AutoSize = true;
            this.branch_street_add1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add1_label.Location = new System.Drawing.Point(40, 153);
            this.branch_street_add1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_street_add1_label.Name = "branch_street_add1_label";
            this.branch_street_add1_label.Size = new System.Drawing.Size(126, 20);
            this.branch_street_add1_label.TabIndex = 2;
            this.branch_street_add1_label.Text = "Street Addres 1";
            // 
            // branch_dscrip_label
            // 
            this.branch_dscrip_label.AutoSize = true;
            this.branch_dscrip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_dscrip_label.Location = new System.Drawing.Point(40, 90);
            this.branch_dscrip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_dscrip_label.Name = "branch_dscrip_label";
            this.branch_dscrip_label.Size = new System.Drawing.Size(95, 20);
            this.branch_dscrip_label.TabIndex = 1;
            this.branch_dscrip_label.Text = "Description";
            // 
            // branch_id_label
            // 
            this.branch_id_label.AutoSize = true;
            this.branch_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_label.Location = new System.Drawing.Point(40, 41);
            this.branch_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.branch_id_label.Name = "branch_id_label";
            this.branch_id_label.Size = new System.Drawing.Size(85, 20);
            this.branch_id_label.TabIndex = 0;
            this.branch_id_label.Text = "Branch ID";
            this.branch_id_label.Click += new System.EventHandler(this.branch_id_label_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cust_del_but);
            this.tabPage3.Controls.Add(this.cust_box_search);
            this.tabPage3.Controls.Add(this.cust_id_search_label);
            this.tabPage3.Controls.Add(this.cust_id_LU_txt);
            this.tabPage3.Controls.Add(this.cust_search_box_txt);
            this.tabPage3.Controls.Add(this.cust_search_box);
            this.tabPage3.Controls.Add(this.cust_search_but);
            this.tabPage3.Controls.Add(this.cust_refresh_but);
            this.tabPage3.Controls.Add(this.cust_edit_but);
            this.tabPage3.Controls.Add(this.customer_view);
            this.tabPage3.Controls.Add(this.cust_add_but);
            this.tabPage3.Controls.Add(this.cust_drivers_txt);
            this.tabPage3.Controls.Add(this.cust_insurance_txt);
            this.tabPage3.Controls.Add(this.cust_phone_num_txt);
            this.tabPage3.Controls.Add(this.cust_dob_txt);
            this.tabPage3.Controls.Add(this.cust_pCode_txt);
            this.tabPage3.Controls.Add(this.cust_prov_txt);
            this.tabPage3.Controls.Add(this.cust_city_txt);
            this.tabPage3.Controls.Add(this.cust_street_add2_txt);
            this.tabPage3.Controls.Add(this.cust_street_add1_txt);
            this.tabPage3.Controls.Add(this.cust_last_name_txt);
            this.tabPage3.Controls.Add(this.cust_mid_name_txt);
            this.tabPage3.Controls.Add(this.cust_first_name_txt);
            this.tabPage3.Controls.Add(this.cust_custID_txt);
            this.tabPage3.Controls.Add(this.cust_drivers_label);
            this.tabPage3.Controls.Add(this.cust_insurance_label);
            this.tabPage3.Controls.Add(this.cust_phone_num_label);
            this.tabPage3.Controls.Add(this.cust_dob_label);
            this.tabPage3.Controls.Add(this.cust_pCode_label);
            this.tabPage3.Controls.Add(this.cust_province_label);
            this.tabPage3.Controls.Add(this.cust_city_label);
            this.tabPage3.Controls.Add(this.cust_street_add2_label);
            this.tabPage3.Controls.Add(this.cust_street_add1_label);
            this.tabPage3.Controls.Add(this.cust_last_name_label);
            this.tabPage3.Controls.Add(this.cust_mid_name_label);
            this.tabPage3.Controls.Add(this.cust_f_name_label);
            this.tabPage3.Controls.Add(this.cust_custID_label);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1836, 724);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cust_del_but
            // 
            this.cust_del_but.Location = new System.Drawing.Point(957, 650);
            this.cust_del_but.Margin = new System.Windows.Forms.Padding(4);
            this.cust_del_but.Name = "cust_del_but";
            this.cust_del_but.Size = new System.Drawing.Size(133, 65);
            this.cust_del_but.TabIndex = 35;
            this.cust_del_but.Text = "Delete";
            this.cust_del_but.UseVisualStyleBackColor = true;
            this.cust_del_but.Click += new System.EventHandler(this.cust_del_but_Click);
            // 
            // cust_box_search
            // 
            this.cust_box_search.FormattingEnabled = true;
            this.cust_box_search.Items.AddRange(new object[] {
            "Customer ID",
            "First Name",
            "Middle Name",
            "Last Name",
            "Street Address 1",
            "Street Address 2",
            "City",
            "Province",
            "Postal Code",
            "DOB",
            "Phone Number",
            "Insurance",
            "Drivers_License",
            "Membership Status"});
            this.cust_box_search.Location = new System.Drawing.Point(461, 606);
            this.cust_box_search.Margin = new System.Windows.Forms.Padding(4);
            this.cust_box_search.Name = "cust_box_search";
            this.cust_box_search.Size = new System.Drawing.Size(160, 24);
            this.cust_box_search.TabIndex = 5;
            this.cust_box_search.Text = "---Select---";
            // 
            // cust_id_search_label
            // 
            this.cust_id_search_label.AutoSize = true;
            this.cust_id_search_label.Location = new System.Drawing.Point(855, 607);
            this.cust_id_search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_id_search_label.Name = "cust_id_search_label";
            this.cust_id_search_label.Size = new System.Drawing.Size(77, 16);
            this.cust_id_search_label.TabIndex = 34;
            this.cust_id_search_label.Text = "CustomerID";
            // 
            // cust_id_LU_txt
            // 
            this.cust_id_LU_txt.Location = new System.Drawing.Point(957, 607);
            this.cust_id_LU_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_id_LU_txt.Name = "cust_id_LU_txt";
            this.cust_id_LU_txt.Size = new System.Drawing.Size(132, 22);
            this.cust_id_LU_txt.TabIndex = 33;
            // 
            // cust_search_box_txt
            // 
            this.cust_search_box_txt.Location = new System.Drawing.Point(653, 606);
            this.cust_search_box_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_search_box_txt.Name = "cust_search_box_txt";
            this.cust_search_box_txt.Size = new System.Drawing.Size(132, 22);
            this.cust_search_box_txt.TabIndex = 32;
            // 
            // cust_search_box
            // 
            this.cust_search_box.AutoSize = true;
            this.cust_search_box.Location = new System.Drawing.Point(379, 606);
            this.cust_search_box.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_search_box.Name = "cust_search_box";
            this.cust_search_box.Size = new System.Drawing.Size(69, 16);
            this.cust_search_box.TabIndex = 5;
            this.cust_search_box.Text = "Search By";
            // 
            // cust_search_but
            // 
            this.cust_search_but.Location = new System.Drawing.Point(653, 647);
            this.cust_search_but.Margin = new System.Windows.Forms.Padding(4);
            this.cust_search_but.Name = "cust_search_but";
            this.cust_search_but.Size = new System.Drawing.Size(133, 68);
            this.cust_search_but.TabIndex = 6;
            this.cust_search_but.Text = "Search";
            this.cust_search_but.UseVisualStyleBackColor = true;
            this.cust_search_but.Click += new System.EventHandler(this.cust_search_but_Click);
            // 
            // cust_refresh_but
            // 
            this.cust_refresh_but.Location = new System.Drawing.Point(1640, 629);
            this.cust_refresh_but.Margin = new System.Windows.Forms.Padding(4);
            this.cust_refresh_but.Name = "cust_refresh_but";
            this.cust_refresh_but.Size = new System.Drawing.Size(127, 75);
            this.cust_refresh_but.TabIndex = 31;
            this.cust_refresh_but.Text = "Refresh";
            this.cust_refresh_but.UseVisualStyleBackColor = true;
            this.cust_refresh_but.Click += new System.EventHandler(this.cust_refresh_but_Click);
            // 
            // cust_edit_but
            // 
            this.cust_edit_but.Location = new System.Drawing.Point(151, 636);
            this.cust_edit_but.Margin = new System.Windows.Forms.Padding(4);
            this.cust_edit_but.Name = "cust_edit_but";
            this.cust_edit_but.Size = new System.Drawing.Size(109, 60);
            this.cust_edit_but.TabIndex = 5;
            this.cust_edit_but.Text = "Edit";
            this.cust_edit_but.UseVisualStyleBackColor = true;
            this.cust_edit_but.Click += new System.EventHandler(this.cust_edit_but_Click);
            // 
            // customer_view
            // 
            this.customer_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.customer_view.Location = new System.Drawing.Point(284, 16);
            this.customer_view.Margin = new System.Windows.Forms.Padding(4);
            this.customer_view.Name = "customer_view";
            this.customer_view.RowHeadersWidth = 51;
            this.customer_view.Size = new System.Drawing.Size(1556, 558);
            this.customer_view.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Customer ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Middle Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Street Address 1";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Street Address 2";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "City";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Province";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Postal Code";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "DOB";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Phone Number";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Insurance";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Drivers License";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Membership Status";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.Width = 125;
            // 
            // cust_add_but
            // 
            this.cust_add_but.Location = new System.Drawing.Point(11, 636);
            this.cust_add_but.Margin = new System.Windows.Forms.Padding(4);
            this.cust_add_but.Name = "cust_add_but";
            this.cust_add_but.Size = new System.Drawing.Size(111, 62);
            this.cust_add_but.TabIndex = 28;
            this.cust_add_but.Text = "Add";
            this.cust_add_but.UseVisualStyleBackColor = true;
            this.cust_add_but.Click += new System.EventHandler(this.cust_add_but_Click);
            // 
            // cust_drivers_txt
            // 
            this.cust_drivers_txt.Location = new System.Drawing.Point(128, 510);
            this.cust_drivers_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_drivers_txt.Name = "cust_drivers_txt";
            this.cust_drivers_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_drivers_txt.TabIndex = 26;
            // 
            // cust_insurance_txt
            // 
            this.cust_insurance_txt.Location = new System.Drawing.Point(128, 471);
            this.cust_insurance_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_insurance_txt.Name = "cust_insurance_txt";
            this.cust_insurance_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_insurance_txt.TabIndex = 25;
            // 
            // cust_phone_num_txt
            // 
            this.cust_phone_num_txt.Location = new System.Drawing.Point(128, 432);
            this.cust_phone_num_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_phone_num_txt.Name = "cust_phone_num_txt";
            this.cust_phone_num_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_phone_num_txt.TabIndex = 24;
            // 
            // cust_dob_txt
            // 
            this.cust_dob_txt.Location = new System.Drawing.Point(129, 390);
            this.cust_dob_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_dob_txt.Name = "cust_dob_txt";
            this.cust_dob_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_dob_txt.TabIndex = 23;
            // 
            // cust_pCode_txt
            // 
            this.cust_pCode_txt.Location = new System.Drawing.Point(128, 351);
            this.cust_pCode_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_pCode_txt.Name = "cust_pCode_txt";
            this.cust_pCode_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_pCode_txt.TabIndex = 22;
            // 
            // cust_prov_txt
            // 
            this.cust_prov_txt.Location = new System.Drawing.Point(128, 310);
            this.cust_prov_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_prov_txt.Name = "cust_prov_txt";
            this.cust_prov_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_prov_txt.TabIndex = 21;
            // 
            // cust_city_txt
            // 
            this.cust_city_txt.Location = new System.Drawing.Point(128, 272);
            this.cust_city_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_city_txt.Name = "cust_city_txt";
            this.cust_city_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_city_txt.TabIndex = 20;
            // 
            // cust_street_add2_txt
            // 
            this.cust_street_add2_txt.Location = new System.Drawing.Point(128, 229);
            this.cust_street_add2_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_street_add2_txt.Name = "cust_street_add2_txt";
            this.cust_street_add2_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_street_add2_txt.TabIndex = 19;
            // 
            // cust_street_add1_txt
            // 
            this.cust_street_add1_txt.Location = new System.Drawing.Point(129, 188);
            this.cust_street_add1_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_street_add1_txt.Name = "cust_street_add1_txt";
            this.cust_street_add1_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_street_add1_txt.TabIndex = 18;
            // 
            // cust_last_name_txt
            // 
            this.cust_last_name_txt.Location = new System.Drawing.Point(129, 144);
            this.cust_last_name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_last_name_txt.Name = "cust_last_name_txt";
            this.cust_last_name_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_last_name_txt.TabIndex = 17;
            // 
            // cust_mid_name_txt
            // 
            this.cust_mid_name_txt.Location = new System.Drawing.Point(129, 100);
            this.cust_mid_name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_mid_name_txt.Name = "cust_mid_name_txt";
            this.cust_mid_name_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_mid_name_txt.TabIndex = 16;
            // 
            // cust_first_name_txt
            // 
            this.cust_first_name_txt.Location = new System.Drawing.Point(129, 57);
            this.cust_first_name_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_first_name_txt.Name = "cust_first_name_txt";
            this.cust_first_name_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_first_name_txt.TabIndex = 15;
            // 
            // cust_custID_txt
            // 
            this.cust_custID_txt.Location = new System.Drawing.Point(129, 16);
            this.cust_custID_txt.Margin = new System.Windows.Forms.Padding(4);
            this.cust_custID_txt.Name = "cust_custID_txt";
            this.cust_custID_txt.Size = new System.Drawing.Size(144, 22);
            this.cust_custID_txt.TabIndex = 14;
            // 
            // cust_drivers_label
            // 
            this.cust_drivers_label.AutoSize = true;
            this.cust_drivers_label.Location = new System.Drawing.Point(7, 510);
            this.cust_drivers_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_drivers_label.Name = "cust_drivers_label";
            this.cust_drivers_label.Size = new System.Drawing.Size(124, 16);
            this.cust_drivers_label.TabIndex = 12;
            this.cust_drivers_label.Text = "Drivers License No.";
            // 
            // cust_insurance_label
            // 
            this.cust_insurance_label.AutoSize = true;
            this.cust_insurance_label.Location = new System.Drawing.Point(7, 471);
            this.cust_insurance_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_insurance_label.Name = "cust_insurance_label";
            this.cust_insurance_label.Size = new System.Drawing.Size(65, 16);
            this.cust_insurance_label.TabIndex = 11;
            this.cust_insurance_label.Text = "Insurance";
            // 
            // cust_phone_num_label
            // 
            this.cust_phone_num_label.AutoSize = true;
            this.cust_phone_num_label.Location = new System.Drawing.Point(7, 432);
            this.cust_phone_num_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_phone_num_label.Name = "cust_phone_num_label";
            this.cust_phone_num_label.Size = new System.Drawing.Size(97, 16);
            this.cust_phone_num_label.TabIndex = 10;
            this.cust_phone_num_label.Text = "Phone Number";
            // 
            // cust_dob_label
            // 
            this.cust_dob_label.AutoSize = true;
            this.cust_dob_label.Location = new System.Drawing.Point(7, 390);
            this.cust_dob_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_dob_label.Name = "cust_dob_label";
            this.cust_dob_label.Size = new System.Drawing.Size(121, 16);
            this.cust_dob_label.TabIndex = 9;
            this.cust_dob_label.Text = "DOB (yyyy-mm-dd)";
            // 
            // cust_pCode_label
            // 
            this.cust_pCode_label.AutoSize = true;
            this.cust_pCode_label.Location = new System.Drawing.Point(7, 351);
            this.cust_pCode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_pCode_label.Name = "cust_pCode_label";
            this.cust_pCode_label.Size = new System.Drawing.Size(81, 16);
            this.cust_pCode_label.TabIndex = 8;
            this.cust_pCode_label.Text = "Postal Code";
            // 
            // cust_province_label
            // 
            this.cust_province_label.AutoSize = true;
            this.cust_province_label.Location = new System.Drawing.Point(7, 310);
            this.cust_province_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_province_label.Name = "cust_province_label";
            this.cust_province_label.Size = new System.Drawing.Size(60, 16);
            this.cust_province_label.TabIndex = 7;
            this.cust_province_label.Text = "Province";
            // 
            // cust_city_label
            // 
            this.cust_city_label.AutoSize = true;
            this.cust_city_label.Location = new System.Drawing.Point(7, 272);
            this.cust_city_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_city_label.Name = "cust_city_label";
            this.cust_city_label.Size = new System.Drawing.Size(29, 16);
            this.cust_city_label.TabIndex = 6;
            this.cust_city_label.Text = "City";
            // 
            // cust_street_add2_label
            // 
            this.cust_street_add2_label.AutoSize = true;
            this.cust_street_add2_label.Location = new System.Drawing.Point(7, 229);
            this.cust_street_add2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_street_add2_label.Name = "cust_street_add2_label";
            this.cust_street_add2_label.Size = new System.Drawing.Size(106, 16);
            this.cust_street_add2_label.TabIndex = 5;
            this.cust_street_add2_label.Text = "Street Address 2";
            // 
            // cust_street_add1_label
            // 
            this.cust_street_add1_label.AutoSize = true;
            this.cust_street_add1_label.Location = new System.Drawing.Point(7, 188);
            this.cust_street_add1_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_street_add1_label.Name = "cust_street_add1_label";
            this.cust_street_add1_label.Size = new System.Drawing.Size(106, 16);
            this.cust_street_add1_label.TabIndex = 4;
            this.cust_street_add1_label.Text = "Street Address 1";
            // 
            // cust_last_name_label
            // 
            this.cust_last_name_label.AutoSize = true;
            this.cust_last_name_label.Location = new System.Drawing.Point(7, 144);
            this.cust_last_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_last_name_label.Name = "cust_last_name_label";
            this.cust_last_name_label.Size = new System.Drawing.Size(72, 16);
            this.cust_last_name_label.TabIndex = 3;
            this.cust_last_name_label.Text = "Last Name";
            // 
            // cust_mid_name_label
            // 
            this.cust_mid_name_label.AutoSize = true;
            this.cust_mid_name_label.Location = new System.Drawing.Point(7, 100);
            this.cust_mid_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_mid_name_label.Name = "cust_mid_name_label";
            this.cust_mid_name_label.Size = new System.Drawing.Size(88, 16);
            this.cust_mid_name_label.TabIndex = 2;
            this.cust_mid_name_label.Text = "Middle Name";
            // 
            // cust_f_name_label
            // 
            this.cust_f_name_label.AutoSize = true;
            this.cust_f_name_label.Location = new System.Drawing.Point(7, 57);
            this.cust_f_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_f_name_label.Name = "cust_f_name_label";
            this.cust_f_name_label.Size = new System.Drawing.Size(72, 16);
            this.cust_f_name_label.TabIndex = 1;
            this.cust_f_name_label.Text = "First Name";
            // 
            // cust_custID_label
            // 
            this.cust_custID_label.AutoSize = true;
            this.cust_custID_label.Location = new System.Drawing.Point(7, 16);
            this.cust_custID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cust_custID_label.Name = "cust_custID_label";
            this.cust_custID_label.Size = new System.Drawing.Size(80, 16);
            this.cust_custID_label.TabIndex = 0;
            this.cust_custID_label.Text = "Customer ID";
            this.cust_custID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 784);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 862);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.CustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.carsTab.ResumeLayout(false);
            this.carsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cars_view)).EndInit();
            this.carTypeTab.ResumeLayout(false);
            this.carTypeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_view)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.TabPage carTypeTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label cust_drivers_label;
        private System.Windows.Forms.Label cust_insurance_label;
        private System.Windows.Forms.Label cust_phone_num_label;
        private System.Windows.Forms.Label cust_dob_label;
        private System.Windows.Forms.Label cust_pCode_label;
        private System.Windows.Forms.Label cust_province_label;
        private System.Windows.Forms.Label cust_city_label;
        private System.Windows.Forms.Label cust_street_add2_label;
        private System.Windows.Forms.Label cust_street_add1_label;
        private System.Windows.Forms.Label cust_last_name_label;
        private System.Windows.Forms.Label cust_mid_name_label;
        private System.Windows.Forms.Label cust_f_name_label;
        private System.Windows.Forms.Label cust_custID_label;
        private System.Windows.Forms.TextBox cust_drivers_txt;
        private System.Windows.Forms.TextBox cust_insurance_txt;
        private System.Windows.Forms.TextBox cust_phone_num_txt;
        private System.Windows.Forms.TextBox cust_dob_txt;
        private System.Windows.Forms.TextBox cust_pCode_txt;
        private System.Windows.Forms.TextBox cust_prov_txt;
        private System.Windows.Forms.TextBox cust_city_txt;
        private System.Windows.Forms.TextBox cust_street_add2_txt;
        private System.Windows.Forms.TextBox cust_street_add1_txt;
        private System.Windows.Forms.TextBox cust_last_name_txt;
        private System.Windows.Forms.TextBox cust_mid_name_txt;
        private System.Windows.Forms.TextBox cust_first_name_txt;
        private System.Windows.Forms.TextBox cust_custID_txt;
        private System.Windows.Forms.Button cust_add_but;
        private System.Windows.Forms.Button cust_refresh_but;
        private System.Windows.Forms.DataGridView customer_view;
        private System.Windows.Forms.Label branch_id_LU_label;
        private System.Windows.Forms.TextBox branch_id_LU_txt;
        private System.Windows.Forms.Button branch_search_but;
        private System.Windows.Forms.Button branch_del_but;
        private System.Windows.Forms.Button branch_add_but;
        private System.Windows.Forms.DataGridView branch_view;
        private System.Windows.Forms.TextBox branch_id_txt;
        private System.Windows.Forms.TextBox branch_phone_num_txt;
        private System.Windows.Forms.TextBox branch_pCode_txt;
        private System.Windows.Forms.TextBox branch_province_txt;
        private System.Windows.Forms.TextBox branch_city_txt;
        private System.Windows.Forms.TextBox branch_street_add2_txt;
        private System.Windows.Forms.TextBox branch_street_add1_txt;
        private System.Windows.Forms.TextBox branch_descrip_txt;
        private System.Windows.Forms.Label branch_phone_num_label;
        private System.Windows.Forms.Label branch_pCode_label;
        private System.Windows.Forms.Label branch_province_label;
        private System.Windows.Forms.Label branch_city_label;
        private System.Windows.Forms.Label branch_street_add2_label;
        private System.Windows.Forms.Label branch_street_add1_label;
        private System.Windows.Forms.Label branch_dscrip_label;
        private System.Windows.Forms.Label branch_id_label;
        private System.Windows.Forms.Button branch_refresh_but;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.Label cars_branch_id_label;
        private System.Windows.Forms.Label cars_vin_label;
        private System.Windows.Forms.ComboBox cars_branch_id_dropdown;
        private System.Windows.Forms.TextBox cars_vin_text;
        private System.Windows.Forms.Label cars_odometer_label;
        private System.Windows.Forms.Label cars_no_seats_label;
        private System.Windows.Forms.Label cars_colour_label;
        private System.Windows.Forms.Label cars_insurance_no_label;
        private System.Windows.Forms.Label cars_year_label;
        private System.Windows.Forms.Label cars_model_label;
        private System.Windows.Forms.DataGridView cars_view;
        private System.Windows.Forms.TextBox cars_odometer_no_txt;
        private System.Windows.Forms.TextBox cars_no_seats_txt;
        private System.Windows.Forms.TextBox cars_colour_txt;
        private System.Windows.Forms.TextBox cars_insurance_no_txt;
        private System.Windows.Forms.TextBox cars_year_txt;
        private System.Windows.Forms.TextBox cars_model_txt;
        private System.Windows.Forms.Button btn_cars_search;
        private System.Windows.Forms.Button btn_cars_add;
        private System.Windows.Forms.Button typeSBut;
        private System.Windows.Forms.Button addTypeBut;
        private System.Windows.Forms.DataGridView carTypeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_ID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENTAL_CLASS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAILY_RENTAL_COST_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEEKLY_RENTAL_COST_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTHLY_RENTAL_COST_COL;
        private System.Windows.Forms.Label rentalCostSLabel;
        private System.Windows.Forms.Label typeSDescLabel;
        private System.Windows.Forms.Label modelSLabel;
        private System.Windows.Forms.Label rentalCostLabel;
        private System.Windows.Forms.Label typeDescLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox modelS;
        private System.Windows.Forms.TextBox dRent;
        private System.Windows.Forms.TextBox typeDesc;
        private System.Windows.Forms.TextBox modelID;
        private System.Windows.Forms.Button branch_edit_but;
        private System.Windows.Forms.TextBox branch_search_text_box;
        private System.Windows.Forms.ComboBox branch_search_box;
        private System.Windows.Forms.Label branch_search_label;
        private System.Windows.Forms.Label DailyRentLabel;
        private System.Windows.Forms.Label WeeklyRentLabel;
        private System.Windows.Forms.Label MonthlyRentLabel;
        private System.Windows.Forms.TextBox mRent;
        private System.Windows.Forms.TextBox wRent;
        private System.Windows.Forms.Button editTypeBut;
        private System.Windows.Forms.Button delTypeBut;
        private System.Windows.Forms.ComboBox cust_box_search;
        private System.Windows.Forms.Label cust_id_search_label;
        private System.Windows.Forms.TextBox cust_id_LU_txt;
        private System.Windows.Forms.TextBox cust_search_box_txt;
        private System.Windows.Forms.Label cust_search_box;
        private System.Windows.Forms.Button cust_search_but;
        private System.Windows.Forms.Button cust_edit_but;
        private System.Windows.Forms.Button cust_del_but;
        private System.Windows.Forms.Button btn_cars_show_all;
        private System.Windows.Forms.Button btn_cars_delete;
        private System.Windows.Forms.ComboBox cars_delete_dropdown;
        private System.Windows.Forms.ComboBox cars_search_attribute_dropdown;
        private System.Windows.Forms.Label cars_search_label;
        private System.Windows.Forms.Button btn_cars_edit;
        private System.Windows.Forms.ComboBox cars_car_type_id_dropdown;
        private System.Windows.Forms.Label cars_car_type_id_label;
        private System.Windows.Forms.Label cars_make_label;
        private System.Windows.Forms.TextBox cars_make_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_SEATS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOUR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSURANCE_NO_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODOMETER_NO_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANCH_ID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_TYPE_ID_COL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cars_search_dropdown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.TextBox dCostS2;
        private System.Windows.Forms.TextBox dCostS1;
        private System.Windows.Forms.TextBox descS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mCostS2;
        private System.Windows.Forms.TextBox mCostS1;
        private System.Windows.Forms.TextBox wCostS2;
        private System.Windows.Forms.TextBox wCostS1;
    }
}