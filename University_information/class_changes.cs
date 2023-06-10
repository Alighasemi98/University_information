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
    public partial class class_changes : Form
    {
        public class_changes()
        {
            InitializeComponent();
        }
        // for delete
        private void butdelete_Click(object sender, EventArgs e)
        {
            string name = comdelete.SelectedItem.ToString();
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM Class WHERE Class_Number='" + name + "'";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت حذف شد", "موفق");
        }
        //loding cmbobox
        private void class_changes_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT Class_Number FROM Class";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["Class_Number"].ToString();
                comdelete.Items.Add(name);
                com_class_up.Items.Add(name);
            }

            sc.Close();
        }
        // for add
        private void butadd_Click(object sender, EventArgs e)
        {
            string classs = tex_class_add.Text;
            string borards = tex_borards_add.Text;
            string seats = tex_seats_add.Text;
            string table = tex_tables_add.Text;
            string window = tex_window_add.Text;
            string tv = tex_tv_add.Text;
            string floor = text_floor_add.Text;
            string air = tex_air_add.Text;

            SqlConnection se = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            se.Open();
            string query = "INSERT INTO Class (Class_Number,Number_of_Borards,Number_of_Seats,Number_of_Tables,Number_of_Windows,The_Number_of_TVs,Floor,Air_Conditioner) VALUES ('" + classs + "','" + borards + "','" + seats + "','" + table + "','" + window + "','" + tv + "','" + floor + "','" + air + "')";
            SqlCommand command = new SqlCommand(query, se);
            command.ExecuteNonQuery();
            se.Close();
            MessageBox.Show("با موفقیت اضافه شد", "موفق");
            text_floor_add = tex_air_add = tex_borards_add = tex_class_add = tex_seats_add = tex_tables_add = tex_tv_add = tex_window_add = null;

        }
        //for update
        private void butupdate_Click(object sender, EventArgs e)
        {
            string classs = com_class_up.SelectedItem.ToString();
            string borards = tex_borards_up.Text;
            string seats = ctex_seats_up.Text;
            string table = tex_tables_up.Text;
            string window = tex_window_up.Text;
            string tv = tex_tv_up.Text;
            string floor = text_floor_up.Text;
            string air = tex_air_up.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\amin\\Documents\\GitHub\\University_information\\University_information\\University_information\\Database2.mdf;Integrated Security=True");
            sc.Open();
            string query = "UPDATE Class SET Number_of_Borards='"+ borards +"',Number_of_Seats='"+ seats +"',Number_of_Tables='"+ table +"',Number_of_Windows='"+ window +"',The_Number_of_TVs='"+ tv +"',Floor='"+ floor +"',Air_Conditioner='"+ air + "'  WHERE Class_Number='"+ classs +"' ";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("با موفقیت اضافه شد ", "موفق");
            text_floor_up = tex_air_up = tex_borards_up = tex_tables_up = tex_tv_up = tex_window_up = null;
        }
    }
       

    
}
