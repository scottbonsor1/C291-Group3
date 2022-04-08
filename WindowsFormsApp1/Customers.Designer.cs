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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.customer_id_dropdown = new System.Windows.Forms.ComboBox();
            this.customer_id_label = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.available_vehicles_view = new System.Windows.Forms.DataGridView();
            this.VIN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_SEATS_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOUR_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAR_TYPE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_COST_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.vehicle_type_dropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.return_branch_dropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pickup_branch_dropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.my_rentals_view = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.TID_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_UP_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURN_DATE_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICK_UP_BRANCH_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURN_BRANCH_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_RENT_VAL_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_vehicles_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_rentals_view)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBtn.Location = new System.Drawing.Point(28, 647);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(75, 32);
            this.CustomerBtn.TabIndex = 1;
            this.CustomerBtn.Text = "Logout";
            this.CustomerBtn.UseVisualStyleBackColor = true;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1343, 613);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.customer_id_dropdown);
            this.tabPage1.Controls.Add(this.customer_id_label);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.available_vehicles_view);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.vehicle_type_dropdown);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.return_branch_dropdown);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pickup_branch_dropdown);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1335, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rent Vehicle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.comboBox6);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox5);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.dateTimePicker4);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.my_rentals_view);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1335, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Rentals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Available Vehicles";
            // 
            // customer_id_dropdown
            // 
            this.customer_id_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_dropdown.FormattingEnabled = true;
            this.customer_id_dropdown.Location = new System.Drawing.Point(163, 24);
            this.customer_id_dropdown.Name = "customer_id_dropdown";
            this.customer_id_dropdown.Size = new System.Drawing.Size(115, 28);
            this.customer_id_dropdown.TabIndex = 40;
            // 
            // customer_id_label
            // 
            this.customer_id_label.AutoSize = true;
            this.customer_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_label.Location = new System.Drawing.Point(17, 27);
            this.customer_id_label.Name = "customer_id_label";
            this.customer_id_label.Size = new System.Drawing.Size(110, 20);
            this.customer_id_label.TabIndex = 39;
            this.customer_id_label.Text = "Customer ID";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(54, 427);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(259, 28);
            this.comboBox4.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
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
            this.TOTAL_COST_COL});
            this.available_vehicles_view.Location = new System.Drawing.Point(451, 36);
            this.available_vehicles_view.Name = "available_vehicles_view";
            this.available_vehicles_view.RowHeadersWidth = 51;
            this.available_vehicles_view.Size = new System.Drawing.Size(865, 524);
            this.available_vehicles_view.TabIndex = 36;
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
            // TOTAL_COST_COL
            // 
            this.TOTAL_COST_COL.HeaderText = "Total Cost";
            this.TOTAL_COST_COL.Name = "TOTAL_COST_COL";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 33);
            this.button2.TabIndex = 35;
            this.button2.Text = "Book Now";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // vehicle_type_dropdown
            // 
            this.vehicle_type_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_type_dropdown.FormattingEnabled = true;
            this.vehicle_type_dropdown.Location = new System.Drawing.Point(163, 179);
            this.vehicle_type_dropdown.Name = "vehicle_type_dropdown";
            this.vehicle_type_dropdown.Size = new System.Drawing.Size(259, 28);
            this.vehicle_type_dropdown.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Vehicle Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 33);
            this.button1.TabIndex = 32;
            this.button1.Text = "Search Availability";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // return_branch_dropdown
            // 
            this.return_branch_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_branch_dropdown.FormattingEnabled = true;
            this.return_branch_dropdown.Location = new System.Drawing.Point(163, 271);
            this.return_branch_dropdown.Name = "return_branch_dropdown";
            this.return_branch_dropdown.Size = new System.Drawing.Size(259, 28);
            this.return_branch_dropdown.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Return Branch";
            // 
            // pickup_branch_dropdown
            // 
            this.pickup_branch_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickup_branch_dropdown.FormattingEnabled = true;
            this.pickup_branch_dropdown.Location = new System.Drawing.Point(163, 132);
            this.pickup_branch_dropdown.Name = "pickup_branch_dropdown";
            this.pickup_branch_dropdown.Size = new System.Drawing.Size(259, 28);
            this.pickup_branch_dropdown.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pick-up Branch";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(163, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pick-up Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pick-up Date";
            // 
            // my_rentals_view
            // 
            this.my_rentals_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.my_rentals_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_rentals_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID_COL,
            this.PICK_UP_DATE,
            this.RETURN_DATE_COL,
            this.PICK_UP_BRANCH_COL,
            this.RETURN_BRANCH_COL,
            this.TOTAL_RENT_VAL_COL});
            this.my_rentals_view.Location = new System.Drawing.Point(468, 21);
            this.my_rentals_view.Name = "my_rentals_view";
            this.my_rentals_view.RowHeadersWidth = 51;
            this.my_rentals_view.Size = new System.Drawing.Size(847, 509);
            this.my_rentals_view.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Customer ID";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(468, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 33);
            this.button3.TabIndex = 43;
            this.button3.Text = "View All";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(176, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 28);
            this.comboBox2.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "Vehicle Type";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(176, 254);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(259, 28);
            this.comboBox3.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 50;
            this.label10.Text = "Return Branch";
            // 
            // comboBox5
            // 
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(176, 115);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(259, 28);
            this.comboBox5.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Pick-up Branch";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(176, 209);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker3.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Pick-up Date";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Location = new System.Drawing.Point(176, 70);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(259, 26);
            this.dateTimePicker4.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "Pick-up Date";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(91, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 33);
            this.button4.TabIndex = 54;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(74, 400);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(259, 28);
            this.comboBox6.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 20);
            this.label14.TabIndex = 55;
            this.label14.Text = "Select Transaction ID";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(101, 434);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 33);
            this.button5.TabIndex = 57;
            this.button5.Text = "Cancel Rental";
            this.button5.UseVisualStyleBackColor = true;
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
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1379, 704);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CustomerBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rentals";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.available_vehicles_view)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView available_vehicles_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_SEATS_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOUR_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAR_TYPE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_COST_COL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox vehicle_type_dropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox return_branch_dropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pickup_branch_dropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView my_rentals_view;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_UP_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURN_DATE_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICK_UP_BRANCH_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURN_BRANCH_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_RENT_VAL_COL;
    }
}