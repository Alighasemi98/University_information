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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University_information
{
    public partial class student_Changes : Form
    {
        public item_selection itemm;
        public student_Changes()
        {
            InitializeComponent();
        }


        //for add
        private void but_ok_student_lod_Click(object sender, EventArgs e)
        {
            string name = tex_name_student_add_ch.Text;
            string family = tex_family_student_add_ch.Text;
            string age = tex_age_student_add_ch.Text;
            string number = tex_number_student_add_ch.Text;
            string national = tex_national_id_student_add_ch.Text;
            string student = tex_student_id_student_add_ch.Text;
            string height = tex_height_student_add_ch.Text;
            string weight = tex_weight_student_add_ch.Text;
            string sex = com_sex_student_add_ch.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "INSERT INTO student (Name,Family,Number,Age,National_Code,Student_ID,Height,Weight,Sex) VALUES ('" + name + "','" + family + "','" + number + "','" + age + "','" + national + "','" + student + "','" + height + "','" + weight + "','" + sex + "')";
            SqlCommand command = new SqlCommand(query, se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد", "موفق");
            tex_name_student_add_ch = tex_family_student_add_ch = tex_age_student_add_ch = tex_number_student_add_ch = tex_national_id_student_add_ch = tex_student_id_student_add_ch = tex_weight_student_add_ch = tex_height_student_add_ch = null;


        }
        //for delete
        private void but_student_delete_ch_Click(object sender, EventArgs e)
        {
            string name = com_name_student_del_ch.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM student WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت حذف شد", "موفق");
        }
        //lode combobox
        private void student_Changes_Load(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT Name FROM student";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                com_name_student_del_ch.Items.Add(name);
                com_name_student_up_ch.Items.Add(name);
            }

            sc.Close();
        }
        //for update
        private void button2_Click(object sender, EventArgs e)
        {
            string name = com_name_student_up_ch.SelectedItem.ToString();
            string family = tex_family_student_up_ch.Text;
            string age = tex_age_student_up_ch.Text;
            string number = tex_number_student_up_ch.Text;
            string national = tex_national_student_up_ch.Text;
            string student = tex_student_id_student_up_ch.Text;
            string height = tex_height_student_up_ch.Text;
            string weight = tex_weight_student_up_ch.Text;
            string sex = com_sex_student_up_ch.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE student SET Family='" + family + "',Number='" + number + "',Age='" + age + "',National_Code='" + national + "',Student_ID='" + student + "',Height='" + height + "',Weight='" + weight + "',Sex='" + sex + "'   WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            tex_family_student_up_ch = tex_age_student_up_ch = tex_number_student_up_ch = tex_national_student_up_ch = tex_student_id_student_add_ch = tex_weight_student_up_ch = tex_height_student_up_ch = null;
        }

    }
}
