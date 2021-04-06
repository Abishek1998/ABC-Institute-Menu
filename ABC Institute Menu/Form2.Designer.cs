
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
            this.workingDays = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.workingTimePerDay = new System.Windows.Forms.Label();
            this.noOfWorkingDays = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.workingDays);
            this.panel2.Controls.Add(this.minutes);
            this.panel2.Controls.Add(this.hours);
            this.panel2.Controls.Add(this.workingTimePerDay);
            this.panel2.Controls.Add(this.noOfWorkingDays);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 402);
            this.panel2.TabIndex = 5;
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
            this.Text = " ";
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
        private System.Windows.Forms.Label workingTimePerDay;
        private System.Windows.Forms.Label noOfWorkingDays;
        private System.Windows.Forms.Label workingDays;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
      
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btmlabel;
    }
}