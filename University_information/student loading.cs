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
    public partial class student_loading : Form
    {
        student_password stupas = new student_password();
        public create crstu;
        public student_loading()
        {
            InitializeComponent();
            stupas.stulod = this;
        }

        private void but_ok_student_lod_Click(object sender, EventArgs e)
        {
            string name = tex_name_student_lod.Text;
            string family = tex_family_student_lod.Text;
            string number = tex_number_student_lod.Text;
            string age = tex_age_student_lod.Text;
            string national = tex_national_id_student_lod.Text;
            string student_id = tex_student_id_student_lod.Text;
            string height = tex_height_student_lod.Text;
            string weight =tex_weight_student_lod.Text;
            string sex = comboBox1.Text;
            //برای تمام تکست باکس ها کامل شود 
           /* if (tex_name_student_lod != null)
            {
                MessageBox.Show("فیاد نام نمیتواند خالی باشد ");
            }*/
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO student (Name,Family,Number,Age,National_Code,Student_ID,Height,Weight,Sex) VALUES ('" + name + "','" + family + "','" + number + "','" + age + "','" + national + "','" + student_id + "','" + height + "','" + weight + "','" + sex + "')";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("با موفقیت افزوده شد ", "موفق");
            this.Hide();
            stupas.Show();
           

        }

        private void but_previous_student_Click(object sender, EventArgs e)
        {
           
            DialogResult dr = new DialogResult();
           dr = MessageBox.Show("ایا مطمعا هستید ؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Show();
            }
            else
            {  
                crstu.Show(); 
                this.Hide();
            }
        }
    }
}
