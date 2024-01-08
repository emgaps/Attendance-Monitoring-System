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
    public partial class Ouano : Form
    {
        public Ouano()
        {
            InitializeComponent();
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
