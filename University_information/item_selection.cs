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
    public partial class item_selection : Form
    {
        student_Changes stuch = new student_Changes();
        master_changes master = new master_changes();
        employees_changes employees = new employees_changes();
        class_changes class_changes = new class_changes();
        field_changes field_changes = new field_changes();
        lesson_changes lesson = new lesson_changes();
        semester_changes semester = new semester_changes();
        separate_class_changes separate = new separate_class_changes();

       
        public item_selection()
        {
            InitializeComponent();
          
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stuch.Show();
            this.Hide();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            master.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            employees.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            field_changes.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            semester.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lesson.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            class_changes.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            separate.Show();
            this.Hide();
        }
    }
}
