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
using System.Data.SqlTypes;

namespace VLT_inventory
{
    public partial class ReceiveItem : Form
    {
        SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=vlt_inventoryDB;Integrated Security=True");
       
        public ReceiveItem()
        {
            InitializeComponent();
        }

        private void ReceiveItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vlt_inventoryDBDataSet.vlt_Master' table. You can move, or remove it, as needed.
            this.vlt_MasterTableAdapter.Fill(this.vlt_inventoryDBDataSet.vlt_Master);
            lbl_username.Text = Login.sendText;
        }
        //takes the user to the main navigation
        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home f1 = new Home();
            f1.ShowDialog();

            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            myConnection.Open();

            //if the user wants to search by itemID
            if (cmb_itemBox.SelectedIndex == 0)
            {

                string searchID = txt_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from dbo.vlt_Master where ItemID LIKE '%' + @search + '%'", myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", searchID);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            //if the user wants to search by Item Name
            if (cmb_itemBox.SelectedIndex == 1)
            {

                string searchID = txt_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from dbo.vlt_Master where Item_name LIKE '%' + @search + '%'", myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", searchID);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
               
            }
            //if the user wants to search by Manufacturer
            if (cmb_itemBox.SelectedIndex == 2)
            {

                string searchID = txt_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from dbo.vlt_Master where Manufacturer LIKE '%' + @search + '%'", myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", searchID);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            //if the user wants to search by Manufacturer ID
            if (cmb_itemBox.SelectedIndex == 3)
            {

                string searchID = txt_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from dbo.vlt_Master where Manufacturer_ID LIKE '%' + @search + '%'", myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", searchID);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //if the user wants to search by cost
            if (cmb_itemBox.SelectedIndex == 4)
            {

                string searchID = txt_search.Text;
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from dbo.vlt_Master where Cost LIKE '%' + @search + '%'", myConnection);
                adapter.SelectCommand.Parameters.AddWithValue("@search", searchID);

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            myConnection.Close();
        }
        //pulls the data from the datagrid view to the textboxes
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txt_itemID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txt_itemDescription.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txt_manufacturer.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            txt_manufacturerID.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string ItemID = txt_itemID.Text;
            string ItemName = txt_itemDescription.Text;
            string Manufacturer = txt_manufacturer.Text;
            string ManufacturerID = txt_manufacturerID.Text;
            string AmountUsed = num_amountRecieved.Text;
            string Tech = lbl_username.Text;
            // TODO string Cost = txt_cost.text;


            //pulls inventory from the new, repaired or damaged columns on the vlt_master table
            if (rdo_new.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.vlt_Master SET New = New + @used WHERE ItemID = @itemID", myConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@used", AmountUsed);
                    cmd.Parameters.AddWithValue("@itemID", ItemID);
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                    myConnection.Close();

                }

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO dbo.UsedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Used, Tech, Cost, [Repaired, Damaged or New], Date_Time) VALUES (@itemID, @itemName, @manufacturer,@manufacturerID, @used, @tech, 0, 'New', ('" + myDateTime + "'))", myConnection))
                {
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@itemID", ItemID);
                    cmd1.Parameters.AddWithValue("@itemName", ItemName);
                    cmd1.Parameters.AddWithValue("@manufacturer", Manufacturer);
                    cmd1.Parameters.AddWithValue("@manufacturerID", ManufacturerID);
                    cmd1.Parameters.AddWithValue("@used", AmountUsed);
                    cmd1.Parameters.AddWithValue("@tech", Tech);

                    myConnection.Open();
                    cmd1.ExecuteNonQuery();
                    myConnection.Close();

                    this.Hide();

                    UseItem f1 = new UseItem();
                    f1.ShowDialog();

                    this.Close();


                }
            }

            if (rdo_damaged.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.vlt_Master SET Damaged = Damaged + @used WHERE ItemID = @itemID", myConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@used", AmountUsed);
                    cmd.Parameters.AddWithValue("@itemID", ItemID);
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                    myConnection.Close();

                }

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO dbo.UsedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Used, Tech, Cost, [Repaired, Damaged or New], Date_Time) VALUES (@itemID, @itemName, @manufacturer,@manufacturerID, @used, @tech, 0, 'Damaged', ('" + myDateTime + "'))", myConnection))
                {
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@itemID", ItemID);
                    cmd1.Parameters.AddWithValue("@itemName", ItemName);
                    cmd1.Parameters.AddWithValue("@manufacturer", Manufacturer);
                    cmd1.Parameters.AddWithValue("@manufacturerID", ManufacturerID);
                    cmd1.Parameters.AddWithValue("@used", AmountUsed);
                    cmd1.Parameters.AddWithValue("@tech", Tech);

                    myConnection.Open();
                    cmd1.ExecuteNonQuery();
                    myConnection.Close();

                    this.Hide();

                    UseItem f1 = new UseItem();
                    f1.ShowDialog();

                    this.Close();


                }
            }

            if (rdo_repaired.Checked)
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE dbo.vlt_Master SET Repaired = Repaired + @used WHERE ItemID = @itemID", myConnection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@used", AmountUsed);
                    cmd.Parameters.AddWithValue("@itemID", ItemID);
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                    myConnection.Close();

                }

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                using (SqlCommand cmd1 = new SqlCommand("INSERT INTO dbo.UsedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Used, Tech, Cost, [Repaired, Damaged or New], Date_Time) VALUES (@itemID, @itemName, @manufacturer,@manufacturerID, @used, @tech, 0, 'Repaired', ('" + myDateTime + "'))", myConnection))
                {
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@itemID", ItemID);
                    cmd1.Parameters.AddWithValue("@itemName", ItemName);
                    cmd1.Parameters.AddWithValue("@manufacturer", Manufacturer);
                    cmd1.Parameters.AddWithValue("@manufacturerID", ManufacturerID);
                    cmd1.Parameters.AddWithValue("@used", AmountUsed);
                    cmd1.Parameters.AddWithValue("@tech", Tech);

                    myConnection.Open();
                    cmd1.ExecuteNonQuery();
                    myConnection.Close();

                    this.Hide();

                    UseItem f1 = new UseItem();
                    f1.ShowDialog();

                    this.Close();


                }
            }
        }
        //clears out all of the text fields
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_search.Text = String.Empty;
            txt_itemID.Text = String.Empty;
            txt_itemDescription.Text = String.Empty;
            txt_manufacturer.Text = String.Empty;
            txt_manufacturerID.Text = String.Empty;
        }

        
    }
}
