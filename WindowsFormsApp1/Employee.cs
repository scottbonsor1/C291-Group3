using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public Employee()
        {
            InitializeComponent();

            //Change the server here for your guys' own servers
            String connectionString = "Server = LAPTOP-DSBFVL6U; Database = 291_RentalDatabase; Trusted_Connection = yes;";


            /* Starting the connection */
            /*  SqlConnection myConnection = new SqlConnection("user id=temp2;" + // Username
                                         "password=adminadmin;" + // Password
                                         "server=localhost;" + // IP for the server
                                                               //"Trusted_Connection=yes;" +
                                         "database=ConnectTutorial; " + // Database to connect to
                                         "connection timeout=30"); // Timeout in seconds */

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
                refreshCarType();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

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
            myCommand.CommandText = "select * from Car_Type";

            try
            { 
                myReader = myCommand.ExecuteReader();

                carTypeView.Rows.Clear();
                while (myReader.Read())
                {
                    carTypeView.Rows.Add(myReader["Car_Type_ID"].ToString(), myReader["Description"].ToString(), myReader["Daily_Rate"].ToString(), myReader["Weekly_Rate"].ToString(), myReader["Monthly_Rate"].ToString());
                }

                myReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        //add new Car Type to Car_Type database table
        private void addCarTypeButClick(object sender, EventArgs e)
        {
            if (modelID.Text.Length > 0 && typeDesc.Text.Length > 0 && dRent.Text.Length > 0
                && wRent.Text.Length > 0 && mRent.Text.Length > 0)
            {
                try
                {
                    myCommand.CommandText = "insert into Car_Type values (" + modelID.Text + ",' " +
                        typeDesc.Text + "',' " + dRent.Text + "',' " + wRent.Text + "',' " +
                        mRent.Text + "')";
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    refreshCarType();
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

        //delete car type from Car_Type database table
        private void delCarTypeButClick(object sender, EventArgs e)
        {

            if (modelID.Text.Length > 0 )
            {
                myCommand.CommandText = "delete from Car_Type where Car_Type_ID = " + modelID.Text;

                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();
                    refreshCarType();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
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
            if (modelID.Text.Length > 0)
            {
                int check = 0;
                myCommand.CommandText = "update Car_Type set ";

                if (typeDesc.Text.Length > 0)
                {
                    myCommand.CommandText += "Description = '" + typeDesc.Text + "'";
                    check = 1;
                }
                if (dRent.Text.Length > 0)
                {
                    if (check == 1) { myCommand.CommandText += ", ";  }
                    myCommand.CommandText += "Daily_Rate = " + dRent.Text;
                    check = 1;
                }
                if (wRent.Text.Length > 0)
                {
                    if (check == 1) { myCommand.CommandText += ", "; }
                    myCommand.CommandText += "Weekly_Rate = " + wRent.Text;
                    check = 1;
                }
                if (mRent.Text.Length > 0)
                {
                    if (check == 1) { myCommand.CommandText += ", "; }
                    myCommand.CommandText += "Monthly_Rate = " + mRent.Text;
                    check = 1;
                }

                myCommand.CommandText += " where Car_Type_ID = " + modelID.Text + ";";

                if (check == 0)
                {
                    MessageBox.Show("No edit fields entered");
                }

                else
                {
                    try
                    {
                        MessageBox.Show(myCommand.CommandText);
                        myCommand.ExecuteNonQuery();
                        refreshCarType();
                    }

                    catch (Exception e2)
                    {
                        MessageBox.Show("Invalid value(s) entered");
                    }
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


        private void branch_refresh_but_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Branch";

            try
            {
                //MessageBox.Show(myCommand.CommandText);  
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
                MessageBox.Show(ex.ToString(), "Error");
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


        private void branch_add_but_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show(myCommand.CommandText);

                    myCommand.ExecuteNonQuery();
                    branch_refresh_but.PerformClick();
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

        private void branch_edit_but_Click(object sender, EventArgs e)
        {
            int add = 0;
            try
            {
                myCommand.CommandText = "update Branch set ";

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
                    MessageBox.Show(myCommand.CommandText);

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
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void branch_search_but_Click(object sender, EventArgs e)
        {
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
                    //MessageBox.Show(myCommand.CommandText);
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
                    MessageBox.Show(ex.ToString(), "Error");
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

        private void branch_del_but_Click(object sender, EventArgs e)
        {
            int result;
            if (branch_id_LU_txt.Text.Length > 0 && !int.TryParse(branch_search_text_box.Text.ToString(), out result)) //tests if it is an int
            {
                myCommand.CommandText = "delete from Branch where BID = " + branch_id_LU_txt.Text;

                try
                {
                    MessageBox.Show(myCommand.CommandText);
                    myCommand.ExecuteNonQuery();
                    branch_refresh_but.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
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
    }
}
