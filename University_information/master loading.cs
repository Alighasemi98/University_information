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
    public partial class master_loading : Form
    {
        master_password maspas = new master_password();
        public create crmas;
        public master_loading()
        {
            InitializeComponent();
            maspas.maslod = this;
        }
       
        private void but_ok_master_lod_Click(object sender, EventArgs e)
        {
            string name = tex_name_master_lod.Text;
            string family = tex_family_master_lod.Text;
            string number = tex_number_master_lod.Text;
            string age = tex_age_master_lod.Text;
            string National = tex_national_master_lod.Text;
            string field = tex_field_master_lod.Text;
            string height = tex_height_master_lod.Text;
            string weight = tex_weight_master_lod.Text;
            string sex = comboBox1.Text;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");  
            con.Open();
            string query = "INSERT INTO Master (Name,Family,Number,Age,National_Code,field,Height,Weight,Sex) VALUES ('"+ name +"','"+ family +"','"+ number +"','"+ age +"','"+ National +"','"+ field +"','"+ height +"','"+ weight +"','"+ sex +"')";
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("با موفقیت افزوده شد ", "موفق");
            this.Hide();
            maspas.Show();



        }


        private void but_previous_master_lod_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("ایا مطمعا هستید ؟", "تایید", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Show();
            }
            else
            {
                crmas.Show();
                this.Hide();
            }
        }
    }
}
