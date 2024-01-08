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
        private DateTime timeIn;
        private DateTime timeOut;
        private bool clockedIn;
        private bool sessionStarted = false;
        private List<TimeEntry> timeEntries = new List<TimeEntry>();

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

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            if (!clockedIn)
            {
                DateTime timeIn = DateTime.Now;
                timeEntries.Add(new TimeEntry { EntryType = "Time In", Time = timeIn, ClockType = "In" });
                UpdateDataGridView();

                btnClockIn.Enabled = false;
                btnClockOut.Enabled = true;
                clockedIn = true;
            }
            else
            {
                MessageBox.Show("You Have Already Timed In");
            }
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            if (clockedIn)
            {
                DateTime timeOut = DateTime.Now;
                timeEntries.Add(new TimeEntry { EntryType = "Time Out", Time = timeOut, ClockType = "Out" });
                UpdateDataGridView();

                btnClockOut.Enabled = false;

                clockedIn = false;
            }
            else
            {
                MessageBox.Show("You Need To Clock In First");
            }
        }
        private void UpdateDataGridView()
        {
            dgvTimeEntries.Rows.Clear();
            foreach (var entry in timeEntries)
            {
                dgvTimeEntries.Rows.Add(entry.EntryType, entry.Time, entry.ClockType);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            new UserAcc2_Attendance().Show();
            this.Hide();
        }
    }

    }

