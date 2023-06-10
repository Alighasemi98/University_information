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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_information
{
    public partial class loading : Form
    {
        item_selection itemi = new item_selection();
        create dr = new create();
        public loading()
        {
            InitializeComponent();
            dr.lod = this;
            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox1.Checked == true )
            { 
               tex_password_lod.UseSystemPasswordChar = false;
            }
            else
            {
               tex_password_lod.UseSystemPasswordChar = true;
            }
          

        }

        private void but_login_lod_Click(object sender, EventArgs e)
        {
            dr.Show();
            this.Hide();
        }

        private void but_ok_lod_Click(object sender, EventArgs e)
        {
            try
           {
                string un = tex_username_lod.Text;
                string pa = tex_password_lod.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT password FROM user_password WHERE Name='" + un + "'", sc);
                //SqlCommand comm2 = new SqlCommand("SELECT password FROM master_password WHERE Name='" + un + "'", sc);
                //SqlCommand comm3 = new SqlCommand("SELECT password FROM Emoployees_password WHERE Name='" + un + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                //SqlDataReader reader2 = comm2.ExecuteReader();
                //SqlDataReader reader3 = comm3.ExecuteReader();
                reader.Read();
                //reader2.Read();
               //reader3.Read();
                string pass = reader["password"].ToString();
                //string pass2 = reader2["password"].ToString();
                //string pass3 = reader3["password"].ToString();
                if (pa == pass)
                {
                    itemi.Show();
                    this.Hide();
                }
                /* else if(pa == pass2)
                {
                    itemii.Show();
                    this.Hide();
                }
                else if(pa==pass3)
                {
                    itemiii.Show();
                    this.Hide();
                }*/
                else 
                MessageBox.Show("Incorrect");
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

















        }
    }
}
