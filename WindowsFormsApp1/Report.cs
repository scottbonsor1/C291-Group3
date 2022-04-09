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
        public String myServer = "LAPTOP-HUT8634L";
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
            SqlConnection con = new SqlConnection(@"Data Source=" + myServer + ";Initial Catalog = " + myDatabase + ";Integrated Security=True");
            {
                //List the rental popularity of the car types from most to least popular
                using (SqlCommand cmd = new SqlCommand("Select CT.Car_Type_ID, Description, count(CT.Car_Type_ID) as Count" +
                        "From Car_Type CT, Car C, Rentals R" +
                        "Where R.VIN = C.VIN and C.Car_Type_ID = CT.Car_Type_ID" +
                        "Group by C.Car_Type_ID, Description" +
                        "Order by Count DESC;"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    reportgrid1.Rows.Clear();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            reportgrid1.Rows.Add(sdr["Car_Type_ID"].ToString(), sdr["Description"].ToString());
                        }
                    }
                }
            }
        }

        private void report2_btn_Click(object sender, EventArgs e)//Zachs report
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + myServer + ";Initial Catalog = " + myDatabase + ";Integrated Security=True");
            {
                //List all customer(names) who have never returned a car to a branch outside their city
                using (SqlCommand cmd = new SqlCommand("Select distinct C.First_Name + C.Last_Name" +
                        "From Rentals R, Customer C, Branch B" +
                        "Where C.Customer_ID = R.Customer_ID and R.Return_BID = B.BID and C.City = B.City" +
                        "except(" +
                        "Select distinct *" +
                        "From Rentals R, Customer C, Branch B" +
                        "Where C.Customer_ID = R.Customer_ID and R.Return_BID = B.BID and C.City != B.City);"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    reportgrid2.Rows.Clear();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            reportgrid2.Rows.Add(sdr["First_Name"].ToString(), sdr["Last_Name"].ToString());

                        }
                    }
                }
            }
        }

        private void report3_btn_Click(object sender, EventArgs e)//Brandons report
        {

            SqlConnection con = new SqlConnection(@"Data Source=" + myServer + ";Initial Catalog = " + myDatabase + ";Integrated Security=True");
            {
                //Find all customers who have not rented in a given month
                using (SqlCommand cmd = new SqlCommand("Select MONTH(R.Pick_Up_Date) as Month, C.Car_Type_ID as Category," +
                        "COUNT(R.Pick_Up_BID) as TOTAL from Rentals R, Car C" +
                        "WHERE R.VIN = C.VIN" +
                        "Group by MONTH(R.Pick_Up_Date), C.Car_Type_ID" +
                        "Order bY MONTH(R.Pick_Up_Date);"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    reportgrid3.Rows.Clear();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            reportgrid3.Rows.Add(sdr["Pick_Up_Date"].ToString(), sdr["Car_Type_ID"].ToString());
                        }
                    }
                }
            }
        }

        private void report4_btn_Click(object sender, EventArgs e)//Malcolms report
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + myServer + ";Initial Catalog = " + myDatabase + ";Integrated Security=True");
            {
                //Find all customers who have not rented in a given month
                using (SqlCommand cmd = new SqlCommand("(SELECT C.Customer_ID, First_Name, Middle_Name, Last_Name " +
                    "FROM Customer as C" +
                    "except" +
                    "SELECT C.Customer_ID, First_Name, Middle_Name, Last_Name" +
                    "FROM Customer as C, Rentals as R" +
                    "WHERE C.Customer_ID = R.Customer_ID and $MONTH$ = R.Pick_Up_Date); "))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    reportgrid4.Rows.Clear();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            reportgrid4.Rows.Add(sdr["Customer_ID"].ToString(), sdr["First_Name"].ToString(), sdr["Middle_Name"].ToString(), sdr["Last_Name"].ToString());
                        }
                    }
                }
            }

        }

        private void report5_btn_Click(object sender, EventArgs e)//Scotts report
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + myServer + ";Initial Catalog = " + myDatabase + ";Integrated Security=True");
            {
                //List the monthly rental transaction value for each branch.
                using (SqlCommand cmd = new SqlCommand("Select B.BID, B.Description, Year(R.Pick_Up_Date) as Year, Month(R.Pick_Up_Date) as Month, Sum(R.Total_Rent_Value) as Total_Rent_Value" +
                    "From Rentals as R, Branch as B" +
                    "Where R.Pick_Up_BID = B.BID" +
                    "Group By B.BID, B.Description, Year(R.Pick_Up_Date), Month(R.Pick_Up_Date); "))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    reportgrid5.Rows.Clear();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            reportgrid5.Rows.Add(sdr["BID"].ToString(), sdr["Description"].ToString(), sdr["Pick_Up_Date"].ToString(), sdr["Pick_Up_Date"].ToString(),sdr["Pick_Up_Date"].ToString());
                        }
                    }
                }
            }
        }

        private void reportgrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
