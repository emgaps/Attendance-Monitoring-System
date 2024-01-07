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
    public partial class UserAcc2: Form
    {
        public UserAcc2()
        {
            InitializeComponent();
            Timer.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Timer.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
