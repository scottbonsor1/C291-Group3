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
    public partial class Rentals : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlCommand myCommand2;
        public SqlDataReader myReader;
        public SqlDataReader myReader2;
        public SqlDataReader myReader3;
        public Double LATE_FEE = 49.99; //this is the added cost for late rentals
        public Double DIFF_BRANCH_COST = 35.50; //this is the fee for returning to a different branch
      
        public Rentals()
        {
            InitializeComponent();

            //Change the server here for your guys' own servers
                //MultipleActiveResultsSets=True allows for multiple for multuple MyCommands open and accessing the database.
                    //2 SQl commands running simultaneously required when updating the Branch_ID of cars returned to different branches.
            String connectionString = "Server = LAPTOP-HUT8634L; Database = 291_RentalDatabase; Trusted_Connection = yes; MultipleActiveResultSets=True";

            SqlConnection myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand2 = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
                myCommand2.Connection = myConnection;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            //Fill Customer ID Dropdown Box with all Customer ID's in database. Used to assign a rental transaction to a customer.
            Fill_Customer_ID();
            Fill_Branches();
            Fill_Vehicle_Types();
            

            //Go through rentals database and update the branch id for all cars returned to a differnt branch
            update_car_branch();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void customer_id_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Fill Customer ID dropdown box with all available customer IDs in the database.
        void Fill_Customer_ID()
        {
            myCommand.CommandText = "select * from Customer";

            try
            {
                customer_id_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String customer_id = myReader["Customer_ID"].ToString();
                    customer_id_dropdown.Items.Add(customer_id);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        //Fill Pick-up Branch dropdown box with all available branches
        void Fill_Branches()
        {
            myCommand.CommandText = "select * from Branch";

            try
            {
                pickup_branch_dropdown.Items.Clear();
                return_branch_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String branch = myReader["Description"].ToString();
                    pickup_branch_dropdown.Items.Add(branch);
                    return_branch_dropdown.Items.Add(branch);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        void Fill_Vehicle_Types()
        {
            myCommand.CommandText = "select * from Car_Type";

            try
            {
                vehicle_type_dropdown.Items.Clear();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String car_type = myReader["Description"].ToString();
                    vehicle_type_dropdown.Items.Add(car_type);
             
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //int customerID = (int) customer_id_dropdown.SelectedValue;
            String CarType = vehicle_type_dropdown.Text;
            String PickupB = pickup_branch_dropdown.Text;
            String ReturnB = return_branch_dropdown.Text;
            //REF: https://www.tutorialspoint.com/vb.net/vb.net_date_time_picker.htm#:~:text=The%20DateTimePicker%20control%20allows%20selecting,by%20clicking%20the%20required%20date.
            DateTime pickupTime = dateTimePicker1.Value;
            DateTime returnTime = dateTimePicker2.Value;
            String selectedPDate = pickupTime.ToString();
            String selectedRDate = returnTime.ToString();

            TimeSpan rentalSpan = returnTime.Subtract(pickupTime);



            if (rentalSpan.Days < 0)
            {
                MessageBox.Show("Return Date cannot be before the Pick-Up Date");
            }
            else if (CarType.Length > 0 && PickupB.Length > 0)
            {
                VIN_box.Items.Clear();
                //Car.VIN, Car.Make, Car.Model, Car.Year, Car.No_of_Seats, Car.Colour, Car_Type.Description, Car_Type.Daily_Rate, Car_Type.Weekly_Rate, Car_Type.Monthly_Rate 
                myCommand.CommandText = "select * from Car, Car_Type, Branch " +
                    "where Car.Car_Type_ID = Car_Type.Car_Type_ID and Branch.BID = Car.Branch_ID and " +
                    "Branch.Description = '" + PickupB + "' and Car_Type.Description = '" + CarType + "' " +
                    "and VIN not in " +
                    "(select VIN from Rentals where " +
                    "(('" + selectedPDate + "' >= Pick_Up_Date and '" + selectedPDate + "' <= Return_Date) or " +
                    "('" + selectedRDate + "' <= Return_Date and '" + selectedRDate + "' >= Pick_Up_Date ) or " +
                    "('" + selectedPDate + "' <= Pick_Up_Date and '" + selectedRDate + "' >= Return_Date)));";

                try
                {
                    myReader = myCommand.ExecuteReader();
                    available_vehicles_view.Rows.Clear();
                    while (myReader.Read())
                    {
                        available_vehicles_view.Rows.Add(
                            myReader["VIN"].ToString(), myReader["Make"].ToString(),
                            myReader["Model"].ToString(), myReader["Year"].ToString(),
                            myReader["No_of_Seats"].ToString(), myReader["Colour"].ToString(),
                            myReader["Description"].ToString(), myReader["Daily_Rate"].ToString(),
                            myReader["Weekly_Rate"].ToString(), myReader["Monthly_Rate"].ToString());

                        String VIN_for_list = myReader["VIN"].ToString();
                        VIN_box.Items.Add(VIN_for_list);

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
                MessageBox.Show("Choose Vehicle Type and Pick-Up Branch to search");
            }


        }

        private Double getCost(TimeSpan rentalSpan, String carType)
        {
            Double cost = 0;
            int days = rentalSpan.Days + 1;
            int months, weeks;
            String dCost, wCost, mCost;

            months = days / 30;
            days -= months * 30;
            weeks = days / 7;
            days -= weeks * 7;

            myCommand.CommandText = "Select Daily_Rate, Weekly_Rate, Monthly_Rate from Car_Type where Description = '" + carType + "';";
            myReader2 = myCommand.ExecuteReader();
            myReader2.Read();
            dCost = myReader2["Daily_Rate"].ToString();
            wCost = myReader2["Weekly_Rate"].ToString();
            mCost = myReader2["Monthly_Rate"].ToString();
            myReader2.Close();

            //REF: https://docs.microsoft.com/en-us/dotnet/api/system.double.parse?view=net-6.0
            cost += (months * (Double.Parse(mCost)));
            cost += (weeks * (Double.Parse(wCost)));
            cost += (days * (Double.Parse(dCost)));

            return cost;
        }

        private void updateGold(String customerID)
        {
            String rentalCount;
            myCommand.CommandText = "Select count(*) as count from Rentals where Customer_ID = " + customerID + ";";
            myReader3 = myCommand.ExecuteReader();
            myReader3.Read();
            rentalCount = myReader3["count"].ToString();
            myReader3.Close();

            //if this is their third rental
            if (int.Parse(rentalCount) == 3)
            {
                //update their membership status to gold member
                myCommand.CommandText = "update Customer set Membership_Status = 1 where Customer_ID = " + customerID + ";";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Congratulations, you have been upgraded to a Gold Star member!");
            }

        }

        private Boolean goldCheck(String customerID)
        {
            Boolean gold = false;
            String goldStatus;

            myCommand.CommandText = "Select Membership_Status from Customer where Customer_ID = " + customerID + ";";
            myReader3 = myCommand.ExecuteReader();
            myReader3.Read();
            goldStatus = myReader3["Membership_Status"].ToString();
            myReader3.Close();

            if (int.Parse(goldStatus) == 1)
            {
                gold = true;
            }

            return gold;
        }

        //gets the max TID in the table and adds one to autoincrement the TID
        private String getNewTID()
        {
            String TID;

            myCommand.CommandText = "Select max(TID) as max from Rentals;";
            myReader3 = myCommand.ExecuteReader();
            myReader3.Read();
            TID = myReader3["max"].ToString();
            myReader3.Close();

            if (TID.Length > 0)
            {
                TID = (int.Parse(TID) + 1).ToString();
            } else
            {
                TID = "0";
            }

            return TID;
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            String PBID, RBID;
            //String TID = transaction_id_txt.Text;
            String customerID = customer_id_dropdown.Text;
            String CarType = vehicle_type_dropdown.Text;
            String PickupB = pickup_branch_dropdown.Text;
            String ReturnB = return_branch_dropdown.Text;
            //REF: https://www.tutorialspoint.com/vb.net/vb.net_date_time_picker.htm#:~:text=The%20DateTimePicker%20control%20allows%20selecting,by%20clicking%20the%20required%20date.
            DateTime pickupTime = dateTimePicker1.Value;
            DateTime returnTime = dateTimePicker2.Value;
            String pickupDate = pickupTime.ToString();
            String returnDate = returnTime.ToString();
            String VIN = VIN_box.Text;



            TimeSpan rentalSpan = returnTime.Subtract(pickupTime);
            
            if (rentalSpan.Days < 0)
            {
                MessageBox.Show("Return Date cannot be before the Pick-Up Date");
            }
            else if (customerID.Length > 0 && CarType.Length > 0 && PickupB.Length > 0 &&
                ReturnB.Length > 0 && pickupDate.Length > 0 &&
                returnDate.Length > 0 && VIN.Length > 0)
            {
                //getting TID to add to transaction
                String TID = getNewTID();

                //calculating the rental cost
                Double cost = getCost(rentalSpan, CarType);
                if (!PickupB.Equals(ReturnB))
                {
                    if (!goldCheck(customerID))
                    {
                        cost += DIFF_BRANCH_COST;
                    }
                }
                //getting the pickup BID from the selected description
                myCommand.CommandText = "Select BID from Branch where Description = '" + PickupB + "';";
                myReader2 = myCommand.ExecuteReader();
                myReader2.Read();
                PBID = myReader2["BID"].ToString();
                myReader2.Close();

                //getting the return BID now
                myCommand.CommandText = "Select BID from Branch where Description = '" + ReturnB + "';";
                myReader3 = myCommand.ExecuteReader();
                myReader3.Read();
                RBID = myReader3["BID"].ToString();
                myReader3.Close();


                try
                {
                    myCommand.CommandText = "insert into Rentals values (" + TID + ",'" + pickupDate + "','" +
                        returnDate + "'," + customerID + ",'" +
                        VIN + "'," + PBID + "," + RBID + ",'" +
                        cost.ToString() + "')";
                    MessageBox.Show("Vehicle Booked");

                    myCommand.ExecuteNonQuery();
                    
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.ToString(), "Error");
                }
                //update list to remove newly rented car
                searchButton.PerformClick();

                //lets check if that gives them a gold upgrade
                updateGold(customerID);
            }
            else
            {
                MessageBox.Show("Required Fields Missing or Incorrect");
            }
        }

        private void vehicle_type_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void available_vehicles_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VIN_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        // UPDATE CAR BRANCH_ID WHEN RETURNED TO A DIFFERENT BRANCH
        void update_car_branch()
        {
           

            //Get current date and format the same as SQL date type
            DateTime currentDate = DateTime.Now;
            int day = currentDate.Day;
            int month = currentDate.Month;
            int year = currentDate.Year;


            //Console.WriteLine(currentDateString);

            //Select all VIN's that have been returned to a different branch and the return date has passed
            myCommand.CommandText = "Select * From Rentals Where Pick_Up_BID != Return_BID and Year(Return_Date) = " + year +
                "and Month(Return_Date) = " + month + " and Day(Return_Date) = " + (day - 1) + ";";
            try
            {
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    String vin = myReader["VIN"].ToString();
                    String branch_id = myReader["Return_BID"].ToString();

                    
                    myCommand2.CommandText = "Update Car Set Branch_ID = " + branch_id + " Where VIN = " + vin + ";";
                    myCommand2.ExecuteNonQuery();


                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
           
            myReader.Close();

            
       
        }
           





    }

    



}
