using Admin_Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeMenu.Properties
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBx_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            this.Hide();
            LoginInfo.UserID = txtBxName.Text;
            LoginInfo.OrderType= "Take Away";
            LoginInfo.InsertDataCustomer(txtBxName.Text, textBox2.Text, "Take Away");

            Form2Menu menuForm = new Form2Menu();
            menuForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
                return;

            this.Hide();
            LoginInfo.UserID = txtBxName.Text;
            LoginInfo.OrderType = "Dine In";
            LoginInfo.InsertDataCustomer(txtBxName.Text, textBox2.Text, "Dine In");

            Form2Menu menuForm = new Form2Menu();
            menuForm.ShowDialog();
            this.Close();
        }





        private void Login_Load(object sender, EventArgs e)
        { 
        
        }

            private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtBxName.Text))
            {
                MessageBox.Show("Please enter your name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter your contact number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate contact number is digits only and 10–15 characters
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^\d{10,15}$"))
            {
                MessageBox.Show("Contact number must be digits only and between 10 to 15 characters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

  

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();


            LogInAdmin LogInAdmin = new LogInAdmin();
            LogInAdmin.ShowDialog();
            this.Close();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

