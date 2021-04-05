﻿
namespace ABC_Institute_Menu
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addWorkingDaysHours = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noOfWorkingDaysHours = new Guna.UI.WinForms.GunaTextBox();
            this.noOfWorkingDays = new System.Windows.Forms.Label();
            this.workingTimePerDay = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.workingDays = new System.Windows.Forms.Label();
            this.monday = new Guna.UI.WinForms.GunaCheckBox();
            this.tuesday = new Guna.UI.WinForms.GunaCheckBox();
            this.wednesday = new Guna.UI.WinForms.GunaCheckBox();
            this.thursday = new Guna.UI.WinForms.GunaCheckBox();
            this.friday = new Guna.UI.WinForms.GunaCheckBox();
            this.saturday = new Guna.UI.WinForms.GunaCheckBox();
            this.add = new Guna.UI.WinForms.GunaButton();
            this.clear = new Guna.UI.WinForms.GunaButton();
            this.sunday = new Guna.UI.WinForms.GunaCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addWorkingDaysHours);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 80);
            this.panel1.TabIndex = 4;
            // 
            // addWorkingDaysHours
            // 
            this.addWorkingDaysHours.AutoSize = true;
            this.addWorkingDaysHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkingDaysHours.Location = new System.Drawing.Point(29, 27);
            this.addWorkingDaysHours.Name = "addWorkingDaysHours";
            this.addWorkingDaysHours.Size = new System.Drawing.Size(326, 29);
            this.addWorkingDaysHours.TabIndex = 2;
            this.addWorkingDaysHours.Text = "Add Working Days and Hours";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sunday);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.saturday);
            this.panel2.Controls.Add(this.friday);
            this.panel2.Controls.Add(this.thursday);
            this.panel2.Controls.Add(this.wednesday);
            this.panel2.Controls.Add(this.tuesday);
            this.panel2.Controls.Add(this.monday);
            this.panel2.Controls.Add(this.workingDays);
            this.panel2.Controls.Add(this.minutes);
            this.panel2.Controls.Add(this.hours);
            this.panel2.Controls.Add(this.gunaTextBox2);
            this.panel2.Controls.Add(this.gunaTextBox1);
            this.panel2.Controls.Add(this.workingTimePerDay);
            this.panel2.Controls.Add(this.noOfWorkingDaysHours);
            this.panel2.Controls.Add(this.noOfWorkingDays);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 402);
            this.panel2.TabIndex = 5;
            // 
            // noOfWorkingDaysHours
            // 
            this.noOfWorkingDaysHours.BaseColor = System.Drawing.Color.White;
            this.noOfWorkingDaysHours.BorderColor = System.Drawing.Color.Silver;
            this.noOfWorkingDaysHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noOfWorkingDaysHours.FocusedBaseColor = System.Drawing.Color.White;
            this.noOfWorkingDaysHours.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.noOfWorkingDaysHours.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.noOfWorkingDaysHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noOfWorkingDaysHours.Location = new System.Drawing.Point(34, 64);
            this.noOfWorkingDaysHours.Name = "noOfWorkingDaysHours";
            this.noOfWorkingDaysHours.PasswordChar = '\0';
            this.noOfWorkingDaysHours.SelectedText = "";
            this.noOfWorkingDaysHours.Size = new System.Drawing.Size(310, 40);
            this.noOfWorkingDaysHours.TabIndex = 5;
            // 
            // noOfWorkingDays
            // 
            this.noOfWorkingDays.AutoSize = true;
            this.noOfWorkingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfWorkingDays.Location = new System.Drawing.Point(30, 30);
            this.noOfWorkingDays.Name = "noOfWorkingDays";
            this.noOfWorkingDays.Size = new System.Drawing.Size(185, 20);
            this.noOfWorkingDays.TabIndex = 3;
            this.noOfWorkingDays.Text = "Number of Working Days";
            // 
            // workingTimePerDay
            // 
            this.workingTimePerDay.AutoSize = true;
            this.workingTimePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimePerDay.Location = new System.Drawing.Point(30, 122);
            this.workingTimePerDay.Name = "workingTimePerDay";
            this.workingTimePerDay.Size = new System.Drawing.Size(165, 20);
            this.workingTimePerDay.TabIndex = 6;
            this.workingTimePerDay.Text = "Working Time Per Day";
            this.workingTimePerDay.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(34, 160);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(150, 40);
            this.gunaTextBox1.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(194, 160);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(150, 40);
            this.gunaTextBox2.TabIndex = 8;
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(31, 212);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(46, 17);
            this.hours.TabIndex = 9;
            this.hours.Text = "Hours";
            this.hours.Click += new System.EventHandler(this.hours_Click);
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(191, 212);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(57, 17);
            this.minutes.TabIndex = 10;
            this.minutes.Text = "Minutes";
            // 
            // workingDays
            // 
            this.workingDays.AutoSize = true;
            this.workingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingDays.Location = new System.Drawing.Point(375, 30);
            this.workingDays.Name = "workingDays";
            this.workingDays.Size = new System.Drawing.Size(107, 20);
            this.workingDays.TabIndex = 11;
            this.workingDays.Text = "Working Days";
            // 
            // monday
            // 
            this.monday.BaseColor = System.Drawing.Color.White;
            this.monday.CheckedOffColor = System.Drawing.Color.Gray;
            this.monday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.monday.FillColor = System.Drawing.Color.White;
            this.monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday.Location = new System.Drawing.Point(379, 64);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(90, 22);
            this.monday.TabIndex = 14;
            this.monday.Text = "Monday";
            // 
            // tuesday
            // 
            this.tuesday.BaseColor = System.Drawing.Color.White;
            this.tuesday.CheckedOffColor = System.Drawing.Color.Gray;
            this.tuesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.tuesday.FillColor = System.Drawing.Color.White;
            this.tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday.Location = new System.Drawing.Point(475, 64);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(95, 22);
            this.tuesday.TabIndex = 15;
            this.tuesday.Text = "Tuesday";
            // 
            // wednesday
            // 
            this.wednesday.BaseColor = System.Drawing.Color.White;
            this.wednesday.CheckedOffColor = System.Drawing.Color.Gray;
            this.wednesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.wednesday.FillColor = System.Drawing.Color.White;
            this.wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.Location = new System.Drawing.Point(576, 64);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(118, 22);
            this.wednesday.TabIndex = 16;
            this.wednesday.Text = "Wednesday";
            // 
            // thursday
            // 
            this.thursday.BaseColor = System.Drawing.Color.White;
            this.thursday.CheckedOffColor = System.Drawing.Color.Gray;
            this.thursday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.thursday.FillColor = System.Drawing.Color.White;
            this.thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.Location = new System.Drawing.Point(700, 64);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(100, 22);
            this.thursday.TabIndex = 17;
            this.thursday.Text = "Thursday";
            // 
            // friday
            // 
            this.friday.BaseColor = System.Drawing.Color.White;
            this.friday.CheckedOffColor = System.Drawing.Color.Gray;
            this.friday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.friday.FillColor = System.Drawing.Color.White;
            this.friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.Location = new System.Drawing.Point(379, 103);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(77, 22);
            this.friday.TabIndex = 18;
            this.friday.Text = "Friday";
            // 
            // saturday
            // 
            this.saturday.BaseColor = System.Drawing.Color.White;
            this.saturday.CheckedOffColor = System.Drawing.Color.Gray;
            this.saturday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.saturday.FillColor = System.Drawing.Color.White;
            this.saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.Location = new System.Drawing.Point(475, 103);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(97, 22);
            this.saturday.TabIndex = 19;
            this.saturday.Text = "Saturday";
            // 
            // add
            // 
            this.add.AnimationHoverSpeed = 0.07F;
            this.add.AnimationSpeed = 0.03F;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.add.BorderColor = System.Drawing.Color.Black;
            this.add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.add.FocusedColor = System.Drawing.Color.Empty;
            this.add.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = null;
            this.add.ImageSize = new System.Drawing.Size(20, 20);
            this.add.Location = new System.Drawing.Point(34, 265);
            this.add.Name = "add";
            this.add.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(75)))));
            this.add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.add.OnHoverForeColor = System.Drawing.Color.White;
            this.add.OnHoverImage = null;
            this.add.OnPressedColor = System.Drawing.Color.Black;
            this.add.Radius = 5;
            this.add.Size = new System.Drawing.Size(150, 40);
            this.add.TabIndex = 20;
            this.add.Text = "Add";
            this.add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear
            // 
            this.clear.AnimationHoverSpeed = 0.07F;
            this.clear.AnimationSpeed = 0.03F;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.clear.BorderColor = System.Drawing.Color.Black;
            this.clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear.FocusedColor = System.Drawing.Color.Empty;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Image = null;
            this.clear.ImageSize = new System.Drawing.Size(20, 20);
            this.clear.Location = new System.Drawing.Point(194, 265);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.clear.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.clear.OnHoverForeColor = System.Drawing.Color.White;
            this.clear.OnHoverImage = null;
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Radius = 5;
            this.clear.Size = new System.Drawing.Size(150, 40);
            this.clear.TabIndex = 21;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sunday
            // 
            this.sunday.BaseColor = System.Drawing.Color.White;
            this.sunday.CheckedOffColor = System.Drawing.Color.Gray;
            this.sunday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.sunday.FillColor = System.Drawing.Color.White;
            this.sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.Location = new System.Drawing.Point(578, 103);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(87, 22);
            this.sunday.TabIndex = 22;
            this.sunday.Text = "Sunday";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btmlabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1084, 50);
            this.panel3.TabIndex = 6;
            // 
            // btmlabel
            // 
            this.btmlabel.AutoSize = true;
            this.btmlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmlabel.Location = new System.Drawing.Point(472, 17);
            this.btmlabel.Name = "btmlabel";
            this.btmlabel.Size = new System.Drawing.Size(182, 13);
            this.btmlabel.TabIndex = 0;
            this.btmlabel.Text = "ABC Institute Timetable Management";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 690);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addWorkingDaysHours;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaTextBox noOfWorkingDaysHours;
        private System.Windows.Forms.Label workingTimePerDay;
        private System.Windows.Forms.Label noOfWorkingDays;
        private System.Windows.Forms.Label workingDays;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaCheckBox monday;
        private Guna.UI.WinForms.GunaCheckBox tuesday;
        private Guna.UI.WinForms.GunaButton clear;
        private Guna.UI.WinForms.GunaButton add;
        private Guna.UI.WinForms.GunaCheckBox saturday;
        private Guna.UI.WinForms.GunaCheckBox friday;
        private Guna.UI.WinForms.GunaCheckBox thursday;
        private Guna.UI.WinForms.GunaCheckBox wednesday;
        private Guna.UI.WinForms.GunaCheckBox sunday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btmlabel;
    }
}