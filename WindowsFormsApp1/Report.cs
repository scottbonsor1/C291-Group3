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

    public partial class Report : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        //Change the server here for your guys' own servers
        public String myServer = "DESKTOP-D7J3O0B";
        public String myDatabase = "291_RentalDatabase";
        public Report()
        {
            InitializeComponent();



            
            String connectionString = "Server = " + myServer + "; Database = " + myDatabase + "; Trusted_Connection = yes;";


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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee f1 = new Employee();
            f1.ShowDialog();
            this.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void report1_btn_Click(object sender, EventArgs e)//Zachs report
        {

            myCommand.CommandText = "Select CT.Car_Type_ID, Description, COUNT(CT.Car_Type_ID) AS TOTAL " +
                        "From Car_Type AS CT, Car AS C, Rentals AS R " +
                        "Where R.VIN = C.VIN and C.Car_Type_ID = CT.Car_Type_ID " +
                        "GROUP BY CT.Car_Type_ID, Description " +
                        "ORDER BY TOTAL DESC";

            try
            {

                myReader = myCommand.ExecuteReader();

                reportgrid1.Rows.Clear();

                while(myReader.Read())
                {
                    reportgrid1.Rows.Add(myReader["Car_Type_ID"].ToString(), myReader["Description"].ToString(), myReader["TOTAL"].ToString());
                }

                myReader.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }
        
        private void report2_btn_Click(object sender, EventArgs e)//Zachs report
        {
            myCommand.CommandText = "SELECT DISTINCT C.First_Name, C.Last_Name " +
                "FROM Rentals AS R, Customer AS C, Branch AS B " +
                "WHERE C.Customer_ID = R.Customer_ID AND R.Return_BID = B.BID AND C.City = B.City " +
                "EXCEPT " +
                "(SELECT DISTINCT C.First_Name, C.Last_Name " +
                "FROM Rentals AS R, Customer AS C, Branch AS B " +
                "WHERE C.Customer_ID = R.Customer_ID AND R.Return_BID = B.BID AND C.City != B.City)";

            try
            {
                myReader = myCommand.ExecuteReader();
                reportgrid2.Rows.Clear();

                while (myReader.Read())
                {
                    reportgrid2.Rows.Add(myReader["First_Name"].ToString(), myReader["Last_Name"].ToString());
                }

                myReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void report3_btn_Click(object sender, EventArgs e)//Brandons report
        {
            myCommand.CommandText = "SELECT MONTH(R.Pick_Up_Date) AS M, C.Car_Type_ID, COUNT(R.Pick_Up_BID) as TOTAL " +
                "FROM Rentals AS R, Car AS C " +
                "WHERE R.VIN = C.VIN " +
                "GROUP BY MONTH(R.Pick_Up_Date), C.Car_Type_ID " +
                "ORDER BY MONTH(R.Pick_Up_Date)";

            try
            {
                myReader = myCommand.ExecuteReader();
                reportgrid3.Rows.Clear();

                while(myReader.Read())
                {
                    reportgrid3.Rows.Add(myReader["M"].ToString(), myReader["Car_Type_ID"].ToString(), myReader["TOTAL"].ToString());
                }
                    
                myReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            
        }

        private void report4_btn_Click(object sender, EventArgs e)//Malcolms report
        {

            int temp;
            
            switch (monthSelect.Text)
            {

                case "January":
                    temp = 1;
                    break;

                case "February":
                    temp = 2;
                    break;

                case "March":
                    temp = 3;
                    break;

                case "April":
                    temp = 4;
                    break;

                case "May":
                    temp = 5;
                    break;

                case "June":
                    temp = 6;
                    break;

                case "July":
                    temp = 7;
                    break;

                case "August":
                    temp = 8;
                    break;

                case "September":
                    temp = 9;
                    break;

                case "October":
                    temp = 10;
                    break;

                case "November":
                    temp = 11;
                    break;

                case "December":
                    temp = 12;
                    break;

                default:
                    temp = 0;
                    break;

            }

            myCommand.CommandText = "(SELECT C.Customer_ID, First_Name, Middle_Name, Last_Name " +
                "FROM Customer AS C) " +
                "EXCEPT " +
                "(SELECT C.Customer_ID, First_Name, Middle_Name, Last_Name " +
                "FROM Customer AS C, Rentals AS R " +
                "WHERE C.Customer_ID = R.Customer_ID AND MONTH(R.Return_Date) = " + temp + ");";

            try
            {
                myReader = myCommand.ExecuteReader();

                reportgrid4.Rows.Clear();
                while(myReader.Read())
                {
                    reportgrid4.Rows.Add(myReader["Customer_ID"].ToString(), myReader["First_Name"].ToString(), myReader["Middle_Name"].ToString(), myReader["Last_Name"]);

                }

                myReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void report5_btn_Click(object sender, EventArgs e)//Scotts report
        {
            myCommand.CommandText = "SELECT B.BID, B.Description, YEAR(R.Pick_Up_Date) AS Y, MONTH(R.Pick_Up_Date) AS M, " +
                "SUM(R.Total_Rent_Value) AS TOTAL " +
                "FROM Rentals AS R, Branch AS B " +
                "WHERE R.Pick_Up_BID = B.BID " +
                "GROUP BY B.BID, B.Description, YEAR(R.Pick_Up_Date), MONTH(R.Pick_Up_Date) Order By SUM(R.Total_Rent_Value) Desc";


            try
            {


                myReader = myCommand.ExecuteReader();
                reportgrid5.Rows.Clear();

                while (myReader.Read())
                {
                    reportgrid5.Rows.Add(myReader["BID"].ToString(), myReader["Description"].ToString(), myReader["Y"].ToString(), myReader["M"].ToString(), myReader["TOTAL"].ToString());
                }

                myReader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        private void reportgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportgrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void monthLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
