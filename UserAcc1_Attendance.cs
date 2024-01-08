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
    public partial class UserAcc1_Attendance : Form
    {
        public UserAcc1_Attendance()
        {
            InitializeComponent();
            Timer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserAcc1().Show();
            this.Hide();
        }

        private void UserAcc1_Attendance_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
