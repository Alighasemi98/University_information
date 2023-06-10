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
    public partial class employees_loading : Form
    {
       Employees_password emppas = new Employees_password();
        public create cremp;
        public employees_loading()
        {
            InitializeComponent();
            emppas.emplod = this;
        }

        private void but_ok_emp_lod_Click(object sender, EventArgs e)
        {
            string name = text_name_emp_lod.Text;
            string family = text_family_emp_lod.Text;
            string National = text_national_emp_lod.Text;
            string age = text_age_emp_lod.Text;
            string level = text_level_emp_lod.Text;
            string height = text_height_emp_lod.Text;
            string weight = text_weight_emp_lod.Text;
            string sex = comboBox1.Text;
            string work = text_work_emp_lod.Text;
            string number = text_number_emp_lod.Text;

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO Employees (Name,Family,National_Code,Age,Level_of_education,Height,Weight,Sex,work_department,Number) VALUES ('" + name + "','" + family + "','" + National + "','" + age + "','" + level + "','" + height + "','" + weight + "','" + sex + "','"+ work +"','"+ number +"')";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("با موفقیت افزوده شد ", "موفق");
            this.Hide();
            emppas.Show();
        }

        private void but_previous_emp_lod_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("ایا مطمعا هستید ؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                cremp.Show();
                this.Hide();
            }
        }
    }
}
