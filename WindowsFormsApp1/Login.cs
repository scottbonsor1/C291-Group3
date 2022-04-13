using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /**
     * This is the Login form. It lets users choose between a customer login and an employee login
     */

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //go to customer login
        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rentals f1 = new Rentals();
            f1.ShowDialog();
            this.Close();
        }

        //go to employee login
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin f1 = new EmployeeLogin();
            f1.ShowDialog();
            this.Close();
        }
    }
}
