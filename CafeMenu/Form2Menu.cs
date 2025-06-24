using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeMenu
{
    public partial class Form2Menu : Form
    {
        double totalAmount = 0;
        string sqlCon = "";
        public Form2Menu()
        {
            InitializeComponent();
            InitList();




            sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nisa\\source\\repos\\BNB\\CafeMenu\\Cafe_Database.mdf;Integrated Security=True";
           // string query = "SELECT * FROM Pizza WHERE PizzaID LIKE 'CP%' AND Description LIKE @SearchText";

          //  using (SqlConnection connection = new SqlConnection(connectionString))
           // {
            //    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
             //   {
                //    dataAdapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                 //   DataSet dataSet = new DataSet();
                 //   dataAdapter.Fill(dataSet, "Pizza");
                //    dataGridViewCirclePizza.DataSource = dataSet.Tables["Pizza"];
               // }
           // }

        }
        public void InitList()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Item");
            listView1.Columns.Add("Qty");
            listView1.Columns.Add("Price");


            listView1.SmallImageList = imageList1;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2Menu_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddHLatte_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Iced Chocolate")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 7.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();

     }


        private void button2_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Iced Chocolate")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 7.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Iced Chocolate", "1", "7.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Strawberry Soda")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 6.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Strawberry Soda")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 6.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Strawberry Soda", "1", "6.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnAddHLatte_Click_1(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Hot Latte")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 5.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {
                
                listView1.Items.Add(new ListViewItem(new string[] { "Hot Latte", "1", "5.90" }));
                listView1.Items[listView1.Items.Count-1].ImageIndex = 0;

            }
            GetTotal();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemHLatte_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Hot Latte")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0") {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 5.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }
          
            GetTotal();
        }

        private void btnAddMatcha_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Matcha Latte")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 5.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Matcha Latte", "1", "5.90"}));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemMatchaLatte_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Matcha Latte")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 5.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();




          
        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Choco Croissant")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 5.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Choco Croissant")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 5.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Choco Croissant", "1", "5.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();


        }

        private void button9_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Milk Brioche")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 6.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();

         
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Milk Brioche")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 6.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Milk Brioche", "1", "6.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();


         
        }
        public void GetTotal()
        {
            double total = 0;
            double newprice = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
               // for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {

         
                        newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) ;
                      //  int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        total = total + newprice;
                   

                }
          
            }
            label19.Text = total.ToString("0.00"); 
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;

            //string s = this.listView1.SelectedItems[0].Text;
            // MessageBox.Show("ddd" + s);
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {

                    DialogResult dialogResult = MessageBox.Show("Sure delete record " + listView1.Items[i].SubItems[0].Text, "Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        listView1.Items[i].Remove();
                        break;

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }

                }


            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure confirm Order " , "Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                        InsertDataToDatabase(listView1.Items[i].SubItems[0].Text, listView1.Items[i].SubItems[1].Text, listView1.Items[i].SubItems[2].Text);
    
                   
                }


            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        public void InsertDataToDatabase(string menu, string qty, string price)
        {
            MessageBox.Show("menu " + menu + "   qty " + qty + "   price " + price);
            //SqlConnection con = new SqlConnection(sqlCon);
            //SqlCommand cmd = new SqlCommand("insert into menu (menu, qty,price) values (@menu, @qty,@price)", con);
            //con.Open();
            //cmd.Connection = con;
            //cmd.Parameters.AddWithValue("@menu", menu);
            //cmd.Parameters.AddWithValue("@qty", qty);
            //cmd.Parameters.AddWithValue("@price", price);
            //int i = cmd.ExecuteNonQuery();

            //con.Close();

            //if (i != 0)
            //{
            //    MessageBox.Show(i + "Data Saved");
            //}

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Chicken Pie")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 10.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Mascarpon Puff")
                    {
                        found = "1";
                        if (listView1.Items[i].SubItems[1].Text == "0")
                        {

                        }
                        else
                        {
                            double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) - 4.90;
                            int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) - 1;
                            listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                            listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        }
                        break;
                    }

                }
                if (found == "1") { break; }
            }

            GetTotal();

        }

        private void button14_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Chicken Pie")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 10.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Chicken Pie", "1", "10.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();

          
        }

        private void button12_Click(object sender, EventArgs e)
        {

            string found = "0";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int k = 0; k < listView1.Items[i].SubItems.Count; k++)
                {
                    if (listView1.Items[i].SubItems[0].Text == "Mascarpon Puff")
                    {
                        found = "1";
                        double newprice = double.Parse(listView1.Items[i].SubItems[2].Text, System.Globalization.CultureInfo.InvariantCulture) + 4.90;
                        int qtynew = Int32.Parse(listView1.Items[i].SubItems[1].Text) + 1;
                        listView1.Items[i].SubItems[1].Text = qtynew.ToString();
                        listView1.Items[i].SubItems[2].Text = newprice.ToString("0.00");
                        break;
                    }

                }
                if (found == "1") { break; }
            }
            if (found == "0")
            {

                listView1.Items.Add(new ListViewItem(new string[] { "Mascarpon Puff", "1", "4.90" }));
                listView1.Items[listView1.Items.Count - 1].ImageIndex = 0;

            }
            GetTotal();

         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            label19.Text = "0.00";
            InitList();
        }
    }
}
