
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
            this.clearAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.clearAll);
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
            this.panel2.Size = new System.Drawing.Size(1084, 505);
            this.panel2.TabIndex = 5;
            // 
            // noOfWorkingDaysHours
            // 
            this.noOfWorkingDaysHours.BaseColor = System.Drawing.Color.White;
            this.noOfWorkingDaysHours.BorderColor = System.Drawing.Color.Silver;
            this.noOfWorkingDaysHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noOfWorkingDaysHours.FocusedBaseColor = System.Drawing.Color.White;
            this.noOfWorkingDaysHours.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.noOfWorkingDaysHours.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.noOfWorkingDaysHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.noOfWorkingDaysHours.Location = new System.Drawing.Point(34, 64);
            this.noOfWorkingDaysHours.Name = "noOfWorkingDaysHours";
            this.noOfWorkingDaysHours.PasswordChar = '\0';
            this.noOfWorkingDaysHours.SelectedText = "";
            this.noOfWorkingDaysHours.Size = new System.Drawing.Size(220, 40);
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
            this.workingTimePerDay.Location = new System.Drawing.Point(30, 124);
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
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(34, 160);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(100, 40);
            this.gunaTextBox1.TabIndex = 7;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(154, 160);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(100, 40);
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
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(151, 212);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(57, 17);
            this.minutes.TabIndex = 10;
            this.minutes.Text = "Minutes";
            // 
            // workingDays
            // 
            this.workingDays.AutoSize = true;
            this.workingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingDays.Location = new System.Drawing.Point(308, 30);
            this.workingDays.Name = "workingDays";
            this.workingDays.Size = new System.Drawing.Size(107, 20);
            this.workingDays.TabIndex = 11;
            this.workingDays.Text = "Working Days";
            // 
            // clearAll
            // 
            this.clearAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.ForeColor = System.Drawing.Color.White;
            this.clearAll.Location = new System.Drawing.Point(34, 255);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(100, 30);
            this.clearAll.TabIndex = 12;
            this.clearAll.Text = "Clear All";
            this.clearAll.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(147)))), ((int)(((byte)(59)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(154, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clearAll;
    }
}