using CafeMenu;
using CafeMenu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Admin_Order
{
    public partial class AdminOverview : Form
    {
        public AdminOverview()
        {
            InitializeComponent();
            InitList();
            LoadSummary();
        }
        public void InitList()
        {
            listView1.View = View.Details;

            listView1.Columns.Add("No.");
            listView1.Columns.Add("Menu");
            listView1.Columns.Add("Total Order");
            listView1.Columns.Add("Total Order Price (RM)");
            listView1.Columns[0].Width = 50;    // number
            listView1.Columns[1].Width = 200;   // Menu
            listView1.Columns[2].Width = 150;    // Qty
            listView1.Columns[3].Width = 200;
            listView1.OwnerDraw = true;
            listView1.DrawColumnHeader += ListView1_DrawColumnHeader;
            listView1.DrawItem += ListView1_DrawItem;
            listView1.DrawSubItem += ListView1_DrawSubItem;
            listView1.ColumnWidthChanging += listView1_ColumnWidthChanging;


        }



        private  void LoadSummary()
        {
            using (SqlConnection con = new SqlConnection(LoginInfo.sqlCon))
            {
                con.Open();

                string query = @"
SELECT 
    a.menuid,
    SUM(a.quantity) AS total_quantity,
    SUM(a.quantity * b.price) AS total_order
FROM 
    menu2 AS a
JOIN 
    menu_detail AS b ON a.menuid = b.menuid
GROUP BY 
    a.menuid
ORDER BY 
total_quantity DESC";



                SqlCommand cmd = new SqlCommand(query, con);
              //cmd.Parameters.AddWithValue("@mydate", dateTimePicker1.Value.Date);
              //  cmd.Parameters.AddWithValue("@mydate", "25/6/2025");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

            

                // Subtotal Calculation
                //decimal subtotal = 0;
                int number = 1;
                foreach (DataRow row in dt.Rows)
                {
                    //subtotal += Convert.ToDecimal(row["Price"]);
                    listView1.Items.Add(new ListViewItem(new string[] { number.ToString(),row["MenuID"].ToString(), row["total_quantity"].ToString(), row["total_order"].ToString() }));
                    number++;

                }
                //MessageBox.Show("Total: RM " + subtotal.ToString("0.00"));
                //  lbDate.Text = "DATE: " + DateTime.Now.ToString("dd-MM-yyyy");
                //   lbTime.Text = "TIME: " + DateTime.Now.ToString("HH:mm:ss");
                //  lbProductname.Text = "NAME: " + customer;
              //  label17.Text = subtotal.ToString("0.00"); // Total
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            Color headerBackground = Color.FromArgb(128, 64, 0); // Dark brown
            Color headerBorder = Color.DarkGoldenrod;
            Color headerText = Color.White;

            using (SolidBrush backBrush = new SolidBrush(headerBackground))
            using (Pen borderPen = new Pen(headerBorder))
            using (SolidBrush textBrush = new SolidBrush(headerText))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
                e.Graphics.DrawRectangle(borderPen, e.Bounds);
                e.Graphics.DrawString(e.Header.Text, listView1.Font, textBrush, e.Bounds);
            }
        }

        private void ListView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void ListView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Prevent column resize
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();


            Login Loginback = new Login();
            Loginback.ShowDialog();
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
           // MessageBox.Show("You are in the DateTimePicker.ValueChanged event." + dateTimePicker1.Value);
       // }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();


            LogInAdmin LogInAdmin = new LogInAdmin();
            LogInAdmin.ShowDialog();
            this.Close();
        }
    }
}
