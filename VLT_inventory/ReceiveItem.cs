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

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where ItemID like ('" + txt_search.Text + "%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;



            }
            //if the user wants to search by Item Name
            if (cmb_itemBox.SelectedIndex == 1)
            {

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Item_Name like ('" + txt_search.Text + "%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // myConnection.Close();
            }
            //if the user wants to search by Manufacturer
            if (cmb_itemBox.SelectedIndex == 2)
            {

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Manufacturer like ('" + txt_search.Text + "%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //if the user wants to search by Manufacturer ID
            if (cmb_itemBox.SelectedIndex == 3)
            {

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Manufacturer_ID like ('" + txt_search.Text + "%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            //if the user wants to search by cost
            if (cmb_itemBox.SelectedIndex == 4)
            {

                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dbo.vlt_Master where Cost like ('" + txt_search.Text + "%')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
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
            //pulls inventory from the new, repaired or damaged columns on the vlt_master table
            if (rdo_new.Checked)
            {
                myConnection.Open();
                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update dbo.vlt_Master SET New = New + ('" + num_amountUsed.Text + "') WHERE ItemID = ('" + txt_itemID.Text + "')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                myConnection.Open();
                SqlCommand cmd2 = myConnection.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "INSERT INTO dbo.RecievedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Recieved, Tech, Cost, [Repaired, Damaged, or New], Date_Time) VALUES (('" + txt_itemID.Text + "'),('" + txt_itemDescription.Text + "'),('" + txt_manufacturer.Text + "'),('" + txt_manufacturerID.Text + "'), ('" + num_amountUsed.Text + "'),('" + lbl_username.Text + "'), 0, 'New', ('" + myDateTime + "'))";
                cmd2.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                this.Hide();

                ReceiveItem f1 = new ReceiveItem();
                f1.ShowDialog();

                this.Close();


            }

            if (rdo_damaged.Checked)
            {
                myConnection.Open();
                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update dbo.vlt_Master SET Damaged = Damaged + ('" + num_amountUsed.Text + "') WHERE ItemID = ('" + txt_itemID.Text + "')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                myConnection.Open();
                SqlCommand cmd2 = myConnection.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "INSERT INTO dbo.RecievedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Recieved, Tech, Cost, [Repaired, Damaged, or New], Date_Time) VALUES (('" + txt_itemID.Text + "'),('" + txt_itemDescription.Text + "'),('" + txt_manufacturer.Text + "'),('" + txt_manufacturerID.Text + "'), ('" + num_amountUsed.Text + "'),('" + lbl_username.Text + "'), 0, 'Damaged', ('" + myDateTime + "'))";
                cmd2.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                this.Hide();

                ReceiveItem f1 = new ReceiveItem();
                f1.ShowDialog();

                this.Close();
            }

            if (rdo_repaired.Checked)
            {
                myConnection.Open();
                SqlCommand cmd = myConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update dbo.vlt_Master SET Repaired = Repaired + ('" + num_amountUsed.Text + "') WHERE ItemID = ('" + txt_itemID.Text + "')";
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                //gets date and time for TimeStamp.
                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");

                //creates the record of item used in the UsedLog table.
                myConnection.Open();
                SqlCommand cmd2 = myConnection.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "INSERT INTO dbo.RecievedLog (ItemID, Item_Name, Manufacturer, Manufacturer_ID, Amount_Recieved, Tech, Cost, [Repaired, Damaged, or New], Date_Time) VALUES (('" + txt_itemID.Text + "'),('" + txt_itemDescription.Text + "'),('" + txt_manufacturer.Text + "'),('" + txt_manufacturerID.Text + "'), ('" + num_amountUsed.Text + "'),('" + lbl_username.Text + "'), 0, 'Repaired', ('" + myDateTime + "'))";
                cmd2.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                myConnection.Close();

                this.Hide();

                ReceiveItem f1 = new ReceiveItem();
                f1.ShowDialog();

                this.Close();
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
