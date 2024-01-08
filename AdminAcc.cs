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
    public partial class AdminAcc : Form
    {
        public AdminAcc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormMain().Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form calendarForm = new Form())
            {
                MonthCalendar monthCalendar = new MonthCalendar();
                monthCalendar.DateSelected += (s, args) =>
                {
                    // Handle the selected date if needed
                    MessageBox.Show($"Selected Date: {monthCalendar.SelectionStart.ToShortDateString()}");
                };

                // Set the form properties
                calendarForm.Text = "Calendar";
                calendarForm.ClientSize = new System.Drawing.Size(228, 163);
                calendarForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                calendarForm.StartPosition = FormStartPosition.CenterScreen;

                // Add the MonthCalendar control to the form
                calendarForm.Controls.Add(monthCalendar);

                // Show the form as a dialog
                calendarForm.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new studentHistory().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new accMgmt().Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.Hide();
        }
    }
}
