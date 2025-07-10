using CafeMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brotbohneCafe
{
    public partial class OrderSummary : Form
    {
        string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nisa\\source\\repos\\BNB\\CafeMenu\\BNBDatabase.mdf;Integrated Security=True";
        public OrderSummary()
        {
            InitializeComponent();
            listView1.ColumnWidthChanging += listView1_ColumnWidthChanging;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void lbNamaCafe_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label16_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Payment payment = new Payment();
            payment.ShowDialog();

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string currentCustomer = LoginInfo.UserID; // use your login tracking
            LoadSummary(currentCustomer);
        }

        private void LoadSummary(string customer)
        {
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                con.Open();

                string query = @"
                    SELECT
                        menuid AS ItemName,
                        quantity AS Quantity,
                        price AS TotalPrice,
                        price / quantity AS UnitPrice
                    FROM menu2
                    WHERE owner = @customer
                    ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@customer", customer);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                listView1.Clear();
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                listView1.GridLines = true;

                // Create and add ColumnHeader objects for better control
                ColumnHeader menuHeader = new ColumnHeader();
                menuHeader.Text = "MENU";
                menuHeader.Width = 150;
                menuHeader.TextAlign = HorizontalAlignment.Left; // Keep MENU header left-aligned as per image

                ColumnHeader quantityHeader = new ColumnHeader();
                quantityHeader.Text = "QTY"; // Changed to QTY to match image
                quantityHeader.Width = 70;
                quantityHeader.TextAlign = HorizontalAlignment.Center; // Center QTY header

                ColumnHeader priceHeader = new ColumnHeader();
                priceHeader.Text = "PRICE (RM)";
                priceHeader.Width = 150;
                priceHeader.TextAlign = HorizontalAlignment.Center; // Center PRICE header

                ColumnHeader totalHeader = new ColumnHeader();
                totalHeader.Text = "TOTAL (RM)";
                totalHeader.Width = 150;
                totalHeader.TextAlign = HorizontalAlignment.Center; // Center TOTAL header

                listView1.Columns.AddRange(new ColumnHeader[] { menuHeader, quantityHeader, priceHeader, totalHeader });

                // Fill ListView rows
                decimal subtotal = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string itemName = row["ItemName"].ToString();
                    string quantity = row["Quantity"].ToString();
                    decimal totalAmount = Convert.ToDecimal(row["TotalPrice"]); // Stored total
                    decimal qty = Convert.ToDecimal(row["Quantity"]);
                    decimal unitPrice = totalAmount / qty;

                    
                    string price = unitPrice.ToString("0.00");
                    string amount = totalAmount.ToString("0.00");

                    subtotal += totalAmount;


                    ListViewItem item = new ListViewItem(itemName); // First subitem aligns with header's TextAlign
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, quantity)); // QTY
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, price));   // PRICE (RM)
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, amount));  // TOTAL (RM)

                    listView1.Items.Add(item);
                }

                // Important: After adding items, iterate through subitems to set their alignment
                foreach (ListViewItem item in listView1.Items)
                {
                    // ItemName (column 0) remains left-aligned by default with ListViewItem constructor
                    // QTY (column 1) also remains left-aligned unless explicitly styled per subitem.
                    // To align quantity right, we need to explicitly create the subitem
                    // However, for numeric types, TextAlign of the header also affects the subitems.
                    // Let's re-verify the behavior. For now, rely on header.TextAlign first.
                    // If subitems don't align, we'd need custom drawing or a DataGridView.
                }


                // Labels
                lbDate.Text = "DATE: " + DateTime.Now.ToString("dd-MM-yyyy");
                lbTime.Text = "TIME: " + DateTime.Now.ToString("HH:mm");
                lbProductname.Text = "NAME: " + customer;
                label17.Text = subtotal.ToString("0.00");

                double taxpay = 0.05 * double.Parse(label17.Text);
                label5.Text = taxpay.ToString("0.00");

                double netpay = taxpay + double.Parse(label17.Text);
                label6.Text = netpay.ToString("0.00");
                label7.Text = "" + LoginInfo.OrderType;
            }
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true; // cancel the resize
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width; // retain original width
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty event handler
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void lbProductname_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to cancel order?", "Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // delete order cancel
                LoginInfo.DeleteOrder(LoginInfo.UserID);
                this.Hide();
                Form2Menu summary = new Form2Menu();
                summary.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Do nothing if not cancelling
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }
    }
}