﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


/**
 * This is the Employee form. It handles all the actions an Employee can perform in the application.
 * It allows Employees to add cars, car types, branches, and customers, and allows them to view, search,
 * and delete the above, in addition to rental transactions.
 * 
 */

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        //global vars
        //SQL connection variables
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlCommand myCommand2;
        public SqlDataReader myReader;
        public SqlDataReader myReader2;
        public SqlDataReader myReader3;

        //fee constants
        public Double LATE_FEE = 49.99; //this is the added cost for late rentals
        public Double DIFF_BRANCH_COST = 35.50; //this is the fee for returning to a different branch

        //used for checking size of inputed rent values
        double numLimit = 1000000;
        public Employee()
        {
            InitializeComponent();
            

            //Change the server here for your guys' own servers
            String connectionString = "Server = DESKTOP-D7J3O0B; Database = 291_RentalDatabase; Trusted_Connection = yes; MultipleActiveResultSets=True;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            //open connection to local machine
            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand2 = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
                myCommand2.Connection = myConnection;

                //populate tabs
                refreshCarType();
                refreshBranch();
                //Populate Cars tab combo boxes with available Branch_ID's, Car_Type_ID's and VIN's
                Fill_Cars_BranchID();
                Fill_Cars_Car_Type_ID();
                Fill_Cars_Delete_VIN();
                
                refresh_customer();

                update_car_branch();

                refresh_cars();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to database, terminating application...", "Error");
                this.Close();
            }

            

        }
        
        /**
         * CustomerBtn_Click allows the logged in employee to leave the employee screen and return to the
         * login screen.
         */
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report f1 = new Report();
            f1.ShowDialog();
            this.Close();
        }

        //**********************
        //Start of Car Types Tab
        //**********************

        //refreshCarType (re)populates the data view with entries from the Car_Type database table
        private void refreshCarType()
        {
            //select all rows in Car_Type
            myCommand.CommandText = "select * from Car_Type";

            try
            { 
                //execute query and iterate over all columns
                myReader = myCommand.ExecuteReader();

                carTypeView.Rows.Clear();
                while (myReader.Read())
                {
                    carTypeView.Rows.Add(myReader["Car_Type_ID"].ToString(), myReader["Description"].ToString(), myReader["Daily_Rate"], myReader["Weekly_Rate"], myReader["Monthly_Rate"]);
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car types from database", "Error");
            }
        }

        //add new Car Type to Car_Type database table
        private void addCarTypeButClick(object sender, EventArgs e)
        {

            //check required field length
            if (modelID.Text.Length > 0 && typeDesc.Text.Length > 0 && dRent.Text.Length > 0
                && wRent.Text.Length > 0 && mRent.Text.Length > 0)
            {
                try
                {
                    //Used to check if rent values exceed DB capacity (precision -2 for decimal vals)
                    if(double.Parse(dRent.Text) >= numLimit || double.Parse(wRent.Text) >= numLimit || double.Parse(mRent.Text) >= numLimit) {
                        MessageBox.Show("Rent value entered too large, try a smaller value", "Error");
                        return;
                    }

                    //insert query
                    myCommand.CommandText = "insert into Car_Type values (" + modelID.Text + ",' " +
                        typeDesc.Text + "',' " + dRent.Text + "',' " + wRent.Text + "',' " +
                        mRent.Text + "')";

                    myCommand.ExecuteNonQuery();
                    refreshCarType();
                    Fill_Cars_Car_Type_ID(); // Update Car Type ID dropdown box in Cars tab with new Car type
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Error inserting data into database", "Error");
                }
            }
            else
            {
                MessageBox.Show("Required Fields Missing or Incorrect");
            }

        }

        //delete car type from Car_Type database table
        private void delCarTypeButClick(object sender, EventArgs e)
        {

            //check field length
            if (modelID.Text.Length > 0 )
            {
                //delete query
                myCommand.CommandText = "delete from Car_Type where Car_Type_ID = " + modelID.Text;

                try
                {
                    var message = "Deleting Car Type with ID " + modelID.Text +" from database";
                    MessageBox.Show("message");
                    myCommand.ExecuteNonQuery();
                    refreshCarType();
                    Fill_Cars_Car_Type_ID();    // Update Car Type ID dropdown box in Cars tab with removed branch.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting Car Type from database", "Error");
                }
            }
            else
            {
                MessageBox.Show("No Valid Car Type ID to Delete Entered");
            }

        }

        //edit car type from Car_Type database table
        private void editCarTypeButClick(object sender, EventArgs e)
        {
            //check if required fields are filled
            if (modelID.Text.Length > 0)
            {
                //used to check whther a comma should be placed in string
                int check = 0;
                myCommand.CommandText = "update Car_Type set ";

                //Add appropriate fields to be edited into query
                //For all but first and last, check if check == 1 to see if a comma should be place in query
                if (typeDesc.Text.Length > 0)
                {
                    myCommand.CommandText += "Description = '" + typeDesc.Text + "'";
                    check = 1;
                }
                if (dRent.Text.Length > 0)
                {
                    if (double.Parse(dRent.Text) >= numLimit)
                    {
                        MessageBox.Show("Rent value entered too large, try a smaller value", "Error");
                        return;
                    }

                    if (check == 1) { myCommand.CommandText += ", ";  }
                    myCommand.CommandText += "Daily_Rate = " + dRent.Text;
                    check = 1;
                }
                if (wRent.Text.Length > 0)
                {
                    if (double.Parse(wRent.Text) >= numLimit)
                    {
                        MessageBox.Show("Rent value entered too large, try a smaller value", "Error");
                        return;
                    }

                    if (check == 1) { myCommand.CommandText += ", "; }
                    myCommand.CommandText += "Weekly_Rate = " + wRent.Text;
                    check = 1;
                }
                if (mRent.Text.Length > 0)
                {
                    if(double.Parse(mRent.Text) >= numLimit)
                    {
                        MessageBox.Show("Rent value entered too large, try a smaller value", "Error");
                        return;
                    }

                    if (check == 1) { myCommand.CommandText += ", "; }
                    myCommand.CommandText += "Monthly_Rate = " + mRent.Text;
                    check = 1;
                }

                myCommand.CommandText += " where Car_Type_ID = " + modelID.Text + ";";

                //no fields entered
                if (check == 0)
                {
                    MessageBox.Show("No edit fields entered");
                }

                else
                {
                    try
                    {
                        var message = "Editing car type with ID " + modelID.Text;
                        MessageBox.Show(message);
                        myCommand.ExecuteNonQuery();
                        refreshCarType();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Invalid value(s) entered");
                    }
                }
            }
        }


        //search for car types given specified criteria
        private void searchCarTypeButClick(object sender, EventArgs e)
        {

            //used to check if multiple fields have been selected, requiring a comma in the query
            int check = 0;
            myCommand.CommandText = "select * from Car_Type where ";

            //find fields to search with
            //for all but the first and last, if check == 1 add a comma to the query
            if (modelS.Text.Length > 0)
            {
                myCommand.CommandText += "Car_Type_ID = " + modelS.Text;
                check = 1;
            }

            if (descS.Text.Length > 0)
            {
                if(check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Description = '" + descS.Text + "'";
                check = 1;
            }

            if (dCostS1.Text.Length > 0)
            {
                if (check ==1 ) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Daily_Rate >= " + dCostS1.Text;
                check = 1;
            }

            if (dCostS2.Text.Length > 0)
            {
                if (check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Daily_Rate <= " + dCostS2.Text;
                check = 1;
            }

            if (wCostS1.Text.Length > 0)
            {
                if (check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Weekly_Rate >= " + wCostS1.Text;
                check = 1;
            }

            if (wCostS2.Text.Length > 0)
            {
                if (check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Weekly_Rate <= " + wCostS2.Text;
                check = 1;
            }

            if (mCostS1.Text.Length > 0)
            {
                if (check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Monthly_Rate >= " + mCostS1.Text;
                check = 1;
            }

            if (mCostS2.Text.Length > 0)
            {
                if (check == 1) { myCommand.CommandText += " and "; }
                myCommand.CommandText += "Monthly_Rate <= " + mCostS2.Text;
                check = 1;
            }

            myCommand.CommandText += ";";

            if (check == 0)
            {
                refreshCarType();
            }

            else
            {
                try
                {

                    //insert query data into datagrid
                    myReader = myCommand.ExecuteReader();
                    carTypeView.Rows.Clear();
                    while (myReader.Read())
                    {
                        carTypeView.Rows.Add(myReader["Car_Type_ID"].ToString(), myReader["Description"].ToString(), myReader["Daily_Rate"].ToString(), myReader["Weekly_Rate"].ToString(), myReader["Monthly_Rate"].ToString());
                    }

                    myReader.Close();

                }

                catch (Exception) // e2)
                {
                    MessageBox.Show("Invalid value(s) entered");
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cust_memStat_label_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void carsTab_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void vin_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void fuelTypeSLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //**********************
        //Start of Branch Tab
        //**********************

        //(re)populate branch dataGrid object
        void refreshBranch()
        {
            myCommand.CommandText = "select * from Branch";

            try
            {
                myReader = myCommand.ExecuteReader();

                branch_view.Rows.Clear();
                while (myReader.Read())
                {
                    branch_view.Rows.Add(myReader["BID"].ToString(), myReader["Description"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Phone_Number"].ToString());
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while grabbing data from database", "Error");
            }
        }

        //button click function for refreshing Branch tab
        private void branch_refresh_but_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Branch";

            try
            {
                myReader = myCommand.ExecuteReader();

                branch_view.Rows.Clear();
                while (myReader.Read())
                {
                    branch_view.Rows.Add(myReader["BID"].ToString(), myReader["Description"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Phone_Number"].ToString());
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while grabbing data from database", "Error");
            }
        }

        private void branch_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void branch_id_label_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        //add new branch entry in database using inputted data
        private void branch_add_but_Click(object sender, EventArgs e)
        {
            //check required fields are filled
            if (branch_id_txt.Text.Length > 0 && branch_descrip_txt.Text.Length > 0 && branch_street_add1_txt.Text.Length > 0 &&
                branch_city_txt.Text.Length > 0 && branch_province_txt.Text.Length > 0 &&
                branch_pCode_txt.Text.Length > 0 && branch_phone_num_txt.Text.Length > 0)
            {
                try
                {
                    myCommand.CommandText = "insert into Branch values (" + branch_id_txt.Text + ",'" +
                        branch_descrip_txt.Text + "','" + branch_street_add1_txt.Text + "','" +
                        branch_street_add2_txt.Text + "','" + branch_city_txt.Text + "','" + branch_province_txt.Text + "','" +
                        branch_pCode_txt.Text + "','" + branch_phone_num_txt.Text + "')";

                    myCommand.ExecuteNonQuery();
                    branch_refresh_but.PerformClick();
                    Fill_Cars_BranchID();   // Update Branch ID dropdown box in Cars tab with new branch available.
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Error adding new Branch instance", "Error");
                }
            }
            else
            {
                MessageBox.Show("Required Fields Missing or Incorrect");
            }
        }

        //edit a given branch entry with inputted information
        private void branch_edit_but_Click(object sender, EventArgs e)
        {
            //used to check if a comma is needed in the query
            int add = 0;
            try
            {
                myCommand.CommandText = "update Branch set ";

                //for all but the first and last, if add == 1, add a comma to the query
                if (branch_descrip_txt.Text.Length > 0)
                {
                    myCommand.CommandText += "Description = '" + branch_descrip_txt.Text + "'";
                    add = 1;
                }
                if (branch_street_add1_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Street_Address1 = '" + branch_street_add1_txt.Text + "'";
                    add = 1;
                }
                if (branch_street_add2_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Street_Address2 = '" + branch_street_add2_txt.Text + "'";
                    add = 1;
                }
                if (branch_city_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "City = '" + branch_city_txt.Text + "'";
                    add = 1;
                }
                if (branch_province_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Province = '" + branch_province_txt.Text + "'";
                    add = 1;
                }
                if (branch_pCode_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Postal_Code = '" + branch_pCode_txt.Text + "'";
                    add = 1;
                }
                if (branch_phone_num_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Phone_Number = '" + branch_phone_num_txt.Text + "'";
                    add = 1;
                }

                myCommand.CommandText += "where BID = " + branch_id_txt.Text + ";";

                if (add == 1 && branch_id_txt.Text.Length > 0)
                {

                    var message = "Editing branch with ID " + branch_id_txt.Text;
                    MessageBox.Show(message);

                    myCommand.ExecuteNonQuery();
                    branch_refresh_but.PerformClick();
                }
                else
                {
                    MessageBox.Show("No Fields Edited");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error occured while editing branch", "Error");
            }
        }

        //search for branch given user inputted information
        private void branch_search_but_Click(object sender, EventArgs e)
        {

            //used to check for invalid fields
            int invalid = 0;
            int bid = 0;
            int result;
            myCommand.CommandText = "select * from Branch where ";

            if (branch_search_box.Text.Equals("Branch ID"))
            {
                myCommand.CommandText += "BID = ";
                bid = 1;
                if (branch_search_text_box.Text.Length > 0 && !int.TryParse(branch_search_text_box.Text.ToString(), out result)) //tests if it is an int
                {
                    invalid = 2;
                    MessageBox.Show("BID Must be Integer");
                }
            }
            else if (branch_search_box.Text.Equals("Description"))
            {
                myCommand.CommandText += "Description = ";
            }
            else if (branch_search_box.Text.Equals("Street Address 1"))
            {
                myCommand.CommandText += "Street_Address1 = ";
            }
            else if (branch_search_box.Text.Equals("Street Address 2"))
            {
                myCommand.CommandText += "Street_Address2 = ";
            }
            else if (branch_search_box.Text.Equals("City"))
            {
                myCommand.CommandText += "City = ";
            }
            else if (branch_search_box.Text.Equals("Province"))
            {
                myCommand.CommandText += "Province = ";
            }
            else if (branch_search_box.Text.Equals("Postal Code"))
            {
                myCommand.CommandText += "Postal_Code = ";
            }
            else if (branch_search_box.Text.Equals("Phone Number"))
            {
                myCommand.CommandText += "Phone_Number = ";
            }
            else
            {
                MessageBox.Show("No Search Field Selected");
                invalid = 1;
            }

            if (branch_search_text_box.Text.Length > 0 && invalid == 0)
            {
                if (bid != 1)
                {
                    myCommand.CommandText += "'" + branch_search_text_box.Text + "';";
                }
                else
                {
                    myCommand.CommandText += branch_search_text_box.Text + ";";
                }
                try
                {
                    
                    myReader = myCommand.ExecuteReader();
                    branch_view.Rows.Clear();
                    while (myReader.Read())
                    {
                        branch_view.Rows.Add(myReader["BID"].ToString(), myReader["Description"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Phone_Number"].ToString());
                    }

                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while searching", "Error");
                }

            }
            else
            {
                if (invalid != 2)
                {
                    MessageBox.Show("No Search Text Entered");
                }
            }
        }

        // delete branch from database table
        private void branch_del_but_Click(object sender, EventArgs e)
        {
            int result;
            
            if (branch_id_LU_txt.Text.Length > 0 && !int.TryParse(branch_search_text_box.Text.ToString(), out result)) //tests if it is an int
            {
                myCommand.CommandText = "delete from Branch where BID = " + branch_id_LU_txt.Text;

                try
                {
                    
                    myCommand.ExecuteNonQuery();
                    branch_refresh_but.PerformClick();
                    Fill_Cars_BranchID();   // Update Branch ID dropdown box in Cars tab with removed branch.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting branch", "Error");
                }
            }
            else
            {
                MessageBox.Show("No Valid BID to Delete Entered");
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rentalClassSLabel_Click(object sender, EventArgs e)
        {

        }

        //gets the max CID in the table and adds one to autoincrement it
        private String getNewCID()
        {
            String CID;

            myCommand.CommandText = "Select max(Customer_ID) as max from Customer;";
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            CID = myReader["max"].ToString();
            myReader.Close();

            if (CID.Length > 0)
            {
                CID = (int.Parse(CID) + 1).ToString();
            }
            else
            {
                CID = "0";
            }

            return CID;
        }

        //Customer Add button
        private void cust_add_but_Click(object sender, EventArgs e)
        {
            String CID;
            if (cust_first_name_txt.Text.Length > 0 && cust_street_add1_txt.Text.Length > 0 && cust_dob_txt.Text.Length > 0 &&
                cust_city_txt.Text.Length > 0 && cust_prov_txt.Text.Length > 0 && cust_pCode_txt.Text.Length > 0 && cust_phone_num_txt.Text.Length > 0 &&
                cust_insurance_txt.Text.Length > 0 && cust_drivers_txt.Text.Length > 0)
            {
                if (cust_custID_txt.Text.Length == 0)
                {
                    //if no CID was provided we autogenerate one
                    CID = getNewCID();
                } else
                {
                    //if one was provided we use that
                    CID = cust_custID_txt.Text.ToString();
                }
                try
                {
                    myCommand.CommandText = "insert into Customer Values (" + CID + ",'" + cust_first_name_txt.Text + "','" +
                        cust_mid_name_txt.Text + "','" + cust_last_name_txt.Text + "','" + cust_street_add1_txt.Text + "','" + cust_street_add2_txt.Text + "','" +
                        cust_city_txt.Text + "','" + cust_prov_txt.Text + "','" + cust_pCode_txt.Text + "','" + cust_dob_txt.Text + "','" + cust_phone_num_txt.Text + "','" +
                        cust_insurance_txt.Text + "','" + cust_drivers_txt.Text + "',0)";

                    myCommand.ExecuteNonQuery();
                    cust_refresh_but.PerformClick();
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Required Fields Missing or Incorrect");
            }
        }

        //customer edit button
        private void cust_edit_but_Click(object sender, EventArgs e)
        {
            //used to check if query needs a comma added
            int add = 0;
            try
            {
                myCommand.CommandText = "update Customer set ";

                if (cust_first_name_txt.Text.Length > 0)
                {
                    myCommand.CommandText += "First_Name = '" + cust_first_name_txt.Text + "'";
                    add = 1;
                }
                if (cust_mid_name_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Middle_Name = '" + cust_mid_name_txt.Text + "'";
                    add = 1;
                }
                if (cust_last_name_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Last_Name = '" + cust_last_name_txt.Text + "'";
                    add = 1;
                }
                if (cust_street_add1_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Street_Address1 = '" + cust_street_add1_txt.Text + "'";
                    add = 1;
                }
                if (cust_street_add2_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Street_Address2 = '" + cust_street_add2_txt.Text + "'";
                    add = 1;
                }
                if (cust_city_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "City = '" + cust_city_txt.Text + "'";
                    add = 1;
                }
                if (cust_prov_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Province = '" + cust_prov_txt.Text + "'";
                    add = 1;
                }
                if (cust_pCode_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Postal_Code = '" + cust_pCode_txt.Text + "'";
                    add = 1;
                }
                if (cust_dob_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Date_of_Birth = '" + cust_dob_txt.Text + "'";
                    add = 1;
                }
                if (cust_phone_num_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Phone_Number = '" + cust_phone_num_txt.Text + "'";
                    add = 1;
                }
                if (cust_insurance_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Insurance = '" + cust_insurance_txt.Text + "'";
                    add = 1;
                }
                if (cust_drivers_txt.Text.Length > 0)
                {
                    if (add == 1) { myCommand.CommandText += ","; }
                    myCommand.CommandText += "Drivers_License = '" + cust_drivers_txt.Text + "'";
                    add = 1;
                }

                myCommand.CommandText += "where Customer_ID = " + cust_custID_txt.Text + ";";

                if (add == 1 && cust_custID_txt.Text.Length > 0)
                {
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    cust_refresh_but.PerformClick();
                }
                else
                {
                    MessageBox.Show("No fields edited");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error occurred while trying to edit customer", "Error");
            }
        }

        //customer search button
        private void cust_search_but_Click(object sender, EventArgs e)
        {
            //used to check if fields entered are invalid
            int invalid = 0;
            int cid = 0;
            int result;
            myCommand.CommandText = "select * from Customer where ";

            if (cust_box_search.Text.Equals("Customer ID"))
            {
                myCommand.CommandText += "Customer_ID = ";
                cid = 1;
                if (cust_search_box_txt.Text.Length > 0 && !int.TryParse(cust_search_box_txt.Text.ToString(), out result))
                {
                    invalid = 2;
                    MessageBox.Show("Customer_ID Must Be Integer");
                }
            }
            else if (cust_box_search.Text.Equals("First Name"))
            {
                myCommand.CommandText += "First_Name = ";
            }
            else if (cust_box_search.Text.Equals("Middle Name"))
            {
                myCommand.CommandText += "Middle_Name = ";
            }
            else if (cust_box_search.Text.Equals("Last Name"))
            {
                myCommand.CommandText += "Last_Name = ";
            }
            else if (cust_box_search.Text.Equals("Street Address 1"))
            {
                myCommand.CommandText += "Street_Address1 = ";
            }
            else if (cust_box_search.Text.Equals("Street Address 2"))
            {
                myCommand.CommandText += "Street_Address2 = ";
            }
            else if (cust_box_search.Text.Equals("City"))
            {
                myCommand.CommandText += "City = ";
            }
            else if (cust_box_search.Text.Equals("Province"))
            {
                myCommand.CommandText += "Province = ";
            }
            else if (cust_box_search.Text.Equals("Postal Code"))
            {
                myCommand.CommandText += "Postal_Code = ";
            }
            else if (cust_box_search.Text.Equals("DOB"))
            {
                myCommand.CommandText += "Date_of_Birth = ";
            }
            else if (cust_box_search.Text.Equals("Phone Number"))
            {
                myCommand.CommandText += "Phone_Number = ";
            }
            else if (cust_box_search.Text.Equals("Insurance"))
            {
                myCommand.CommandText += "Insurance = ";
            }
            else if (cust_box_search.Text.Equals("Drivers_License"))
            {
                myCommand.CommandText += "Drivers_License = ";
            }
            else if (cust_box_search.Text.Equals("Membership Status"))
            {
                myCommand.CommandText += "Membership_Status = ";
            }
            else
            {
                MessageBox.Show("No Search Field Selected");
                invalid = 1;
            }


            if (cust_search_box_txt.Text.Length > 0 && invalid == 0)
            {
                if (cid != 1)
                {
                    myCommand.CommandText += "'" + cust_search_box_txt.Text + "';";
                }
                else
                {
                    myCommand.CommandText += cust_search_box_txt.Text + ";";
                }
                try
                {
                    myReader = myCommand.ExecuteReader();
                    customer_view.Rows.Clear();
                    while (myReader.Read())
                    {
                        customer_view.Rows.Add(myReader["Customer_ID"].ToString(), myReader["First_Name"].ToString(), myReader["Middle_Name"].ToString(), myReader["Last_Name"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Date_of_Birth"].ToString(), myReader["Phone_Number"].ToString(), myReader["Insurance"].ToString(), myReader["Drivers_License"].ToString(), myReader["Membership_Status"].ToString());
                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while trying to search for customer(s)", "Error");
                }
            }
            else
            {
                if (invalid != 2)
                {
                    MessageBox.Show("No Search Text Entered");
                }
            }
        }

        //customer delete button
        private void cust_del_but_Click(object sender, EventArgs e)
        {
            int result;
            //check to see if int
            if (cust_id_LU_txt.Text.Length > 0 && !int.TryParse(branch_search_text_box.Text.ToString(), out result))
            {
                myCommand.CommandText = "delete from Customer where Customer_ID = " + cust_id_LU_txt.Text;

                try
                {
                    
                    myCommand.ExecuteNonQuery();
                    cust_refresh_but.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting customer", "Error");
                }
            }
            else
            {
                MessageBox.Show("No Valid CustomerID to delete");
            }
        }

        //(re)populate customer tab
        private void refresh_customer()
        {
            myCommand.CommandText = "select * from Customer";

            try
            {
                myReader = myCommand.ExecuteReader();

                customer_view.Rows.Clear();
                while (myReader.Read())
                {
                    customer_view.Rows.Add(myReader["Customer_ID"].ToString(), myReader["First_Name"].ToString(), myReader["Middle_Name"].ToString(), myReader["Last_Name"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Date_of_Birth"].ToString(), myReader["Phone_Number"].ToString(), myReader["Insurance"].ToString(), myReader["Drivers_License"].ToString(), myReader["Membership_Status"].ToString());
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }
        //customer refresh button
        private void cust_refresh_but_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Customer";

            try
            {
                myReader = myCommand.ExecuteReader();

                customer_view.Rows.Clear();
                while (myReader.Read())
                {
                    customer_view.Rows.Add(myReader["Customer_ID"].ToString(), myReader["First_Name"].ToString(), myReader["Middle_Name"].ToString(), myReader["Last_Name"].ToString(), myReader["Street_Address1"].ToString(), myReader["Street_Address2"].ToString(), myReader["City"].ToString(), myReader["Province"].ToString(), myReader["Postal_Code"].ToString(), myReader["Date_of_Birth"].ToString(), myReader["Phone_Number"].ToString(), myReader["Insurance"].ToString(), myReader["Drivers_License"].ToString(), myReader["Membership_Status"].ToString());
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }


        private void cars_branch_id_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //************************************************
        // Cars Tab
        //************************************************


        //Populate Cars Branch ID combo box with all available branch ID's in the Branch table
        void Fill_Cars_BranchID()
        {
            myCommand.CommandText = "select * from Branch";

            try
            {
                cars_branch_id_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String branch_id = myReader["BID"].ToString();
                    cars_branch_id_dropdown.Items.Add(branch_id);
                }
                myReader.Close();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }

        //Populate Cars Car Type ID combo box with all available Car Type ID's in the Car Types table
        void Fill_Cars_Car_Type_ID()
        {
            myCommand.CommandText = "select * from Car_Type";

            try
            {
                cars_car_type_id_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String car_type_id = myReader["Car_Type_ID"].ToString();
                    cars_car_type_id_dropdown.Items.Add(car_type_id);
                }
                myReader.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }
        
        //Populate Cars Delete VIN combo box with all available Car VINs in the Cars table
        void Fill_Cars_Delete_VIN()
        {
            myCommand.CommandText = "select * from Car";

            try
            {
                cars_delete_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String car_vin = myReader["VIN"].ToString();
                    cars_delete_dropdown.Items.Add(car_vin);
                }
                cars_delete_dropdown.Text = "";
                myReader.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }

        }


        //Refresh Cars tab DataGridView with all records in Car table
        private void refresh_cars()
        {
            myCommand.CommandText = "select * from Car ORDER BY LEN(VIN), VIN";

            try
            {
                myReader = myCommand.ExecuteReader();
                cars_view.Rows.Clear();
                while (myReader.Read())
                {
                    cars_view.Rows.Add(myReader["VIN"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(), myReader["Year"].ToString(),
                        myReader["No_of_Seats"].ToString(), myReader["Colour"].ToString(), myReader["Insurance_No"].ToString(), myReader["Odometer_No"].ToString(),
                        myReader["Branch_ID"].ToString(), myReader["Car_Type_ID"].ToString());
                }
                myReader.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }

        }


        //Add Car to Car Table
        private void btn_cars_add_Click(object sender, EventArgs e)
        {

            if (cars_vin_text.TextLength > 0 && cars_make_txt.TextLength > 0 && cars_model_txt.TextLength > 0 && cars_year_txt.TextLength > 0 
                && cars_no_seats_txt.TextLength > 0 && cars_colour_txt.TextLength > 0 && cars_insurance_no_txt.TextLength > 0 
                && cars_odometer_no_txt.TextLength > 0 && cars_branch_id_dropdown.Text.Length > 0 && cars_car_type_id_dropdown.Text.Length > 0)
            {
                try
                {
                    myCommand.CommandText = "insert into Car values (" + cars_vin_text.Text + ",'" + cars_make_txt.Text + "','" + cars_model_txt.Text +
                        "','" + cars_year_txt.Text + "','" + cars_no_seats_txt.Text + "','" + cars_colour_txt.Text + "','" + cars_insurance_no_txt.Text + "','" +
                        cars_odometer_no_txt.Text + "','" + cars_branch_id_dropdown.Text + "','" + cars_car_type_id_dropdown.Text + "')";

                    myCommand.ExecuteNonQuery();
                    refresh_cars();
                    Fill_Cars_Delete_VIN();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while grabbing data from database", "Error");
                }
            }

            else
            {
                MessageBox.Show("Required Fields Missing or Incorrect");
            }
        }

        //Refresh Cars tab DataGridView when Show All button is clicked
        private void btn_cars_show_all_Click(object sender, EventArgs e)
        {
            refresh_cars();
        }

        // Delete Car from Car table
        private void btn_cars_delete_Click(object sender, EventArgs e)
        {
            if (cars_delete_dropdown.Text.Length > 0)
            {
                myCommand.CommandText = "delete from Car where VIN = " + cars_delete_dropdown.Text;

                try
                {
                    myCommand.ExecuteNonQuery();
                    refresh_cars();
                    Fill_Cars_Delete_VIN();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting car from database", "Error");
                }
            }
            else
            {
                MessageBox.Show("Select a VIN to Delete");
            }
        }

        //Edit a Car in the Cars table
        private void btn_cars_edit_Click(object sender, EventArgs e)
        {
            int editFlag = 0;

            try
            {
                myCommand.CommandText = "update Car set ";

                if (cars_vin_text.Text.Length > 0)
                {
                    if (cars_make_txt.TextLength > 0)
                    {
                        myCommand.CommandText += "Make = '" + cars_make_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_model_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Model = '" + cars_model_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_year_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Year = '" + cars_year_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_no_seats_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "No_of_Seats = '" + cars_no_seats_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_colour_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Colour = '" + cars_colour_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_insurance_no_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Insurance_No = '" + cars_insurance_no_txt.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_odometer_no_txt.TextLength > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Odometer_No = '" + cars_odometer_no_txt.Text + "'";
                        editFlag = 1;
                    }


                    if (cars_branch_id_dropdown.Text.Length > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Branch_ID = '" + cars_branch_id_dropdown.Text + "'";
                        editFlag = 1;
                    }

                    if (cars_car_type_id_dropdown.Text.Length > 0)
                    {
                        if (editFlag == 1) { myCommand.CommandText += ","; }
                        myCommand.CommandText += "Car_Type_ID = '" + cars_car_type_id_dropdown.Text + "'";
                        editFlag = 1;
                    }

                    
                    if (editFlag == 1)
                    {
                        MessageBox.Show(myCommand.CommandText);
                        myCommand.CommandText += "where VIN = " + cars_vin_text.Text + ";";
                        myCommand.ExecuteNonQuery();
                        refresh_cars();
                        Fill_Cars_Delete_VIN();
                    }
                    else if (editFlag == 0)
                    {
                        MessageBox.Show("No Fields Edited");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Enter a Valid VIN");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred while deleting car from database", "Error");
            }

        }

        //Update Car DataGridView with records matching the selected search parameters
        private void btn_cars_search_Click(object sender, EventArgs e)
        {
            if (cars_search_dropdown.Text.Length > 0)
            {

                myCommand.CommandText = "select * from Car where " + cars_search_attribute_dropdown.Text + " = '" + cars_search_dropdown.Text + "';";

                try
                {
                    myReader = myCommand.ExecuteReader();
                    cars_view.Rows.Clear();
                    while (myReader.Read())
                    {
                        cars_view.Rows.Add(myReader["VIN"].ToString(), myReader["Make"].ToString(), myReader["Model"].ToString(), myReader["Year"].ToString(),
                        myReader["No_of_Seats"].ToString(), myReader["Colour"].ToString(), myReader["Insurance_No"].ToString(), myReader["Odometer_No"].ToString(),
                        myReader["Branch_ID"].ToString(), myReader["Car_Type_ID"].ToString());
                    }
                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while searching for car(s)", "Error");
                }

            }
        }

        //Fill Cars - Search combo box with all items available based on the selected search attribute
        void Fill_Cars_Search_Dropdown(String search_attribute)
        {
            myCommand.CommandText = "select * from Car";

            try
            {
                cars_search_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String val = myReader[search_attribute].ToString();
                    
                    if (!cars_search_dropdown.Items.Contains(val)) 
                    { 
                        cars_search_dropdown.Items.Add(val); 
                    } 
                   
                }
                myReader.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }

        //Fill Cars search box with all available data when the selected attribute changes
        private void cars_search_attribute_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cars_search_attribute_dropdown.Text != "--- Select ---")
            {
                Fill_Cars_Search_Dropdown(cars_search_attribute_dropdown.Text);
                cars_search_dropdown.Text = "";
            }

        }

        private void typeDescS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void branch_search_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cars_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //---------------------- Rentals Tab ---------------------------------------

        //(re)populate rental tab
        private void showRentals()
        {
            myCommand.CommandText = "select * from Rentals;";

            try
            {
                myReader = myCommand.ExecuteReader();
                my_rentals_view.Rows.Clear();
                while (myReader.Read())
                {
                    my_rentals_view.Rows.Add(
                        myReader["TID"].ToString(), myReader["Pick_Up_Date"].ToString(),
                        myReader["Return_Date"].ToString(), myReader["Customer_ID"].ToString(),
                        myReader["VIN"].ToString(), myReader["Pick_Up_BID"].ToString(),
                        myReader["Return_BID"].ToString(), myReader["Total_Rent_Value"].ToString());
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while grabbing data from database", "Error");
            }
        }

        //button function for showRentals
        private void view_all_btn_Click(object sender, EventArgs e)
        {
            showRentals();
        }

        //search for rental via TID
        private void search_by_id_btn_Click(object sender, EventArgs e)
        {
            if (search_id_box.Text.Length > 0)
            {
                myCommand.CommandText = "select * from Rentals where Customer_ID = " + search_id_box.Text.ToString() + ";";

                try
                {
                    myReader = myCommand.ExecuteReader();
                    my_rentals_view.Rows.Clear();
                    while (myReader.Read())
                    {
                        my_rentals_view.Rows.Add(
                            myReader["TID"].ToString(), myReader["Pick_Up_Date"].ToString(),
                            myReader["Return_Date"].ToString(), myReader["Customer_ID"].ToString(),
                            myReader["VIN"].ToString(), myReader["Pick_Up_BID"].ToString(),
                            myReader["Return_BID"].ToString(), myReader["Total_Rent_Value"].ToString());
                    }
                    myReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while searching ", "Error");
                }
            }
            else
            {
                MessageBox.Show("No Customer ID Entered");
            }
        }

        //add late fee to rental transaction
        private void add_late_fee_btn_Click(object sender, EventArgs e)
        {
            if (late_tid_box.Text.Length > 0)
            {
                String initialValue;
                Double newValue;
                //getting the return BID now
                myCommand.CommandText = "Select Total_Rent_Value from Rentals where TID = " + late_tid_box.Text.ToString() + ";";
                myReader3 = myCommand.ExecuteReader();
                myReader3.Read();
                initialValue = myReader3["Total_Rent_Value"].ToString();
                myReader3.Close();

                newValue = Double.Parse(initialValue) + LATE_FEE;



                myCommand.CommandText = "update Rentals set Total_Rent_Value = " + newValue.ToString() +
                    " Where TID = " + late_tid_box.Text.ToString() + ";";
                try
                {
                    myCommand.ExecuteNonQuery();
                    view_all_btn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while trying to find transaction", "Error");
                }

            }
            else
            {
                MessageBox.Show("No Transaction ID Entered");
            }
        }

        //cancel rental transaction
        private void cancel_rental_btn_Click(object sender, EventArgs e)
        {
            if (cancel_rental_box.Text.Length > 0)
            {
                myCommand.CommandText = "delete from Rentals where TID = " + cancel_rental_box.Text.ToString() + ";";

                try
                {
                    myCommand.ExecuteNonQuery();
                    view_all_btn.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while trying to cancel rental transaction", "Error");
                }
            }
            else
            {
                MessageBox.Show("No Transaction ID Entered");
            }
        }

        // UPDATE CAR BRANCH_ID WHEN RETURNED TO A DIFFERENT BRANCH
        void update_car_branch()
        {


            //Get current date and format the same as SQL date type
            DateTime currentDate = DateTime.Now;

            //Select all VIN's that have been returned to a different branch and the return date has passed

            myCommand.CommandText = "Select * From Rentals Where Pick_Up_BID != Return_BID;";


            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {

                    DateTime returnDate = (DateTime)myReader["Return_Date"];

                    Console.WriteLine((currentDate - returnDate).Days.ToString());


                    if ((currentDate - returnDate).Days > 0)
                    {
                        String vin = myReader["VIN"].ToString();
                        String branch_id = myReader["Return_BID"].ToString();

                        myCommand2.CommandText = "Update Car Set Branch_ID = " + branch_id + " Where VIN = " + vin + ";";
                        myCommand2.ExecuteNonQuery();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating refreshing data", "Error");
            }


            myReader.Close();

        }


    }


}
