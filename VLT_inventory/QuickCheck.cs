using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VLT_inventory
{
    public partial class QuickCheck : Form
    {
        SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=vlt_inventoryDB;Integrated Security=True");
        public QuickCheck()
        {
            InitializeComponent();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            myConnection.Open();

            //if the user wants to search by itemID
            if (cmb_itemBox.SelectedIndex == 0)
            {
                string itemID = txt_search.Text;

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where ItemID like '%' + @itemID + '%'";
                cmd.Parameters.AddWithValue("@itemID", itemID);

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;



            }
            //if the user wants to search by Item Name
            if (cmb_itemBox.SelectedIndex == 1)
            {
                string itemName = txt_search.Text;

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Item_Name like '%' +@itemName + '%'";
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // myConnection.Close();
            }
            //if the user wants to search by Manufacturer
            if (cmb_itemBox.SelectedIndex == 2)
            {
                string manufacturer = txt_search.Text;

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Manufacturer like '%' + @manufacturer + '%'";
                cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //if the user wants to search by Manufacturer ID
            if (cmb_itemBox.SelectedIndex == 3)
            {
                string manufactuereID = txt_search.Text;

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Manufacturer_ID like '%' + @manufacturerID '%'";
                cmd.Parameters.AddWithValue("@manufacturer", manufactuereID);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //if the user wants to search by cost
            if (cmb_itemBox.SelectedIndex == 4)
            {
                string cost = txt_search.Text;

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Cost like '%' + @cost + '%'";
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login f1 = new Login();
            f1.ShowDialog();

            this.Close();
        }
    }
}
