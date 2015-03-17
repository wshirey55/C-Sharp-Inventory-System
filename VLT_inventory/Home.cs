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
           
    public partial class Home : Form
    {   //data string to open sql server connection
        SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=vlt_inventoryDB;Integrated Security=True");
       
        public Home()
        {
            InitializeComponent();
            
        }
        

        private void btn_useItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            UseItem f2 = new UseItem();
            f2.ShowDialog();

            this.Close();
        }

        private void btn_recieveItem_Click(object sender, EventArgs e)
        {
            this.Hide();

           ReceiveItem f2 = new ReceiveItem();
            f2.ShowDialog();

            this.Close();
        }
        
        private int userAccess = 0;
        private void btn_masterList_Click(object sender, EventArgs e)
        {
             
            myConnection.Open();

            SqlCommand access = new SqlCommand("SELECT Access from dbo.Users WHERE User_Name = '" + lbl_username.Text + "'", myConnection);

            userAccess = (int)access.ExecuteScalar();
            myConnection.Close();


            if (userAccess == 2)
            {
                this.Hide();

                MasterList f2 = new MasterList();
                f2.ShowDialog();

                this.Close();

            }

            else
            {
               MessageBox.Show("Sorry. You do not have access to this");
            }
        }

  

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_username.Text = Login.sendText;
        }

        
        }
   
}


