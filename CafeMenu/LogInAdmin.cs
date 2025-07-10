using Admin_Order;
using CafeMenu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenu
{
    public partial class LogInAdmin : Form
    {
        public LogInAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                this.Hide();
                AdminOverview adminOverview = new AdminOverview();
                adminOverview.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();


            Login Loginback = new Login();
            Loginback.ShowDialog();
            this.Close();
        }
    }
}
