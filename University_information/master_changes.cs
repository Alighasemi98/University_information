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
    public partial class master_changes : Form
    {
        public master_changes()
        {
            InitializeComponent();
        }
        //for delete
        private void but_delete_Click(object sender, EventArgs e)
        {
            string name = com_delete.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM Master WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت حذف شد", "موفق");
        }
        //lode combobox
        private void master_changes_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT Name FROM Master";
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
        //for update
        private void but_update_Click(object sender, EventArgs e)
        {
            string name = com_name_up.SelectedItem.ToString();
            string family = tex_family_up.Text;
            string age =tex_age_up.Text;
            string number = tex_number_up.Text;
            string national = tex_national_up.Text;
            string field = tex_field_up.Text;
            string height = tex_height_up.Text;
            string weight = tex_weight_up.Text;
            string sex = com_sex_up.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();

            string query = "UPDATE Master SET Family='" + family + "',Number='" + number + "',Age='" + age + "',National_Code='" + national + "',Field='" + field + "',Height='" + height + "',Weight='" + weight + "',Sex='" + sex + "'   WHERE Name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            tex_age_up = tex_family_up = tex_field_up = tex_height_up = tex_national_up = tex_number_up = tex_weight_up = null;
        }
        //for add
        private void but_add_Click(object sender, EventArgs e)
        {
            string name = tex_name_master_add.Text;
            string family =tex_family_master_add.Text;
            string age = tex_age_master_add.Text;
            string number = tex_number_master_add.Text;
            string national = tex_national_master_add.Text;
            string field = tex_field_master_add.Text;
            string height = tex_height_master_add.Text;
            string weight = tex_weight_master_add.Text;
            string sex = com_sex_add.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "INSERT INTO Master (Name,Family,Number,Age,National_Code,Field,Height,Weight,Sex) VALUES ('" + name + "','" + family + "','" + number + "','" + age + "','" + national + "','" + field + "','" + height + "','" + weight + "','" + sex + "')";
            SqlCommand command = new SqlCommand(query, se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد", "موفق");
            tex_age_master_add = tex_family_master_add = tex_field_master_add = tex_height_master_add = tex_name_master_add = tex_national_master_add = tex_number_master_add = tex_weight_master_add = null;
        }
    }
}
