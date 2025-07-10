using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu
{
    public static class LoginInfo
    {
        public static string UserID;
        public static string OrderType;
        public static string sqlCon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nisa\\source\\repos\\BNB\\CafeMenu\\BNBDatabase.mdf;Integrated Security=True";
     

        public static void InsertDataCustomer(string customerName, string phone, string ordertype)
        {
            // MessageBox.Show("menu " + menu + "   qty " + qty + "   price " + price);
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand cmd = new SqlCommand("insert into customer ( name, phone, ordertype) values ( @name, @phone, @ordertype)", con);
            con.Open();
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@name", customerName);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@ordertype", ordertype);
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                // MessageBox.Show(i + "Data Saved");
            }

        }

        public static void DeleteOrder(string customer)
        {
            // MessageBox.Show("menu " + menu + "   qty " + qty + "   price " + price);
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand cmd = new SqlCommand("delete from menu2 where  owner=@customer", con);
            con.Open();
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@customer", customer);

            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                // MessageBox.Show(i + "Data Saved");
            }

        }


    }
}
