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
    public partial class UserAcc : Form
    {
        public UserAcc()
        {
            InitializeComponent();
            Timer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        private void Timer_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void UserAcc_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
        }
    }
}
