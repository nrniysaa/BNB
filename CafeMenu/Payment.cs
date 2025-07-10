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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            // pictureBoxQr.Visible = false;
            // groupBoxCard.Visible = false;
            // groupBox1.Visible = true;

            label4.Visible = true;
            pictureBoxQr.Visible = false;
        //    groupBox1.Visible = false;

        }
        private void Payment_Load(object sender, EventArgs e)
        {
            // Set permulaan
            // buttonConfirmPay.Enabled = false;
            //  pictureBoxQr.Visible = false;
            // groupBoxCard.Visible = false;

            pictureBoxQr.Visible = false;
            groupBoxCard.Visible = false;
         //   groupBox1.Visible = true;

        }


        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {

         //   label4.Visible = true;
          //  pictureBoxQr.Visible = false;
           // groupBox1.Visible = false;

            label4.Visible = true;
            groupBoxCard.Visible = false;
          //  groupBox1.Visible = false;
            pictureBoxQr.Visible = false;
            buttonConfirmPay.Visible = false;

            // pictureBoxQr.Visible = false;
            // groupBoxCard.Visible = false;
            // groupBox1.Visible = true;

            //if(radioButtonCash.Checked)
            //{
            //    buttonConfirmPay.Enabled = true;
            //    radioButtonCash.Enabled = true;
            //    radioButtonQr.Enabled = true;
            //    groupBoxCard.Visible = false; // Hide card group box when cash is selected
            //    pictureBoxQr.Visible = false; // Hide QR picture box when cash is selected
            //}
        }
        private void radioButtonCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCard.Checked)
            {
                buttonConfirmPay.Enabled = true;
                radioButtonCash.Enabled = true;
                radioButtonQr.Enabled = true;
                groupBoxCard.Visible = true;
                pictureBoxQr.Visible = false; // Hide QR picture box when card is selected
                buttonConfirmPay.Visible = true;

            }
        }
        private void radioButtonQr_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQr.Checked)
            {
                buttonConfirmPay.Enabled = true;
                radioButtonCash.Enabled = true;
                radioButtonQr.Enabled = true;
                pictureBoxQr.Visible = true;
                groupBoxCard.Visible = false; // Hide card group box when QR is selected
                buttonConfirmPay.Visible = false;
            }
        }

        private void pictureBoxQr_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonCard_CheckedChanged_1(object sender, EventArgs e)
        {
           // pictureBoxQr.Visible = false;
           // groupBoxCard.Visible = true;
           // groupBox1.Visible = false;

            label4.Visible = false;
            groupBoxCard.Visible = true;
          //  groupBox1.Visible = false;
            pictureBoxQr.Visible = false;
            buttonConfirmPay.Visible = true;

        }

        private void radioButtonQr_CheckedChanged_1(object sender, EventArgs e)
        {
            // pictureBoxQr.Visible = true;
            //  groupBoxCard.Visible = false;
            // groupBox1.Visible = false;

            label4.Visible = false;
            groupBoxCard.Visible = false;
            buttonConfirmPay.Visible = false;
            // groupBox1.Visible = true;
            pictureBoxQr.Visible = true;



        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxCard_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxQr_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonConfirmPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your order!\nYour waiting number is: 007", "Order Confirmed");
            this.Hide();


            Login backtoLogin = new Login();
            backtoLogin.ShowDialog();
            this.Close();
        }
    }
}
