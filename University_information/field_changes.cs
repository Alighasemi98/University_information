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
    public partial class field_changes : Form
    {
        public field_changes()
        {
            InitializeComponent();
        }
        //for delete
        private void butdelete_Click(object sender, EventArgs e)
        {
            string name = comdelete.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM Field WHERE field_name='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت حذف شد", "موفق");
        }
        //loding combobox
        private void field_changes_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT field_name FROM Field";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["field_name"].ToString();
                comfieldup.Items.Add(name);
                comdelete.Items.Add(name);
            }

            sc.Close();
        }
        //for update
        private void button1_Click(object sender, EventArgs e)
        {
            string name = comfieldup.SelectedItem.ToString();
            string stringg = tex_string_up.Text;
            string total = tex_total_up.Text;
            string general = tex_general_up.Text;
            string specialized = tex_specialized_up.Text;
            string student = tex_student_up.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "UPDATE Field SET String_code='"+ stringg +"',Total_number_of_lessons='"+ total +"',General_number='"+ general +"',Specialized_number='"+ specialized +"',Number_of_students='"+ student +"' WHERE field_name='"+ name +"'";
            SqlCommand command = new SqlCommand(query,se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            tex_general_up = tex_specialized_up = tex_string_up = tex_student_up = tex_total_up = null;
        }
        //for add
        private void butadd_Click(object sender, EventArgs e)
        {
            string name = tex_field_add.Text;
            string stringg = tex_string_add.Text;
            string total = tex_total_add.Text;
            string general = tex_general_add.Text;
            string specialized = tex_specialized_add.Text;
            string student = tex_student_add.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "INSERT INTO Field (field_name,String_code,Total_number_of_lessons,General_number,Specialized_number,Number_of_students) VALUES ('"+ name +"','"+ stringg +"','"+ total+"','"+ general +"','"+ specialized+"','"+ student +"')";
            SqlCommand command = new SqlCommand(query,se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            tex_field_add = tex_general_add = tex_specialized_add = tex_string_add = tex_student_add = tex_total_add = null;

        }
    }
}
