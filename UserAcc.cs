using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Monitoring_System
{
    public partial class UserAcc : Form
    {
        private DateTime timeIn;
        private DateTime timeOut;
        private bool clockedIn;
        private bool sessionStarted = false;
        private List<TimeEntry> timeEntries = new List<TimeEntry>();

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
            new UserAcc_Attendance().Show();
            this.Hide();
            
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
        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView
            dgvTimeEntries.ColumnCount = 3;
            dgvTimeEntries.Columns[0].Name = "EntryType";
            dgvTimeEntries.Columns[1].Name = "Time";
            dgvTimeEntries.Columns[2].Name = "ClockType";
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

        private void dgvTimeEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userAccBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }

    public class TimeEntry
    {
        public string EntryType { get; set; }
        public DateTime Time { get; set; }
        public string ClockType { get; set; }
    }

}

    public class TimeEntry
    {
        public string ClockType { get; set; }
        public DateTime Time { get; set; }
    }


