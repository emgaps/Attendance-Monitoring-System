using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_System
{
    public partial class studentHistory : Form
    {
        public studentHistory()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "January 23, 2023", "10:23AM", "In");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "January 23, 2023", "10:23PM", "Out");
            dataGridView1.Rows.Add("John Kert Ouano", "January 23, 2023", "9:12AM", "In");
            dataGridView1.Rows.Add("John Kert Ouano", "January 23, 2023", "9:23PM", "Out");
            dataGridView1.Rows.Add("Marvin Manzo", "January 23, 2023", "11:01AM", "In");
            dataGridView1.Rows.Add("Marvin Manzo", "January 23, 2023", "11:43PM", "Out");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "February 2, 2023", "6:23AM", "In");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "February 2, 2023", "7:23PM", "Out");
            dataGridView1.Rows.Add("John Kert Ouano", "February 3, 2023", "5:12AM", "In");
            dataGridView1.Rows.Add("John Kert Ouano", "February 3, 2023", "2:23PM", "Out");
            dataGridView1.Rows.Add("Marvin Manzo", "February 9, 2023", "7:01AM", "In");
            dataGridView1.Rows.Add("Marvin Manzo", "February 9, 2023", "8:43PM", "Out");
            dataGridView1.Rows.Add("John Kert Ouano", "March 6, 2023", "5:12AM", "In");
            dataGridView1.Rows.Add("John Kert Ouano", "March 6, 2023", "1:23PM", "Out");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "March 11, 2023", "6:23AM", "In");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "March 11, 2023", "8:23PM", "Out");
            dataGridView1.Rows.Add("Marvin Manzo", "March 26, 2023", "8:01AM", "In");
            dataGridView1.Rows.Add("Marvin Manzo", "Marchy 26, 2023", "2:43PM", "Out");
            dataGridView1.Rows.Add("John Kert Ouano", "April 1, 2023", "7:12AM", "In");
            dataGridView1.Rows.Add("John Kert Ouano", "April 1, 2023", "2:23PM", "Out");
            dataGridView1.Rows.Add("Marvin Manzo", "April 3, 2023", "9:01AM", "In");
            dataGridView1.Rows.Add("Marvin Manzo", "April 3, 2023", "2:43PM", "Out");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "April 17, 2023", "6:21AM", "In");
            dataGridView1.Rows.Add("Neris Luke Rodrigo", "April 17, 2023", "1:20PM", "Out");


        }

        private void Back_Click(object sender, EventArgs e)
        {
            new AdminAcc().Show();
            this.Hide();
        }
    }
}
