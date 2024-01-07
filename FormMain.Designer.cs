﻿namespace Attendance_Monitoring_System
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnEnter = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(528, 359);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(165, 34);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Login";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(508, 172);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(215, 22);
            this.userInput.TabIndex = 1;
            this.userInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userInput_KeyDown);
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(508, 283);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(215, 22);
            this.passInput.TabIndex = 2;
            this.passInput.UseSystemPasswordChar = true;
            this.passInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.passInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 23F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(561, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(498, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(498, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 8;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Attendance_Monitoring_System.Properties.Resources.Attendance_Management_background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 286);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.btnEnter);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Monitoring System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Timer;


    }
}

