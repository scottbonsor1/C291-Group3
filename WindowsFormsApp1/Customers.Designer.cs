namespace WindowsFormsApp1
{
    partial class Rentals
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.transaction_id_txt = new System.Windows.Forms.TextBox();
            this.TID_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customer_id_dropdown = new System.Windows.Forms.ComboBox();
            this.customer_id_label = new System.Windows.Forms.Label();
            this.VIN_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.available_vehicles_view = new System.Windows.Forms.DataGridView();
            this.VIN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_SEATS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOUR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_TYPE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekly_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monthly_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookButton = new System.Windows.Forms.Button();
            this.vehicle_type_dropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.return_branch_dropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pickup_branch_dropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cancel_rental_box = new System.Windows.Forms.TextBox();
            this.search_id_box = new System.Windows.Forms.TextBox();
            this.cancel_rental_btn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.search_by_id_btn = new System.Windows.Forms.Button();
            this.view_all_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.my_rentals_view = new System.Windows.Forms.DataGridView();
            this.TID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_UP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURN_DATE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_UP_BRANCH_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURN_BRANCH_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_RENT_VAL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.late_tid_box = new System.Windows.Forms.TextBox();
            this.add_late_fee_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_vehicles_view)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_rentals_view)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(37, 796);
            this.CustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(100, 39);
            this.CustomerBtn.TabIndex = 1;
            this.CustomerBtn.Text = "Logout";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(32, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1791, 754);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.transaction_id_txt);
            this.tabPage1.Controls.Add(this.TID_label);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.customer_id_dropdown);
            this.tabPage1.Controls.Add(this.customer_id_label);
            this.tabPage1.Controls.Add(this.VIN_box);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.available_vehicles_view);
            this.tabPage1.Controls.Add(this.bookButton);
            this.tabPage1.Controls.Add(this.vehicle_type_dropdown);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.return_branch_dropdown);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pickup_branch_dropdown);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1783, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rent Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // transaction_id_txt
            // 
            this.transaction_id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_id_txt.Location = new System.Drawing.Point(251, 592);
            this.transaction_id_txt.Margin = new System.Windows.Forms.Padding(4);
            this.transaction_id_txt.Name = "transaction_id_txt";
            this.transaction_id_txt.Size = new System.Drawing.Size(201, 30);
            this.transaction_id_txt.TabIndex = 43;
            // 
            // TID_label
            // 
            this.TID_label.AutoSize = true;
            this.TID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TID_label.Location = new System.Drawing.Point(67, 595);
            this.TID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TID_label.Name = "TID_label";
            this.TID_label.Size = new System.Drawing.Size(153, 25);
            this.TID_label.TabIndex = 42;
            this.TID_label.Text = "Transaction ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Available Vehicles";
            // 
            // customer_id_dropdown
            // 
            this.customer_id_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customer_id_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_dropdown.FormattingEnabled = true;
            this.customer_id_dropdown.Location = new System.Drawing.Point(217, 30);
            this.customer_id_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.customer_id_dropdown.Name = "customer_id_dropdown";
            this.customer_id_dropdown.Size = new System.Drawing.Size(152, 33);
            this.customer_id_dropdown.TabIndex = 40;
            // 
            // customer_id_label
            // 
            this.customer_id_label.AutoSize = true;
            this.customer_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_label.Location = new System.Drawing.Point(23, 33);
            this.customer_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customer_id_label.Name = "customer_id_label";
            this.customer_id_label.Size = new System.Drawing.Size(132, 25);
            this.customer_id_label.TabIndex = 39;
            this.customer_id_label.Text = "Customer ID";
            // 
            // VIN_box
            // 
            this.VIN_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VIN_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIN_box.FormattingEnabled = true;
            this.VIN_box.Location = new System.Drawing.Point(72, 526);
            this.VIN_box.Margin = new System.Windows.Forms.Padding(4);
            this.VIN_box.Name = "VIN_box";
            this.VIN_box.Size = new System.Drawing.Size(344, 33);
            this.VIN_box.TabIndex = 38;
            this.VIN_box.SelectedIndexChanged += new System.EventHandler(this.VIN_box_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Select Vehicle (VIN)";
            // 
            // available_vehicles_view
            // 
            this.available_vehicles_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.available_vehicles_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available_vehicles_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VIN_COL,
            this.MAKE_COL,
            this.MODEL_COL,
            this.YEAR_COL,
            this.NO_SEATS_COL,
            this.COLOUR_COL,
            this.CAR_TYPE_COL,
            this.Daily_Cost,
            this.Weekly_Cost,
            this.Monthly_Cost});
            this.available_vehicles_view.Location = new System.Drawing.Point(601, 44);
            this.available_vehicles_view.Margin = new System.Windows.Forms.Padding(4);
            this.available_vehicles_view.Name = "available_vehicles_view";
            this.available_vehicles_view.RowHeadersWidth = 51;
            this.available_vehicles_view.Size = new System.Drawing.Size(1153, 645);
            this.available_vehicles_view.TabIndex = 36;
            this.available_vehicles_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_vehicles_view_CellContentClick);
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
            // CAR_TYPE_COL
            // 
            this.CAR_TYPE_COL.HeaderText = "Car Type";
            this.CAR_TYPE_COL.MinimumWidth = 6;
            this.CAR_TYPE_COL.Name = "CAR_TYPE_COL";
            this.CAR_TYPE_COL.ReadOnly = true;
            // 
            // Daily_Cost
            // 
            this.Daily_Cost.HeaderText = "Daily Cost";
            this.Daily_Cost.MinimumWidth = 6;
            this.Daily_Cost.Name = "Daily_Cost";
            // 
            // Weekly_Cost
            // 
            this.Weekly_Cost.HeaderText = "Weekly Cost";
            this.Weekly_Cost.MinimumWidth = 6;
            this.Weekly_Cost.Name = "Weekly_Cost";
            // 
            // Monthly_Cost
            // 
            this.Monthly_Cost.HeaderText = "Monthly Cost";
            this.Monthly_Cost.MinimumWidth = 6;
            this.Monthly_Cost.Name = "Monthly_Cost";
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookButton.Location = new System.Drawing.Point(154, 657);
            this.bookButton.Margin = new System.Windows.Forms.Padding(4);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(179, 41);
            this.bookButton.TabIndex = 35;
            this.bookButton.Text = "Book Now";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // vehicle_type_dropdown
            // 
            this.vehicle_type_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicle_type_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_type_dropdown.FormattingEnabled = true;
            this.vehicle_type_dropdown.Location = new System.Drawing.Point(217, 220);
            this.vehicle_type_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.vehicle_type_dropdown.Name = "vehicle_type_dropdown";
            this.vehicle_type_dropdown.Size = new System.Drawing.Size(344, 33);
            this.vehicle_type_dropdown.TabIndex = 34;
            this.vehicle_type_dropdown.SelectedIndexChanged += new System.EventHandler(this.vehicle_type_dropdown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Vehicle Type";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(104, 412);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(267, 41);
            this.searchButton.TabIndex = 32;
            this.searchButton.Text = "Search Availability";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // return_branch_dropdown
            // 
            this.return_branch_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.return_branch_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_branch_dropdown.FormattingEnabled = true;
            this.return_branch_dropdown.Location = new System.Drawing.Point(217, 334);
            this.return_branch_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.return_branch_dropdown.Name = "return_branch_dropdown";
            this.return_branch_dropdown.Size = new System.Drawing.Size(344, 33);
            this.return_branch_dropdown.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Return Branch";
            // 
            // pickup_branch_dropdown
            // 
            this.pickup_branch_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickup_branch_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickup_branch_dropdown.FormattingEnabled = true;
            this.pickup_branch_dropdown.Location = new System.Drawing.Point(217, 162);
            this.pickup_branch_dropdown.Margin = new System.Windows.Forms.Padding(4);
            this.pickup_branch_dropdown.Name = "pickup_branch_dropdown";
            this.pickup_branch_dropdown.Size = new System.Drawing.Size(344, 33);
            this.pickup_branch_dropdown.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pick-up Branch";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 278);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(344, 30);
            this.dateTimePicker2.TabIndex = 27;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Return Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 107);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 4, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 30);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pick-up Date";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.late_tid_box);
            this.tabPage2.Controls.Add(this.add_late_fee_btn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cancel_rental_box);
            this.tabPage2.Controls.Add(this.search_id_box);
            this.tabPage2.Controls.Add(this.cancel_rental_btn);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.search_by_id_btn);
            this.tabPage2.Controls.Add(this.view_all_btn);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.my_rentals_view);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1783, 725);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Rentals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cancel_rental_box
            // 
            this.cancel_rental_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_rental_box.Location = new System.Drawing.Point(329, 601);
            this.cancel_rental_box.Name = "cancel_rental_box";
            this.cancel_rental_box.Size = new System.Drawing.Size(105, 30);
            this.cancel_rental_box.TabIndex = 59;
            // 
            // search_id_box
            // 
            this.search_id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_id_box.Location = new System.Drawing.Point(327, 229);
            this.search_id_box.Name = "search_id_box";
            this.search_id_box.Size = new System.Drawing.Size(105, 30);
            this.search_id_box.TabIndex = 58;
            // 
            // cancel_rental_btn
            // 
            this.cancel_rental_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_rental_btn.Location = new System.Drawing.Point(137, 647);
            this.cancel_rental_btn.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_rental_btn.Name = "cancel_rental_btn";
            this.cancel_rental_btn.Size = new System.Drawing.Size(267, 41);
            this.cancel_rental_btn.TabIndex = 57;
            this.cancel_rental_btn.Text = "Cancel Rental";
            this.cancel_rental_btn.UseVisualStyleBackColor = true;
            this.cancel_rental_btn.Click += new System.EventHandler(this.cancel_rental_btn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(58, 604);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "Cancel Transaction ID:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // search_by_id_btn
            // 
            this.search_by_id_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_id_btn.Location = new System.Drawing.Point(121, 281);
            this.search_by_id_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_by_id_btn.Name = "search_by_id_btn";
            this.search_by_id_btn.Size = new System.Drawing.Size(267, 41);
            this.search_by_id_btn.TabIndex = 54;
            this.search_by_id_btn.Text = "Search";
            this.search_by_id_btn.UseVisualStyleBackColor = true;
            this.search_by_id_btn.Click += new System.EventHandler(this.search_by_id_btn_Click);
            // 
            // view_all_btn
            // 
            this.view_all_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all_btn.Location = new System.Drawing.Point(121, 93);
            this.view_all_btn.Margin = new System.Windows.Forms.Padding(4);
            this.view_all_btn.Name = "view_all_btn";
            this.view_all_btn.Size = new System.Drawing.Size(267, 81);
            this.view_all_btn.TabIndex = 43;
            this.view_all_btn.Text = "View All Rentals";
            this.view_all_btn.UseVisualStyleBackColor = true;
            this.view_all_btn.Click += new System.EventHandler(this.view_all_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Search by Customer ID:";
            // 
            // my_rentals_view
            // 
            this.my_rentals_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.my_rentals_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_rentals_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID_COL,
            this.PICK_UP_DATE,
            this.RETURN_DATE_COL,
            this.Customer_ID,
            this.VIN,
            this.PICK_UP_BRANCH_COL,
            this.RETURN_BRANCH_COL,
            this.TOTAL_RENT_VAL_COL});
            this.my_rentals_view.Location = new System.Drawing.Point(624, 26);
            this.my_rentals_view.Margin = new System.Windows.Forms.Padding(4);
            this.my_rentals_view.Name = "my_rentals_view";
            this.my_rentals_view.RowHeadersWidth = 51;
            this.my_rentals_view.Size = new System.Drawing.Size(1129, 626);
            this.my_rentals_view.TabIndex = 37;
            // 
            // TID_COL
            // 
            this.TID_COL.HeaderText = "TID";
            this.TID_COL.MinimumWidth = 6;
            this.TID_COL.Name = "TID_COL";
            this.TID_COL.ReadOnly = true;
            // 
            // PICK_UP_DATE
            // 
            this.PICK_UP_DATE.HeaderText = "Pick-up Date";
            this.PICK_UP_DATE.MinimumWidth = 6;
            this.PICK_UP_DATE.Name = "PICK_UP_DATE";
            this.PICK_UP_DATE.ReadOnly = true;
            // 
            // RETURN_DATE_COL
            // 
            this.RETURN_DATE_COL.HeaderText = "Return Date";
            this.RETURN_DATE_COL.MinimumWidth = 6;
            this.RETURN_DATE_COL.Name = "RETURN_DATE_COL";
            this.RETURN_DATE_COL.ReadOnly = true;
            // 
            // Customer_ID
            // 
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.MinimumWidth = 6;
            this.Customer_ID.Name = "Customer_ID";
            // 
            // VIN
            // 
            this.VIN.HeaderText = "VIN";
            this.VIN.MinimumWidth = 6;
            this.VIN.Name = "VIN";
            // 
            // PICK_UP_BRANCH_COL
            // 
            this.PICK_UP_BRANCH_COL.HeaderText = "Pick-up Branch";
            this.PICK_UP_BRANCH_COL.MinimumWidth = 6;
            this.PICK_UP_BRANCH_COL.Name = "PICK_UP_BRANCH_COL";
            this.PICK_UP_BRANCH_COL.ReadOnly = true;
            // 
            // RETURN_BRANCH_COL
            // 
            this.RETURN_BRANCH_COL.HeaderText = "Return Branch";
            this.RETURN_BRANCH_COL.MinimumWidth = 6;
            this.RETURN_BRANCH_COL.Name = "RETURN_BRANCH_COL";
            this.RETURN_BRANCH_COL.ReadOnly = true;
            // 
            // TOTAL_RENT_VAL_COL
            // 
            this.TOTAL_RENT_VAL_COL.HeaderText = "Total Rent Value";
            this.TOTAL_RENT_VAL_COL.MinimumWidth = 6;
            this.TOTAL_RENT_VAL_COL.Name = "TOTAL_RENT_VAL_COL";
            this.TOTAL_RENT_VAL_COL.ReadOnly = true;
            // 
            // late_tid_box
            // 
            this.late_tid_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.late_tid_box.Location = new System.Drawing.Point(327, 401);
            this.late_tid_box.Name = "late_tid_box";
            this.late_tid_box.Size = new System.Drawing.Size(105, 30);
            this.late_tid_box.TabIndex = 62;
            // 
            // add_late_fee_btn
            // 
            this.add_late_fee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_late_fee_btn.Location = new System.Drawing.Point(121, 453);
            this.add_late_fee_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_late_fee_btn.Name = "add_late_fee_btn";
            this.add_late_fee_btn.Size = new System.Drawing.Size(267, 41);
            this.add_late_fee_btn.TabIndex = 61;
            this.add_late_fee_btn.Text = "Add Late Fee";
            this.add_late_fee_btn.UseVisualStyleBackColor = true;
            this.add_late_fee_btn.Click += new System.EventHandler(this.add_late_fee_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 404);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Mark Transaction as Late:";
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1839, 866);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rentals";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_vehicles_view)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_rentals_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox customer_id_dropdown;
        private System.Windows.Forms.Label customer_id_label;
        private System.Windows.Forms.ComboBox VIN_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView available_vehicles_view;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.ComboBox vehicle_type_dropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox return_branch_dropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pickup_branch_dropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button search_by_id_btn;
        private System.Windows.Forms.Button view_all_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView my_rentals_view;
        private System.Windows.Forms.Button cancel_rental_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_SEATS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOUR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_TYPE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daily_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekly_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monthly_Cost;
        private System.Windows.Forms.TextBox transaction_id_txt;
        private System.Windows.Forms.Label TID_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_UP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURN_DATE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_UP_BRANCH_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURN_BRANCH_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_RENT_VAL_COL;
        private System.Windows.Forms.TextBox search_id_box;
        private System.Windows.Forms.TextBox cancel_rental_box;
        private System.Windows.Forms.TextBox late_tid_box;
        private System.Windows.Forms.Button add_late_fee_btn;
        private System.Windows.Forms.Label label9;
    }
}