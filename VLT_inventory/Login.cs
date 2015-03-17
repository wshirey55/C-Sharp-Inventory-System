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
   
    public partial class Login : Form
    {
             

        public Login()
        {
            InitializeComponent();
        }


        public static string sendText = "";
        public void btn_login_Click(object sender, EventArgs e)
        {   //data string to open sql server connection
            SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=vlt_inventoryDB;Integrated Security=True");
           
            try
            { 
                //open conection to read login information
                myConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from dbo.Users where User_Name = '" + txt_login.Text +"' and Password = '" + txt_password.Text + "'", myConnection);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                
                int count = 0;
                while (dr.Read())
                    {
                        count ++;
                    }

                if (count == 1)
                     {
                         this.Hide();
                         myConnection.Close();

                         sendText = txt_login.Text;
                         MasterList m1 = new MasterList();
                         ReceiveItem r1 = new ReceiveItem();
                         UseItem u1 = new UseItem();
                         Home f1 = new Home();
                         f1.ShowDialog();

                        

                         myConnection.Open();

                         SqlCommand access = new SqlCommand("SELECT Access from dbo.Users WHERE User_Name = '" + txt_login.Text + "'", myConnection);

                         userAccess = (int)access.ExecuteScalar();
                         myConnection.Close();


                         
                            

                        

                         this.Close();

                        
                        
                  

                        
                     }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate username and password. Please contact your system admin.");
                }

                else
                {
                    MessageBox.Show("Username and/or Password is incorrect.");
                }

            }

                catch(SqlException ex)
            {
                    MessageBox.Show("You Failed"+ ex.Message);
                }
            }
       


        private void btn_quickCheck_Click(object sender, EventArgs e)
        {
            this.Hide();

        QuickCheck f1 = new QuickCheck();
            f1.ShowDialog();

            this.Close();
            
        }

        


        private void lbl_access_Click(object sender, EventArgs e)
        {
          
        }


        public static int userAccess { get; set; }
    }
    }

