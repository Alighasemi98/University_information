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

namespace University_information
{
    public partial class student_password : Form
    {
        public student_loading stulod;
        public loading loas;
        public student_password()
        {
            InitializeComponent();
            
            
           
        }

        private void che_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (che_show_password.Checked == true)
            {
                tex_password_pasword_student.UseSystemPasswordChar =false;
                tex_password2_password_student.UseSystemPasswordChar = false;
            }
            else
            {
                tex_password_pasword_student.UseSystemPasswordChar = true;
                tex_password2_password_student.UseSystemPasswordChar = true;
            }
        }

        private void but_ok_password_Click(object sender, EventArgs e)
        {
            string username = tex_username_password_student.Text;
            string password = tex_password_pasword_student.Text;
            string national = stulod.tex_national_id_student_lod.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO user_password (Name,Password,National_Code) VALUES ('" + username + "','" + password + "','" + national + "')";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            MessageBox.Show("با موفقیت انجام شد ", "موفق");
            con.Close();
            this.Hide();
           // loas.Show();//به خاطر این کد برنامه اجرا نمیشه 
           
            
        }
    }
}
