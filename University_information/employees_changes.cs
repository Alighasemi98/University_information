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
using System.Xml.Linq;

namespace University_information
{
    public partial class employees_changes : Form
    {
        public employees_changes()
        {
            InitializeComponent();
        }
        //for delete 
        private void but_dehete_Click(object sender, EventArgs e)
        {
            string name = com_delete.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM Employees WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت حذف شد", "موفق");

        }
        //lode combobox
        private void employees_changes_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT Name FROM Employees";
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader["name"].ToString();
                com_delete.Items.Add(name);
                com_name_up.Items.Add(name);
            }

            sc.Close();

        }
       //  for add
        private void button1_Click(object sender, EventArgs e)
        {

            string name = tex_name_add.Text;
            string family = tex_famihy_add.Text;
            string age = tex_age_add.Text;
            string number = tex_number_add.Text;
            string national = tex_national_add.Text;
            string level = tex_level_add.Text;
            string height = tex_height_add.Text;
            string weight = tex_weight_add.Text;
            string sex = com_sex_add.Text;
            string work = tex_work_add.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "INSERT INTO Employees (Name,Family,National_Code,Age,Level_of_education,Height,Weight,Sex,work_department,Number) VALUES ('"+ name +"','"+ family +"','"+ national +"','"+ age +"','"+ level +"','"+ height +"','"+ weight +"','"+ sex +"','"+ work +"','"+ number +"')";
            SqlCommand command = new SqlCommand(query, se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد", "موفق");
            tex_age_add = tex_famihy_add = tex_height_add = tex_level_add = tex_name_add = tex_national_add = tex_number_add = tex_weight_add = tex_work_add = null;
        }
        // for update
        private void but_ok_emp_lod_Click(object sender, EventArgs e)
        {
            string name = com_name_up.Text;
            string family = text_family_emp_up.Text;
            string age = text_age_emp_up.Text;
            string number = text_number_emp_up.Text;
            string national = text_national_emp_up.Text;
            string level = text_level_emp_up.Text;
            string height = text_height_emp_up.Text;
            string weight = text_weight_emp_up.Text;
            string sex = com_sex_up.Text;
            string work = text_work_emp_up.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE Employees SET Family='" + family + "',National_Code='"+ national+"',Age='" + age + "',Level_of_education='"+ level +"',Height='" + height + "',Weight='" + weight + "',Sex='" + sex + "',work_department='"+ work+"',Number='"+ number +"'   WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            text_level_emp_up = text_age_emp_up = text_family_emp_up = text_height_emp_up = text_national_emp_up = text_number_emp_up = text_weight_emp_up = text_work_emp_up = null;

        }
    }
}
