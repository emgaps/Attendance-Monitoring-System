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
    public partial class Rodrigo : Form
    {
        public Rodrigo()
        {
            InitializeComponent();
        }

        private void User3_Click(object sender, EventArgs e)
        {
            new Manzo().Show();
            this.Hide();
        }

        private void User1_Click(object sender, EventArgs e)
        {
            new Ouano().Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            new AdminAcc().Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
