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
        public SqlDataReader myReader;

        public Rentals()
        {
            InitializeComponent();

            //Change the server here for your guys' own servers
            String connectionString = "Server = DESKTOP-D7J3O0B; Database = 291_RentalDatabase; Trusted_Connection = yes;";

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

            //Fill Customer ID Dropdown Box with all Customer ID's in database. Used to assign a rental transaction to a customer.
            Fill_Customer_ID();
            Fill_Branches();
            Fill_Vehicle_Types();



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
    }
}
