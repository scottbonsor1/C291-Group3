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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers f1 = new Customers();
            f1.ShowDialog();
            this.Close();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin f1 = new EmployeeLogin();
            f1.ShowDialog();
            this.Close();
        }
    }
}
