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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        int count, attempt;

        void disable()
        {
            if (attempt == 3)
            {
                MessageBox.Show("You have reached the limit of 3 attempts! \nPlease try again later.", "Attempts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attempt = 0;
                count = 59;

                Timer.Enabled = true;
                userInput.Enabled = false;
                passInput.Enabled = false;
                btnEnter.Enabled = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            attempt = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(count == 0)
            {
                Timer.Enabled = false;
                userInput.Enabled = true;
                passInput.Enabled = true;
                btnEnter.Enabled = true;
                btnEnter.Text = "Login";
                userInput.Focus();
            }
            else
            {
                btnEnter.Text = "Login " + count;
                count = count - 1;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void passInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter.PerformClick();
        }

        private void userInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnter.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (userInput.Text == "Admin" && passInput.Text == "1234")
            {
                new AdminAcc().Show();
                this.Hide();
            }

            else if (userInput.Text == "Kertz" && passInput.Text == "kertz")
            {
                new UserAcc().Show();
                this.Hide();
            }
            else if (userInput.Text == "Lok" && passInput.Text == "lokas")
            {
                new UserAcc1().Show();
                this.Hide();
            }
            else if (userInput.Text == "Marvn" && passInput.Text == "marvs")
            {
                new UserAcc2().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The username or password is Incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userInput.Clear();
                passInput.Clear();
                userInput.Focus();
                attempt++;
                disable();
            }
        }
    }
}
