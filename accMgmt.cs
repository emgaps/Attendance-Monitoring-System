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
    public partial class accMgmt : Form
    {
        public accMgmt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void User1_Click(object sender, EventArgs e)
        {
            new Ouano().Show();
            this.Hide();
        }

        private void User2_Click(object sender, EventArgs e)
        {
            new Rodrigo().Show();
            this.Hide();
        }

        private void User3_Click(object sender, EventArgs e)
        {
            new Manzo().Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new AdminAcc().Show();
            this.Hide();
        }
    }
}
