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
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee f1 = new Employee();
            f1.ShowDialog();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
            this.Close();
        }
    }
}
