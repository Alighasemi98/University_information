using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_information
{
    public partial class create : Form
    {
        master_loading maslod = new master_loading();
        student_loading stulod = new student_loading(); 
        employees_loading emplod = new employees_loading();

        public loading lod;
        public create()
        {
            InitializeComponent();
            maslod.crmas = this;
            stulod.crstu = this;
            emplod.cremp = this;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student")
           {
               stulod.Show();
           }
            if(comboBox1.Text == "Master")
            {
                maslod.Show();
            }
            if(comboBox1.Text == "Employees")
            {
                emplod.Show();
            }
            this.Hide();
        }

        private void but_previous_lod_Click(object sender, EventArgs e)
        {
            lod.Show();
           this.Hide();
        } 
    }
}
