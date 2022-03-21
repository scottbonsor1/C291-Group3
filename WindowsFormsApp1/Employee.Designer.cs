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
            this.vin_delete_label = new System.Windows.Forms.Label();
            this.vin_delete_txt = new System.Windows.Forms.TextBox();
            this.cars_make_txt = new System.Windows.Forms.TextBox();
            this.cars_car_type_drop_down = new System.Windows.Forms.ComboBox();
            this.cars_search_txt = new System.Windows.Forms.TextBox();
            this.cars_search_drop_down = new System.Windows.Forms.ComboBox();
            this.btn_show_all_cars = new System.Windows.Forms.Button();
            this.btn_delete_cars = new System.Windows.Forms.Button();
            this.btn_edit_car = new System.Windows.Forms.Button();
            this.cars_odometer_txt = new System.Windows.Forms.TextBox();
            this.cars_odometer_label = new System.Windows.Forms.Label();
            this.cars_insurance_no_txt = new System.Windows.Forms.TextBox();
            this.cars_insurance_no_label = new System.Windows.Forms.Label();
            this.btn_search_cars = new System.Windows.Forms.Button();
            this.btn_add_car = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.VIN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_SEATS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOUR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INSURANCE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODOMETER_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRANCH_ID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_TYPE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cars_branch_id_txt = new System.Windows.Forms.TextBox();
            this.cars_no_seats_txt = new System.Windows.Forms.TextBox();
            this.cars_colour_txt = new System.Windows.Forms.TextBox();
            this.cars_year_txt = new System.Windows.Forms.TextBox();
            this.cars_model_txt = new System.Windows.Forms.TextBox();
            this.cars_branch_id_label = new System.Windows.Forms.Label();
            this.cars_no_seats_label = new System.Windows.Forms.Label();
            this.cars_colour_label = new System.Windows.Forms.Label();
            this.cars_car_type_label = new System.Windows.Forms.Label();
            this.cars_year_label = new System.Windows.Forms.Label();
            this.cars_model_label = new System.Windows.Forms.Label();
            this.cars_vin_label = new System.Windows.Forms.Label();
            this.cars_vin_txt = new System.Windows.Forms.TextBox();
            this.cars_make_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modelS = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.rentalCostS = new System.Windows.Forms.ComboBox();
            this.rentalClassS = new System.Windows.Forms.ComboBox();
            this.rentalCostSLabel = new System.Windows.Forms.Label();
            this.rentalClassSLabel = new System.Windows.Forms.Label();
            this.modelSLabel = new System.Windows.Forms.Label();
            this.rentalCostLabel = new System.Windows.Forms.Label();
            this.rentalClassLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.carTypeSBut = new System.Windows.Forms.Button();
            this.addCarTypeBut = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
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
            this.cust_refresh_but = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cust_del_but = new System.Windows.Forms.Button();
            this.cust_add_but = new System.Windows.Forms.Button();
            this.cust_memStat_txt = new System.Windows.Forms.TextBox();
            this.cust_drivers_txt = new System.Windows.Forms.TextBox();
            this.cust_insurance_txt = new System.Windows.Forms.TextBox();
            this.cust_phone_num_txt = new System.Windows.Forms.TextBox();
            this.cust_dob_txt = new System.Windows.Forms.TextBox();
            this.cust_pCode_txt = new System.Windows.Forms.TextBox();
            this.cust_prov_txt = new System.Windows.Forms.TextBox();
            this.cust_city_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add2_txt = new System.Windows.Forms.TextBox();
            this.cust_street_add1_txt = new System.Windows.Forms.TextBox();
            this.cust_l_name_txt = new System.Windows.Forms.TextBox();
            this.cust_m_name_txt = new System.Windows.Forms.TextBox();
            this.cust_f_name_txt = new System.Windows.Forms.TextBox();
            this.cust_custID_txt = new System.Windows.Forms.TextBox();
            this.cust_memStat_label = new System.Windows.Forms.Label();
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
            this.cars_test_button = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.carsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_view)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(1280, 657);
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
            this.Tabs.Margin = new System.Windows.Forms.Padding(2);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1383, 612);
            this.Tabs.TabIndex = 3;
            // 
            // carsTab
            // 
            this.carsTab.Controls.Add(this.cars_test_button);
            this.carsTab.Controls.Add(this.vin_delete_label);
            this.carsTab.Controls.Add(this.vin_delete_txt);
            this.carsTab.Controls.Add(this.cars_make_txt);
            this.carsTab.Controls.Add(this.cars_car_type_drop_down);
            this.carsTab.Controls.Add(this.cars_search_txt);
            this.carsTab.Controls.Add(this.cars_search_drop_down);
            this.carsTab.Controls.Add(this.btn_show_all_cars);
            this.carsTab.Controls.Add(this.btn_delete_cars);
            this.carsTab.Controls.Add(this.btn_edit_car);
            this.carsTab.Controls.Add(this.cars_odometer_txt);
            this.carsTab.Controls.Add(this.cars_odometer_label);
            this.carsTab.Controls.Add(this.cars_insurance_no_txt);
            this.carsTab.Controls.Add(this.cars_insurance_no_label);
            this.carsTab.Controls.Add(this.btn_search_cars);
            this.carsTab.Controls.Add(this.btn_add_car);
            this.carsTab.Controls.Add(this.dataGridView3);
            this.carsTab.Controls.Add(this.cars_branch_id_txt);
            this.carsTab.Controls.Add(this.cars_no_seats_txt);
            this.carsTab.Controls.Add(this.cars_colour_txt);
            this.carsTab.Controls.Add(this.cars_year_txt);
            this.carsTab.Controls.Add(this.cars_model_txt);
            this.carsTab.Controls.Add(this.cars_branch_id_label);
            this.carsTab.Controls.Add(this.cars_no_seats_label);
            this.carsTab.Controls.Add(this.cars_colour_label);
            this.carsTab.Controls.Add(this.cars_car_type_label);
            this.carsTab.Controls.Add(this.cars_year_label);
            this.carsTab.Controls.Add(this.cars_model_label);
            this.carsTab.Controls.Add(this.cars_vin_label);
            this.carsTab.Controls.Add(this.cars_vin_txt);
            this.carsTab.Controls.Add(this.cars_make_label);
            this.carsTab.Location = new System.Drawing.Point(4, 22);
            this.carsTab.Margin = new System.Windows.Forms.Padding(2);
            this.carsTab.Name = "carsTab";
            this.carsTab.Padding = new System.Windows.Forms.Padding(2);
            this.carsTab.Size = new System.Drawing.Size(1375, 586);
            this.carsTab.TabIndex = 0;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            this.carsTab.Click += new System.EventHandler(this.carsTab_Click);
            // 
            // vin_delete_label
            // 
            this.vin_delete_label.AutoSize = true;
            this.vin_delete_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_delete_label.Location = new System.Drawing.Point(913, 509);
            this.vin_delete_label.Name = "vin_delete_label";
            this.vin_delete_label.Size = new System.Drawing.Size(95, 17);
            this.vin_delete_label.TabIndex = 41;
            this.vin_delete_label.Text = "VIN to Delete:";
            // 
            // vin_delete_txt
            // 
            this.vin_delete_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vin_delete_txt.Location = new System.Drawing.Point(1014, 507);
            this.vin_delete_txt.Name = "vin_delete_txt";
            this.vin_delete_txt.Size = new System.Drawing.Size(152, 23);
            this.vin_delete_txt.TabIndex = 40;
            // 
            // cars_make_txt
            // 
            this.cars_make_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_make_txt.Location = new System.Drawing.Point(121, 80);
            this.cars_make_txt.Name = "cars_make_txt";
            this.cars_make_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_make_txt.TabIndex = 39;
            // 
            // cars_car_type_drop_down
            // 
            this.cars_car_type_drop_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_car_type_drop_down.FormattingEnabled = true;
            this.cars_car_type_drop_down.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cars_car_type_drop_down.Location = new System.Drawing.Point(121, 387);
            this.cars_car_type_drop_down.Name = "cars_car_type_drop_down";
            this.cars_car_type_drop_down.Size = new System.Drawing.Size(152, 24);
            this.cars_car_type_drop_down.TabIndex = 38;
            this.cars_car_type_drop_down.Tag = "carTypeOptions";
            // 
            // cars_search_txt
            // 
            this.cars_search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_search_txt.Location = new System.Drawing.Point(570, 506);
            this.cars_search_txt.Name = "cars_search_txt";
            this.cars_search_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_search_txt.TabIndex = 37;
            // 
            // cars_search_drop_down
            // 
            this.cars_search_drop_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_search_drop_down.FormattingEnabled = true;
            this.cars_search_drop_down.Items.AddRange(new object[] {
            "VIN",
            "Make",
            "Model",
            "Year",
            "No. of Seats",
            "Colour",
            "Insurance No.",
            "Odometer",
            "Branch ID",
            "Car Type"});
            this.cars_search_drop_down.Location = new System.Drawing.Point(409, 506);
            this.cars_search_drop_down.Name = "cars_search_drop_down";
            this.cars_search_drop_down.Size = new System.Drawing.Size(152, 24);
            this.cars_search_drop_down.TabIndex = 36;
            this.cars_search_drop_down.Tag = "carTypeOptions";
            this.cars_search_drop_down.Text = "--- Select ---";
            // 
            // btn_show_all_cars
            // 
            this.btn_show_all_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_all_cars.Location = new System.Drawing.Point(1247, 506);
            this.btn_show_all_cars.Name = "btn_show_all_cars";
            this.btn_show_all_cars.Size = new System.Drawing.Size(94, 34);
            this.btn_show_all_cars.TabIndex = 35;
            this.btn_show_all_cars.Text = "Show All";
            this.btn_show_all_cars.UseVisualStyleBackColor = true;
            // 
            // btn_delete_cars
            // 
            this.btn_delete_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_cars.Location = new System.Drawing.Point(1044, 535);
            this.btn_delete_cars.Name = "btn_delete_cars";
            this.btn_delete_cars.Size = new System.Drawing.Size(94, 34);
            this.btn_delete_cars.TabIndex = 34;
            this.btn_delete_cars.Text = "Delete";
            this.btn_delete_cars.UseVisualStyleBackColor = true;
            // 
            // btn_edit_car
            // 
            this.btn_edit_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_car.Location = new System.Drawing.Point(163, 460);
            this.btn_edit_car.Name = "btn_edit_car";
            this.btn_edit_car.Size = new System.Drawing.Size(94, 34);
            this.btn_edit_car.TabIndex = 33;
            this.btn_edit_car.Text = "Edit Car";
            this.btn_edit_car.UseVisualStyleBackColor = true;
            // 
            // cars_odometer_txt
            // 
            this.cars_odometer_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_odometer_txt.Location = new System.Drawing.Point(121, 306);
            this.cars_odometer_txt.Name = "cars_odometer_txt";
            this.cars_odometer_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_odometer_txt.TabIndex = 32;
            // 
            // cars_odometer_label
            // 
            this.cars_odometer_label.AutoSize = true;
            this.cars_odometer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_odometer_label.Location = new System.Drawing.Point(15, 311);
            this.cars_odometer_label.Name = "cars_odometer_label";
            this.cars_odometer_label.Size = new System.Drawing.Size(97, 17);
            this.cars_odometer_label.TabIndex = 31;
            this.cars_odometer_label.Text = "Odometer No.";
            // 
            // cars_insurance_no_txt
            // 
            this.cars_insurance_no_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_insurance_no_txt.Location = new System.Drawing.Point(121, 268);
            this.cars_insurance_no_txt.Name = "cars_insurance_no_txt";
            this.cars_insurance_no_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_insurance_no_txt.TabIndex = 30;
            this.cars_insurance_no_txt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // cars_insurance_no_label
            // 
            this.cars_insurance_no_label.AutoSize = true;
            this.cars_insurance_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_insurance_no_label.Location = new System.Drawing.Point(15, 273);
            this.cars_insurance_no_label.Name = "cars_insurance_no_label";
            this.cars_insurance_no_label.Size = new System.Drawing.Size(96, 17);
            this.cars_insurance_no_label.TabIndex = 29;
            this.cars_insurance_no_label.Text = "Insurance No.";
            this.cars_insurance_no_label.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // btn_search_cars
            // 
            this.btn_search_cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_cars.Location = new System.Drawing.Point(601, 535);
            this.btn_search_cars.Name = "btn_search_cars";
            this.btn_search_cars.Size = new System.Drawing.Size(94, 34);
            this.btn_search_cars.TabIndex = 28;
            this.btn_search_cars.Text = "Search";
            this.btn_search_cars.UseVisualStyleBackColor = true;
            // 
            // btn_add_car
            // 
            this.btn_add_car.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_car.Location = new System.Drawing.Point(18, 460);
            this.btn_add_car.Name = "btn_add_car";
            this.btn_add_car.Size = new System.Drawing.Size(94, 34);
            this.btn_add_car.TabIndex = 27;
            this.btn_add_car.Text = "Add  Car";
            this.btn_add_car.UseVisualStyleBackColor = true;
            this.btn_add_car.Click += new System.EventHandler(this.btn_add_car_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN_COL,
            this.MAKE_COL,
            this.MODEL_COL,
            this.YEAR_COL,
            this.NO_SEATS_COL,
            this.COLOUR_COL,
            this.INSURANCE_COL,
            this.ODOMETER_COL,
            this.BRANCH_ID_COL,
            this.CAR_TYPE_COL});
            this.dataGridView3.Location = new System.Drawing.Point(308, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1033, 483);
            this.dataGridView3.TabIndex = 17;
            // 
            // VIN_COL
            // 
            this.VIN_COL.HeaderText = "VIN";
            this.VIN_COL.MinimumWidth = 6;
            this.VIN_COL.Name = "VIN_COL";
            this.VIN_COL.ReadOnly = true;
            this.VIN_COL.Width = 125;
            // 
            // MAKE_COL
            // 
            this.MAKE_COL.HeaderText = "Make";
            this.MAKE_COL.MinimumWidth = 6;
            this.MAKE_COL.Name = "MAKE_COL";
            this.MAKE_COL.ReadOnly = true;
            this.MAKE_COL.Width = 125;
            // 
            // MODEL_COL
            // 
            this.MODEL_COL.HeaderText = "Model";
            this.MODEL_COL.MinimumWidth = 6;
            this.MODEL_COL.Name = "MODEL_COL";
            this.MODEL_COL.ReadOnly = true;
            this.MODEL_COL.Width = 125;
            // 
            // YEAR_COL
            // 
            this.YEAR_COL.HeaderText = "Year";
            this.YEAR_COL.MinimumWidth = 6;
            this.YEAR_COL.Name = "YEAR_COL";
            this.YEAR_COL.ReadOnly = true;
            this.YEAR_COL.Width = 125;
            // 
            // NO_SEATS_COL
            // 
            this.NO_SEATS_COL.HeaderText = "No. of Seats";
            this.NO_SEATS_COL.MinimumWidth = 6;
            this.NO_SEATS_COL.Name = "NO_SEATS_COL";
            this.NO_SEATS_COL.ReadOnly = true;
            this.NO_SEATS_COL.Width = 125;
            // 
            // COLOUR_COL
            // 
            this.COLOUR_COL.HeaderText = "Colour";
            this.COLOUR_COL.MinimumWidth = 6;
            this.COLOUR_COL.Name = "COLOUR_COL";
            this.COLOUR_COL.ReadOnly = true;
            this.COLOUR_COL.Width = 125;
            // 
            // INSURANCE_COL
            // 
            this.INSURANCE_COL.HeaderText = "Insurance No.";
            this.INSURANCE_COL.Name = "INSURANCE_COL";
            // 
            // ODOMETER_COL
            // 
            this.ODOMETER_COL.HeaderText = "Odometer";
            this.ODOMETER_COL.Name = "ODOMETER_COL";
            // 
            // BRANCH_ID_COL
            // 
            this.BRANCH_ID_COL.HeaderText = "Branch ID";
            this.BRANCH_ID_COL.MinimumWidth = 6;
            this.BRANCH_ID_COL.Name = "BRANCH_ID_COL";
            this.BRANCH_ID_COL.ReadOnly = true;
            this.BRANCH_ID_COL.Width = 125;
            // 
            // CAR_TYPE_COL
            // 
            this.CAR_TYPE_COL.HeaderText = "Car Type";
            this.CAR_TYPE_COL.MinimumWidth = 6;
            this.CAR_TYPE_COL.Name = "CAR_TYPE_COL";
            this.CAR_TYPE_COL.ReadOnly = true;
            this.CAR_TYPE_COL.Width = 125;
            // 
            // cars_branch_id_txt
            // 
            this.cars_branch_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_branch_id_txt.Location = new System.Drawing.Point(121, 344);
            this.cars_branch_id_txt.Name = "cars_branch_id_txt";
            this.cars_branch_id_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_branch_id_txt.TabIndex = 16;
            // 
            // cars_no_seats_txt
            // 
            this.cars_no_seats_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_no_seats_txt.Location = new System.Drawing.Point(121, 192);
            this.cars_no_seats_txt.Name = "cars_no_seats_txt";
            this.cars_no_seats_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_no_seats_txt.TabIndex = 15;
            // 
            // cars_colour_txt
            // 
            this.cars_colour_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_colour_txt.Location = new System.Drawing.Point(121, 230);
            this.cars_colour_txt.Name = "cars_colour_txt";
            this.cars_colour_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_colour_txt.TabIndex = 14;
            // 
            // cars_year_txt
            // 
            this.cars_year_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_year_txt.Location = new System.Drawing.Point(121, 154);
            this.cars_year_txt.Name = "cars_year_txt";
            this.cars_year_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_year_txt.TabIndex = 12;
            // 
            // cars_model_txt
            // 
            this.cars_model_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_model_txt.Location = new System.Drawing.Point(121, 116);
            this.cars_model_txt.Name = "cars_model_txt";
            this.cars_model_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_model_txt.TabIndex = 11;
            this.cars_model_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cars_branch_id_label
            // 
            this.cars_branch_id_label.AutoSize = true;
            this.cars_branch_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_branch_id_label.Location = new System.Drawing.Point(15, 349);
            this.cars_branch_id_label.Name = "cars_branch_id_label";
            this.cars_branch_id_label.Size = new System.Drawing.Size(70, 17);
            this.cars_branch_id_label.TabIndex = 10;
            this.cars_branch_id_label.Text = "Branch ID";
            this.cars_branch_id_label.Click += new System.EventHandler(this.label7_Click);
            // 
            // cars_no_seats_label
            // 
            this.cars_no_seats_label.AutoSize = true;
            this.cars_no_seats_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_no_seats_label.Location = new System.Drawing.Point(15, 197);
            this.cars_no_seats_label.Name = "cars_no_seats_label";
            this.cars_no_seats_label.Size = new System.Drawing.Size(86, 17);
            this.cars_no_seats_label.TabIndex = 9;
            this.cars_no_seats_label.Text = "No. of Seats";
            // 
            // cars_colour_label
            // 
            this.cars_colour_label.AutoSize = true;
            this.cars_colour_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_colour_label.Location = new System.Drawing.Point(15, 235);
            this.cars_colour_label.Name = "cars_colour_label";
            this.cars_colour_label.Size = new System.Drawing.Size(49, 17);
            this.cars_colour_label.TabIndex = 8;
            this.cars_colour_label.Text = "Colour";
            // 
            // cars_car_type_label
            // 
            this.cars_car_type_label.AutoSize = true;
            this.cars_car_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_car_type_label.Location = new System.Drawing.Point(15, 387);
            this.cars_car_type_label.Name = "cars_car_type_label";
            this.cars_car_type_label.Size = new System.Drawing.Size(66, 17);
            this.cars_car_type_label.TabIndex = 7;
            this.cars_car_type_label.Text = "Car Type";
            // 
            // cars_year_label
            // 
            this.cars_year_label.AutoSize = true;
            this.cars_year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_year_label.Location = new System.Drawing.Point(15, 159);
            this.cars_year_label.Name = "cars_year_label";
            this.cars_year_label.Size = new System.Drawing.Size(38, 17);
            this.cars_year_label.TabIndex = 6;
            this.cars_year_label.Text = "Year";
            // 
            // cars_model_label
            // 
            this.cars_model_label.AutoSize = true;
            this.cars_model_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_model_label.Location = new System.Drawing.Point(15, 121);
            this.cars_model_label.Name = "cars_model_label";
            this.cars_model_label.Size = new System.Drawing.Size(46, 17);
            this.cars_model_label.TabIndex = 5;
            this.cars_model_label.Text = "Model";
            this.cars_model_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // cars_vin_label
            // 
            this.cars_vin_label.AutoSize = true;
            this.cars_vin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_vin_label.Location = new System.Drawing.Point(15, 45);
            this.cars_vin_label.Name = "cars_vin_label";
            this.cars_vin_label.Size = new System.Drawing.Size(30, 17);
            this.cars_vin_label.TabIndex = 4;
            this.cars_vin_label.Text = "VIN";
            this.cars_vin_label.Click += new System.EventHandler(this.vin_Click);
            // 
            // cars_vin_txt
            // 
            this.cars_vin_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_vin_txt.Location = new System.Drawing.Point(121, 39);
            this.cars_vin_txt.Name = "cars_vin_txt";
            this.cars_vin_txt.Size = new System.Drawing.Size(152, 23);
            this.cars_vin_txt.TabIndex = 2;
            // 
            // cars_make_label
            // 
            this.cars_make_label.AutoSize = true;
            this.cars_make_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cars_make_label.Location = new System.Drawing.Point(15, 83);
            this.cars_make_label.Name = "cars_make_label";
            this.cars_make_label.Size = new System.Drawing.Size(42, 17);
            this.cars_make_label.TabIndex = 1;
            this.cars_make_label.Text = "Make";
            this.cars_make_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.modelS);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.ModelText);
            this.tabPage2.Controls.Add(this.rentalCostS);
            this.tabPage2.Controls.Add(this.rentalClassS);
            this.tabPage2.Controls.Add(this.rentalCostSLabel);
            this.tabPage2.Controls.Add(this.rentalClassSLabel);
            this.tabPage2.Controls.Add(this.modelSLabel);
            this.tabPage2.Controls.Add(this.rentalCostLabel);
            this.tabPage2.Controls.Add(this.rentalClassLabel);
            this.tabPage2.Controls.Add(this.ModelLabel);
            this.tabPage2.Controls.Add(this.carTypeSBut);
            this.tabPage2.Controls.Add(this.addCarTypeBut);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1375, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Car Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // modelS
            // 
            this.modelS.Location = new System.Drawing.Point(32, 289);
            this.modelS.Name = "modelS";
            this.modelS.Size = new System.Drawing.Size(100, 20);
            this.modelS.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(321, 106);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(175, 106);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 12;
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(32, 106);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(100, 20);
            this.ModelText.TabIndex = 11;
            // 
            // rentalCostS
            // 
            this.rentalCostS.FormattingEnabled = true;
            this.rentalCostS.Location = new System.Drawing.Point(310, 289);
            this.rentalCostS.Name = "rentalCostS";
            this.rentalCostS.Size = new System.Drawing.Size(121, 21);
            this.rentalCostS.TabIndex = 10;
            this.rentalCostS.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // rentalClassS
            // 
            this.rentalClassS.FormattingEnabled = true;
            this.rentalClassS.Location = new System.Drawing.Point(154, 288);
            this.rentalClassS.Name = "rentalClassS";
            this.rentalClassS.Size = new System.Drawing.Size(121, 21);
            this.rentalClassS.TabIndex = 9;
            // 
            // rentalCostSLabel
            // 
            this.rentalCostSLabel.AutoSize = true;
            this.rentalCostSLabel.Location = new System.Drawing.Point(338, 259);
            this.rentalCostSLabel.Name = "rentalCostSLabel";
            this.rentalCostSLabel.Size = new System.Drawing.Size(62, 13);
            this.rentalCostSLabel.TabIndex = 8;
            this.rentalCostSLabel.Text = "Rental Cost";
            // 
            // rentalClassSLabel
            // 
            this.rentalClassSLabel.AutoSize = true;
            this.rentalClassSLabel.Location = new System.Drawing.Point(196, 259);
            this.rentalClassSLabel.Name = "rentalClassSLabel";
            this.rentalClassSLabel.Size = new System.Drawing.Size(66, 13);
            this.rentalClassSLabel.TabIndex = 7;
            this.rentalClassSLabel.Text = "Rental Class";
            // 
            // modelSLabel
            // 
            this.modelSLabel.AutoSize = true;
            this.modelSLabel.Location = new System.Drawing.Point(63, 259);
            this.modelSLabel.Name = "modelSLabel";
            this.modelSLabel.Size = new System.Drawing.Size(50, 13);
            this.modelSLabel.TabIndex = 6;
            this.modelSLabel.Text = "Model ID";
            // 
            // rentalCostLabel
            // 
            this.rentalCostLabel.AutoSize = true;
            this.rentalCostLabel.Location = new System.Drawing.Point(338, 74);
            this.rentalCostLabel.Name = "rentalCostLabel";
            this.rentalCostLabel.Size = new System.Drawing.Size(62, 13);
            this.rentalCostLabel.TabIndex = 5;
            this.rentalCostLabel.Text = "Rental Cost";
            // 
            // rentalClassLabel
            // 
            this.rentalClassLabel.AutoSize = true;
            this.rentalClassLabel.Location = new System.Drawing.Point(196, 74);
            this.rentalClassLabel.Name = "rentalClassLabel";
            this.rentalClassLabel.Size = new System.Drawing.Size(66, 13);
            this.rentalClassLabel.TabIndex = 4;
            this.rentalClassLabel.Text = "Rental Class";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(63, 74);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 13);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model ID";
            this.ModelLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // carTypeSBut
            // 
            this.carTypeSBut.Location = new System.Drawing.Point(473, 286);
            this.carTypeSBut.Name = "carTypeSBut";
            this.carTypeSBut.Size = new System.Drawing.Size(95, 23);
            this.carTypeSBut.TabIndex = 2;
            this.carTypeSBut.Text = "Search Car Type";
            this.carTypeSBut.UseVisualStyleBackColor = true;
            // 
            // addCarTypeBut
            // 
            this.addCarTypeBut.Location = new System.Drawing.Point(484, 106);
            this.addCarTypeBut.Name = "addCarTypeBut";
            this.addCarTypeBut.Size = new System.Drawing.Size(84, 23);
            this.addCarTypeBut.TabIndex = 1;
            this.addCarTypeBut.Text = "Add Car Type";
            this.addCarTypeBut.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MODEL_ID_COL,
            this.RENTAL_CLASS_COL,
            this.DAILY_RENTAL_COST_COL,
            this.WEEKLY_RENTAL_COST_COL,
            this.MONTHLY_RENTAL_COST_COL});
            this.dataGridView4.Location = new System.Drawing.Point(628, 5);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(544, 370);
            this.dataGridView4.TabIndex = 0;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1375, 586);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Branches";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // branch_search_text_box
            // 
            this.branch_search_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_text_box.Location = new System.Drawing.Point(652, 479);
            this.branch_search_text_box.Name = "branch_search_text_box";
            this.branch_search_text_box.Size = new System.Drawing.Size(126, 22);
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
            this.branch_search_box.Location = new System.Drawing.Point(460, 479);
            this.branch_search_box.Name = "branch_search_box";
            this.branch_search_box.Size = new System.Drawing.Size(172, 24);
            this.branch_search_box.TabIndex = 25;
            this.branch_search_box.Text = "--- Select ---";
            // 
            // branch_search_label
            // 
            this.branch_search_label.AutoSize = true;
            this.branch_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_label.Location = new System.Drawing.Point(382, 482);
            this.branch_search_label.Name = "branch_search_label";
            this.branch_search_label.Size = new System.Drawing.Size(71, 16);
            this.branch_search_label.TabIndex = 24;
            this.branch_search_label.Text = "Search by:";
            // 
            // branch_edit_but
            // 
            this.branch_edit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_edit_but.Location = new System.Drawing.Point(191, 461);
            this.branch_edit_but.Name = "branch_edit_but";
            this.branch_edit_but.Size = new System.Drawing.Size(95, 62);
            this.branch_edit_but.TabIndex = 23;
            this.branch_edit_but.Text = "Edit";
            this.branch_edit_but.UseVisualStyleBackColor = true;
            this.branch_edit_but.Click += new System.EventHandler(this.branch_edit_but_Click);
            // 
            // branch_refresh_but
            // 
            this.branch_refresh_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_refresh_but.Location = new System.Drawing.Point(1185, 496);
            this.branch_refresh_but.Name = "branch_refresh_but";
            this.branch_refresh_but.Size = new System.Drawing.Size(96, 59);
            this.branch_refresh_but.TabIndex = 22;
            this.branch_refresh_but.Text = "Refresh";
            this.branch_refresh_but.UseVisualStyleBackColor = true;
            this.branch_refresh_but.Click += new System.EventHandler(this.branch_refresh_but_Click);
            // 
            // branch_id_LU_label
            // 
            this.branch_id_LU_label.AutoSize = true;
            this.branch_id_LU_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_LU_label.Location = new System.Drawing.Point(848, 485);
            this.branch_id_LU_label.Name = "branch_id_LU_label";
            this.branch_id_LU_label.Size = new System.Drawing.Size(125, 16);
            this.branch_id_LU_label.TabIndex = 21;
            this.branch_id_LU_label.Text = "Branch ID to Delete:";
            this.branch_id_LU_label.Click += new System.EventHandler(this.label9_Click);
            // 
            // branch_id_LU_txt
            // 
            this.branch_id_LU_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_LU_txt.Location = new System.Drawing.Point(979, 482);
            this.branch_id_LU_txt.Name = "branch_id_LU_txt";
            this.branch_id_LU_txt.Size = new System.Drawing.Size(100, 22);
            this.branch_id_LU_txt.TabIndex = 20;
            // 
            // branch_search_but
            // 
            this.branch_search_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_search_but.Location = new System.Drawing.Point(669, 513);
            this.branch_search_but.Name = "branch_search_but";
            this.branch_search_but.Size = new System.Drawing.Size(96, 56);
            this.branch_search_but.TabIndex = 19;
            this.branch_search_but.Text = "Search";
            this.branch_search_but.UseVisualStyleBackColor = true;
            this.branch_search_but.Click += new System.EventHandler(this.branch_search_but_Click);
            // 
            // branch_del_but
            // 
            this.branch_del_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_del_but.Location = new System.Drawing.Point(979, 510);
            this.branch_del_but.Name = "branch_del_but";
            this.branch_del_but.Size = new System.Drawing.Size(98, 59);
            this.branch_del_but.TabIndex = 18;
            this.branch_del_but.Text = "Delete";
            this.branch_del_but.UseVisualStyleBackColor = true;
            this.branch_del_but.Click += new System.EventHandler(this.branch_del_but_Click);
            // 
            // branch_add_but
            // 
            this.branch_add_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_add_but.Location = new System.Drawing.Point(38, 462);
            this.branch_add_but.Name = "branch_add_but";
            this.branch_add_but.Size = new System.Drawing.Size(95, 62);
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
            this.branch_view.Location = new System.Drawing.Point(308, 22);
            this.branch_view.Name = "branch_view";
            this.branch_view.RowHeadersWidth = 51;
            this.branch_view.Size = new System.Drawing.Size(1014, 435);
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
            this.branch_id_txt.Location = new System.Drawing.Point(150, 33);
            this.branch_id_txt.Name = "branch_id_txt";
            this.branch_id_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_id_txt.TabIndex = 15;
            // 
            // branch_phone_num_txt
            // 
            this.branch_phone_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_phone_num_txt.Location = new System.Drawing.Point(150, 405);
            this.branch_phone_num_txt.Name = "branch_phone_num_txt";
            this.branch_phone_num_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_phone_num_txt.TabIndex = 14;
            // 
            // branch_pCode_txt
            // 
            this.branch_pCode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_pCode_txt.Location = new System.Drawing.Point(150, 344);
            this.branch_pCode_txt.Name = "branch_pCode_txt";
            this.branch_pCode_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_pCode_txt.TabIndex = 13;
            // 
            // branch_province_txt
            // 
            this.branch_province_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_province_txt.Location = new System.Drawing.Point(150, 288);
            this.branch_province_txt.Name = "branch_province_txt";
            this.branch_province_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_province_txt.TabIndex = 12;
            // 
            // branch_city_txt
            // 
            this.branch_city_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_city_txt.Location = new System.Drawing.Point(150, 231);
            this.branch_city_txt.Name = "branch_city_txt";
            this.branch_city_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_city_txt.TabIndex = 11;
            // 
            // branch_street_add2_txt
            // 
            this.branch_street_add2_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add2_txt.Location = new System.Drawing.Point(150, 177);
            this.branch_street_add2_txt.Name = "branch_street_add2_txt";
            this.branch_street_add2_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_street_add2_txt.TabIndex = 10;
            // 
            // branch_street_add1_txt
            // 
            this.branch_street_add1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add1_txt.Location = new System.Drawing.Point(150, 124);
            this.branch_street_add1_txt.Name = "branch_street_add1_txt";
            this.branch_street_add1_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_street_add1_txt.TabIndex = 9;
            // 
            // branch_descrip_txt
            // 
            this.branch_descrip_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_descrip_txt.Location = new System.Drawing.Point(150, 73);
            this.branch_descrip_txt.Name = "branch_descrip_txt";
            this.branch_descrip_txt.Size = new System.Drawing.Size(152, 23);
            this.branch_descrip_txt.TabIndex = 8;
            // 
            // branch_phone_num_label
            // 
            this.branch_phone_num_label.AutoSize = true;
            this.branch_phone_num_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_phone_num_label.Location = new System.Drawing.Point(30, 405);
            this.branch_phone_num_label.Name = "branch_phone_num_label";
            this.branch_phone_num_label.Size = new System.Drawing.Size(103, 17);
            this.branch_phone_num_label.TabIndex = 7;
            this.branch_phone_num_label.Text = "Phone Number";
            // 
            // branch_pCode_label
            // 
            this.branch_pCode_label.AutoSize = true;
            this.branch_pCode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_pCode_label.Location = new System.Drawing.Point(30, 344);
            this.branch_pCode_label.Name = "branch_pCode_label";
            this.branch_pCode_label.Size = new System.Drawing.Size(84, 17);
            this.branch_pCode_label.TabIndex = 6;
            this.branch_pCode_label.Text = "Postal Code";
            // 
            // branch_province_label
            // 
            this.branch_province_label.AutoSize = true;
            this.branch_province_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_province_label.Location = new System.Drawing.Point(30, 288);
            this.branch_province_label.Name = "branch_province_label";
            this.branch_province_label.Size = new System.Drawing.Size(116, 17);
            this.branch_province_label.TabIndex = 5;
            this.branch_province_label.Text = "Province Abbrev.";
            // 
            // branch_city_label
            // 
            this.branch_city_label.AutoSize = true;
            this.branch_city_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_city_label.Location = new System.Drawing.Point(30, 231);
            this.branch_city_label.Name = "branch_city_label";
            this.branch_city_label.Size = new System.Drawing.Size(31, 17);
            this.branch_city_label.TabIndex = 4;
            this.branch_city_label.Text = "City";
            // 
            // branch_street_add2_label
            // 
            this.branch_street_add2_label.AutoSize = true;
            this.branch_street_add2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add2_label.Location = new System.Drawing.Point(30, 177);
            this.branch_street_add2_label.Name = "branch_street_add2_label";
            this.branch_street_add2_label.Size = new System.Drawing.Size(114, 17);
            this.branch_street_add2_label.TabIndex = 3;
            this.branch_street_add2_label.Text = "Street Address 2";
            // 
            // branch_street_add1_label
            // 
            this.branch_street_add1_label.AutoSize = true;
            this.branch_street_add1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_street_add1_label.Location = new System.Drawing.Point(30, 124);
            this.branch_street_add1_label.Name = "branch_street_add1_label";
            this.branch_street_add1_label.Size = new System.Drawing.Size(107, 17);
            this.branch_street_add1_label.TabIndex = 2;
            this.branch_street_add1_label.Text = "Street Addres 1";
            // 
            // branch_dscrip_label
            // 
            this.branch_dscrip_label.AutoSize = true;
            this.branch_dscrip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_dscrip_label.Location = new System.Drawing.Point(30, 73);
            this.branch_dscrip_label.Name = "branch_dscrip_label";
            this.branch_dscrip_label.Size = new System.Drawing.Size(79, 17);
            this.branch_dscrip_label.TabIndex = 1;
            this.branch_dscrip_label.Text = "Description";
            // 
            // branch_id_label
            // 
            this.branch_id_label.AutoSize = true;
            this.branch_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_id_label.Location = new System.Drawing.Point(30, 33);
            this.branch_id_label.Name = "branch_id_label";
            this.branch_id_label.Size = new System.Drawing.Size(70, 17);
            this.branch_id_label.TabIndex = 0;
            this.branch_id_label.Text = "Branch ID";
            this.branch_id_label.Click += new System.EventHandler(this.branch_id_label_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cust_refresh_but);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.cust_del_but);
            this.tabPage3.Controls.Add(this.cust_add_but);
            this.tabPage3.Controls.Add(this.cust_memStat_txt);
            this.tabPage3.Controls.Add(this.cust_drivers_txt);
            this.tabPage3.Controls.Add(this.cust_insurance_txt);
            this.tabPage3.Controls.Add(this.cust_phone_num_txt);
            this.tabPage3.Controls.Add(this.cust_dob_txt);
            this.tabPage3.Controls.Add(this.cust_pCode_txt);
            this.tabPage3.Controls.Add(this.cust_prov_txt);
            this.tabPage3.Controls.Add(this.cust_city_txt);
            this.tabPage3.Controls.Add(this.cust_street_add2_txt);
            this.tabPage3.Controls.Add(this.cust_street_add1_txt);
            this.tabPage3.Controls.Add(this.cust_l_name_txt);
            this.tabPage3.Controls.Add(this.cust_m_name_txt);
            this.tabPage3.Controls.Add(this.cust_f_name_txt);
            this.tabPage3.Controls.Add(this.cust_custID_txt);
            this.tabPage3.Controls.Add(this.cust_memStat_label);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1375, 586);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Customers";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cust_refresh_but
            // 
            this.cust_refresh_but.Location = new System.Drawing.Point(896, 506);
            this.cust_refresh_but.Name = "cust_refresh_but";
            this.cust_refresh_but.Size = new System.Drawing.Size(95, 61);
            this.cust_refresh_but.TabIndex = 31;
            this.cust_refresh_but.Text = "Refresh";
            this.cust_refresh_but.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
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
            this.dataGridView1.Location = new System.Drawing.Point(212, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 470);
            this.dataGridView1.TabIndex = 30;
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
            // Column1
            // 
            this.Column1.HeaderText = "CustomerID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
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
            this.Column13.HeaderText = "Driver License #";
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
            // cust_del_but
            // 
            this.cust_del_but.Location = new System.Drawing.Point(747, 507);
            this.cust_del_but.Name = "cust_del_but";
            this.cust_del_but.Size = new System.Drawing.Size(95, 60);
            this.cust_del_but.TabIndex = 29;
            this.cust_del_but.Text = "Delete";
            this.cust_del_but.UseVisualStyleBackColor = true;
            this.cust_del_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // cust_add_but
            // 
            this.cust_add_but.Location = new System.Drawing.Point(593, 506);
            this.cust_add_but.Name = "cust_add_but";
            this.cust_add_but.Size = new System.Drawing.Size(105, 61);
            this.cust_add_but.TabIndex = 28;
            this.cust_add_but.Text = "Add";
            this.cust_add_but.UseVisualStyleBackColor = true;
            // 
            // cust_memStat_txt
            // 
            this.cust_memStat_txt.Location = new System.Drawing.Point(97, 520);
            this.cust_memStat_txt.Name = "cust_memStat_txt";
            this.cust_memStat_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_memStat_txt.TabIndex = 27;
            // 
            // cust_drivers_txt
            // 
            this.cust_drivers_txt.Location = new System.Drawing.Point(97, 480);
            this.cust_drivers_txt.Name = "cust_drivers_txt";
            this.cust_drivers_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_drivers_txt.TabIndex = 26;
            // 
            // cust_insurance_txt
            // 
            this.cust_insurance_txt.Location = new System.Drawing.Point(97, 444);
            this.cust_insurance_txt.Name = "cust_insurance_txt";
            this.cust_insurance_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_insurance_txt.TabIndex = 25;
            // 
            // cust_phone_num_txt
            // 
            this.cust_phone_num_txt.Location = new System.Drawing.Point(97, 404);
            this.cust_phone_num_txt.Name = "cust_phone_num_txt";
            this.cust_phone_num_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_phone_num_txt.TabIndex = 24;
            // 
            // cust_dob_txt
            // 
            this.cust_dob_txt.Location = new System.Drawing.Point(97, 363);
            this.cust_dob_txt.Name = "cust_dob_txt";
            this.cust_dob_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_dob_txt.TabIndex = 23;
            // 
            // cust_pCode_txt
            // 
            this.cust_pCode_txt.Location = new System.Drawing.Point(97, 323);
            this.cust_pCode_txt.Name = "cust_pCode_txt";
            this.cust_pCode_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_pCode_txt.TabIndex = 22;
            // 
            // cust_prov_txt
            // 
            this.cust_prov_txt.Location = new System.Drawing.Point(97, 284);
            this.cust_prov_txt.Name = "cust_prov_txt";
            this.cust_prov_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_prov_txt.TabIndex = 21;
            // 
            // cust_city_txt
            // 
            this.cust_city_txt.Location = new System.Drawing.Point(97, 246);
            this.cust_city_txt.Name = "cust_city_txt";
            this.cust_city_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_city_txt.TabIndex = 20;
            // 
            // cust_street_add2_txt
            // 
            this.cust_street_add2_txt.Location = new System.Drawing.Point(97, 213);
            this.cust_street_add2_txt.Name = "cust_street_add2_txt";
            this.cust_street_add2_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_street_add2_txt.TabIndex = 19;
            // 
            // cust_street_add1_txt
            // 
            this.cust_street_add1_txt.Location = new System.Drawing.Point(97, 177);
            this.cust_street_add1_txt.Name = "cust_street_add1_txt";
            this.cust_street_add1_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_street_add1_txt.TabIndex = 18;
            // 
            // cust_l_name_txt
            // 
            this.cust_l_name_txt.Location = new System.Drawing.Point(97, 137);
            this.cust_l_name_txt.Name = "cust_l_name_txt";
            this.cust_l_name_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_l_name_txt.TabIndex = 17;
            // 
            // cust_m_name_txt
            // 
            this.cust_m_name_txt.Location = new System.Drawing.Point(97, 101);
            this.cust_m_name_txt.Name = "cust_m_name_txt";
            this.cust_m_name_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_m_name_txt.TabIndex = 16;
            // 
            // cust_f_name_txt
            // 
            this.cust_f_name_txt.Location = new System.Drawing.Point(97, 67);
            this.cust_f_name_txt.Name = "cust_f_name_txt";
            this.cust_f_name_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_f_name_txt.TabIndex = 15;
            // 
            // cust_custID_txt
            // 
            this.cust_custID_txt.Location = new System.Drawing.Point(97, 30);
            this.cust_custID_txt.Name = "cust_custID_txt";
            this.cust_custID_txt.Size = new System.Drawing.Size(109, 20);
            this.cust_custID_txt.TabIndex = 14;
            // 
            // cust_memStat_label
            // 
            this.cust_memStat_label.AutoSize = true;
            this.cust_memStat_label.Location = new System.Drawing.Point(5, 520);
            this.cust_memStat_label.Name = "cust_memStat_label";
            this.cust_memStat_label.Size = new System.Drawing.Size(86, 13);
            this.cust_memStat_label.TabIndex = 13;
            this.cust_memStat_label.Text = "Membership Stat";
            this.cust_memStat_label.Click += new System.EventHandler(this.cust_memStat_label_Click);
            // 
            // cust_drivers_label
            // 
            this.cust_drivers_label.AutoSize = true;
            this.cust_drivers_label.Location = new System.Drawing.Point(5, 480);
            this.cust_drivers_label.Name = "cust_drivers_label";
            this.cust_drivers_label.Size = new System.Drawing.Size(85, 13);
            this.cust_drivers_label.TabIndex = 12;
            this.cust_drivers_label.Text = "Driver License #";
            // 
            // cust_insurance_label
            // 
            this.cust_insurance_label.AutoSize = true;
            this.cust_insurance_label.Location = new System.Drawing.Point(5, 444);
            this.cust_insurance_label.Name = "cust_insurance_label";
            this.cust_insurance_label.Size = new System.Drawing.Size(54, 13);
            this.cust_insurance_label.TabIndex = 11;
            this.cust_insurance_label.Text = "Insurance";
            // 
            // cust_phone_num_label
            // 
            this.cust_phone_num_label.AutoSize = true;
            this.cust_phone_num_label.Location = new System.Drawing.Point(5, 404);
            this.cust_phone_num_label.Name = "cust_phone_num_label";
            this.cust_phone_num_label.Size = new System.Drawing.Size(78, 13);
            this.cust_phone_num_label.TabIndex = 10;
            this.cust_phone_num_label.Text = "Phone Number";
            // 
            // cust_dob_label
            // 
            this.cust_dob_label.AutoSize = true;
            this.cust_dob_label.Location = new System.Drawing.Point(5, 366);
            this.cust_dob_label.Name = "cust_dob_label";
            this.cust_dob_label.Size = new System.Drawing.Size(30, 13);
            this.cust_dob_label.TabIndex = 9;
            this.cust_dob_label.Text = "DOB";
            // 
            // cust_pCode_label
            // 
            this.cust_pCode_label.AutoSize = true;
            this.cust_pCode_label.Location = new System.Drawing.Point(5, 323);
            this.cust_pCode_label.Name = "cust_pCode_label";
            this.cust_pCode_label.Size = new System.Drawing.Size(64, 13);
            this.cust_pCode_label.TabIndex = 8;
            this.cust_pCode_label.Text = "Postal Code";
            // 
            // cust_province_label
            // 
            this.cust_province_label.AutoSize = true;
            this.cust_province_label.Location = new System.Drawing.Point(5, 287);
            this.cust_province_label.Name = "cust_province_label";
            this.cust_province_label.Size = new System.Drawing.Size(49, 13);
            this.cust_province_label.TabIndex = 7;
            this.cust_province_label.Text = "Province";
            // 
            // cust_city_label
            // 
            this.cust_city_label.AutoSize = true;
            this.cust_city_label.Location = new System.Drawing.Point(5, 249);
            this.cust_city_label.Name = "cust_city_label";
            this.cust_city_label.Size = new System.Drawing.Size(24, 13);
            this.cust_city_label.TabIndex = 6;
            this.cust_city_label.Text = "City";
            // 
            // cust_street_add2_label
            // 
            this.cust_street_add2_label.AutoSize = true;
            this.cust_street_add2_label.Location = new System.Drawing.Point(5, 216);
            this.cust_street_add2_label.Name = "cust_street_add2_label";
            this.cust_street_add2_label.Size = new System.Drawing.Size(85, 13);
            this.cust_street_add2_label.TabIndex = 5;
            this.cust_street_add2_label.Text = "Street Address 2";
            // 
            // cust_street_add1_label
            // 
            this.cust_street_add1_label.AutoSize = true;
            this.cust_street_add1_label.Location = new System.Drawing.Point(5, 177);
            this.cust_street_add1_label.Name = "cust_street_add1_label";
            this.cust_street_add1_label.Size = new System.Drawing.Size(85, 13);
            this.cust_street_add1_label.TabIndex = 4;
            this.cust_street_add1_label.Text = "Street Address 1";
            // 
            // cust_last_name_label
            // 
            this.cust_last_name_label.AutoSize = true;
            this.cust_last_name_label.Location = new System.Drawing.Point(5, 140);
            this.cust_last_name_label.Name = "cust_last_name_label";
            this.cust_last_name_label.Size = new System.Drawing.Size(58, 13);
            this.cust_last_name_label.TabIndex = 3;
            this.cust_last_name_label.Text = "Last Name";
            // 
            // cust_mid_name_label
            // 
            this.cust_mid_name_label.AutoSize = true;
            this.cust_mid_name_label.Location = new System.Drawing.Point(5, 104);
            this.cust_mid_name_label.Name = "cust_mid_name_label";
            this.cust_mid_name_label.Size = new System.Drawing.Size(69, 13);
            this.cust_mid_name_label.TabIndex = 2;
            this.cust_mid_name_label.Text = "Middle Name";
            // 
            // cust_f_name_label
            // 
            this.cust_f_name_label.AutoSize = true;
            this.cust_f_name_label.Location = new System.Drawing.Point(5, 67);
            this.cust_f_name_label.Name = "cust_f_name_label";
            this.cust_f_name_label.Size = new System.Drawing.Size(57, 13);
            this.cust_f_name_label.TabIndex = 1;
            this.cust_f_name_label.Text = "First Name";
            // 
            // cust_custID_label
            // 
            this.cust_custID_label.AutoSize = true;
            this.cust_custID_label.Location = new System.Drawing.Point(5, 30);
            this.cust_custID_label.Name = "cust_custID_label";
            this.cust_custID_label.Size = new System.Drawing.Size(65, 13);
            this.cust_custID_label.TabIndex = 0;
            this.cust_custID_label.Text = "Customer ID";
            this.cust_custID_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 637);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cars_test_button
            // 
            this.cars_test_button.Location = new System.Drawing.Point(173, 535);
            this.cars_test_button.Name = "cars_test_button";
            this.cars_test_button.Size = new System.Drawing.Size(75, 23);
            this.cars_test_button.TabIndex = 42;
            this.cars_test_button.Text = "Test Button";
            this.cars_test_button.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.CustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.carsTab.ResumeLayout(false);
            this.carsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branch_view)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label cust_memStat_label;
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
        private System.Windows.Forms.TextBox cust_memStat_txt;
        private System.Windows.Forms.TextBox cust_drivers_txt;
        private System.Windows.Forms.TextBox cust_insurance_txt;
        private System.Windows.Forms.TextBox cust_phone_num_txt;
        private System.Windows.Forms.TextBox cust_dob_txt;
        private System.Windows.Forms.TextBox cust_pCode_txt;
        private System.Windows.Forms.TextBox cust_prov_txt;
        private System.Windows.Forms.TextBox cust_city_txt;
        private System.Windows.Forms.TextBox cust_street_add2_txt;
        private System.Windows.Forms.TextBox cust_street_add1_txt;
        private System.Windows.Forms.TextBox cust_l_name_txt;
        private System.Windows.Forms.TextBox cust_m_name_txt;
        private System.Windows.Forms.TextBox cust_f_name_txt;
        private System.Windows.Forms.TextBox cust_custID_txt;
        private System.Windows.Forms.Button cust_del_but;
        private System.Windows.Forms.Button cust_add_but;
        private System.Windows.Forms.Button cust_refresh_but;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
        private System.Windows.Forms.Label cars_make_label;
        private System.Windows.Forms.Label cars_vin_label;
        private System.Windows.Forms.TextBox cars_vin_txt;
        private System.Windows.Forms.Label cars_branch_id_label;
        private System.Windows.Forms.Label cars_no_seats_label;
        private System.Windows.Forms.Label cars_colour_label;
        private System.Windows.Forms.Label cars_car_type_label;
        private System.Windows.Forms.Label cars_year_label;
        private System.Windows.Forms.Label cars_model_label;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox cars_branch_id_txt;
        private System.Windows.Forms.TextBox cars_no_seats_txt;
        private System.Windows.Forms.TextBox cars_colour_txt;
        private System.Windows.Forms.TextBox cars_year_txt;
        private System.Windows.Forms.TextBox cars_model_txt;
        private System.Windows.Forms.Button btn_add_car;
        private System.Windows.Forms.Button carTypeSBut;
        private System.Windows.Forms.Button addCarTypeBut;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_ID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENTAL_CLASS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAILY_RENTAL_COST_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEEKLY_RENTAL_COST_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTHLY_RENTAL_COST_COL;
        private System.Windows.Forms.Label rentalCostSLabel;
        private System.Windows.Forms.Label rentalClassSLabel;
        private System.Windows.Forms.Label modelSLabel;
        private System.Windows.Forms.Label rentalCostLabel;
        private System.Windows.Forms.Label rentalClassLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox modelS;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.ComboBox rentalCostS;
        private System.Windows.Forms.ComboBox rentalClassS;
        private System.Windows.Forms.Button branch_edit_but;
        private System.Windows.Forms.TextBox branch_search_text_box;
        private System.Windows.Forms.ComboBox branch_search_box;
        private System.Windows.Forms.Label branch_search_label;
        private System.Windows.Forms.Button btn_search_cars;
        private System.Windows.Forms.TextBox cars_insurance_no_txt;
        private System.Windows.Forms.Label cars_insurance_no_label;
        private System.Windows.Forms.Button btn_show_all_cars;
        private System.Windows.Forms.Button btn_delete_cars;
        private System.Windows.Forms.Button btn_edit_car;
        private System.Windows.Forms.TextBox cars_odometer_txt;
        private System.Windows.Forms.Label cars_odometer_label;
        private System.Windows.Forms.Label vin_delete_label;
        private System.Windows.Forms.TextBox vin_delete_txt;
        private System.Windows.Forms.TextBox cars_make_txt;
        private System.Windows.Forms.ComboBox cars_car_type_drop_down;
        private System.Windows.Forms.TextBox cars_search_txt;
        private System.Windows.Forms.ComboBox cars_search_drop_down;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_SEATS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOUR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INSURANCE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODOMETER_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANCH_ID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_TYPE_COL;
        private System.Windows.Forms.Button cars_test_button;
    }
}