
namespace ABC_Institute_Menu
{
    partial class addWorkingDays
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btmlabel = new System.Windows.Forms.Label();
            this.addWorkingDaysHours = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sunday = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.CheckBox();
            this.monday = new System.Windows.Forms.CheckBox();
            this.workingDays = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.workingTimePerDay = new System.Windows.Forms.Label();
            this.noOfWorkingDays = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.btmlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmlabel.AutoSize = true;
            this.btmlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmlabel.Location = new System.Drawing.Point(472, 17);
            this.btmlabel.Name = "btmlabel";
            this.btmlabel.Size = new System.Drawing.Size(182, 13);
            this.btmlabel.TabIndex = 0;
            this.btmlabel.Text = "ABC Institute Timetable Management";
            // 
            // addWorkingDaysHours
            // 
            this.addWorkingDaysHours.AutoSize = true;
            this.addWorkingDaysHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkingDaysHours.Location = new System.Drawing.Point(33, 9);
            this.addWorkingDaysHours.Name = "addWorkingDaysHours";
            this.addWorkingDaysHours.Size = new System.Drawing.Size(299, 29);
            this.addWorkingDaysHours.TabIndex = 2;
            this.addWorkingDaysHours.Text = "Working Days and Hours";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addWorkingDaysHours);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 50);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown3);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.sunday);
            this.panel2.Controls.Add(this.saturday);
            this.panel2.Controls.Add(this.friday);
            this.panel2.Controls.Add(this.thursday);
            this.panel2.Controls.Add(this.wednesday);
            this.panel2.Controls.Add(this.tuesday);
            this.panel2.Controls.Add(this.monday);
            this.panel2.Controls.Add(this.workingDays);
            this.panel2.Controls.Add(this.minutes);
            this.panel2.Controls.Add(this.hours);
            this.panel2.Controls.Add(this.workingTimePerDay);
            this.panel2.Controls.Add(this.noOfWorkingDays);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 133);
            this.panel2.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(38, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 23);
            this.txtId.TabIndex = 29;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtId.Validating += new System.ComponentModel.CancelEventHandler(this.txtId_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(411, 60);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(285, 60);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown2.TabIndex = 26;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(115, 60);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDown1.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown1_Validating);
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.FlatAppearance.BorderSize = 0;
            this.sunday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday.Location = new System.Drawing.Point(1011, 60);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(54, 24);
            this.sunday.TabIndex = 21;
            this.sunday.Text = "Sun";
            this.sunday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.FlatAppearance.BorderSize = 0;
            this.saturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday.Location = new System.Drawing.Point(937, 60);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(50, 24);
            this.saturday.TabIndex = 20;
            this.saturday.Text = "Sat";
            this.saturday.UseVisualStyleBackColor = true;
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.FlatAppearance.BorderSize = 0;
            this.friday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday.Location = new System.Drawing.Point(873, 60);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(43, 24);
            this.friday.TabIndex = 19;
            this.friday.Text = "Fri";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.FlatAppearance.BorderSize = 0;
            this.thursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday.Location = new System.Drawing.Point(789, 60);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(57, 24);
            this.thursday.TabIndex = 18;
            this.thursday.Text = "Thur";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.FlatAppearance.BorderSize = 0;
            this.wednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday.Location = new System.Drawing.Point(707, 60);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(58, 24);
            this.wednesday.TabIndex = 17;
            this.wednesday.Text = "Wed";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.FlatAppearance.BorderSize = 0;
            this.tuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday.Location = new System.Drawing.Point(630, 60);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(52, 24);
            this.tuesday.TabIndex = 16;
            this.tuesday.Text = "Tue";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.FlatAppearance.BorderSize = 0;
            this.monday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday.Location = new System.Drawing.Point(553, 60);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(56, 24);
            this.monday.TabIndex = 15;
            this.monday.Text = "Mon";
            this.monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monday.UseVisualStyleBackColor = true;
            // 
            // workingDays
            // 
            this.workingDays.AutoSize = true;
            this.workingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingDays.Location = new System.Drawing.Point(550, 24);
            this.workingDays.Name = "workingDays";
            this.workingDays.Size = new System.Drawing.Size(96, 17);
            this.workingDays.TabIndex = 11;
            this.workingDays.Text = "Working Days";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(408, 86);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(57, 17);
            this.minutes.TabIndex = 10;
            this.minutes.Text = "Minutes";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(281, 86);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(46, 17);
            this.hours.TabIndex = 9;
            this.hours.Text = "Hours";
            // 
            // workingTimePerDay
            // 
            this.workingTimePerDay.AutoSize = true;
            this.workingTimePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingTimePerDay.Location = new System.Drawing.Point(282, 24);
            this.workingTimePerDay.Name = "workingTimePerDay";
            this.workingTimePerDay.Size = new System.Drawing.Size(99, 17);
            this.workingTimePerDay.TabIndex = 6;
            this.workingTimePerDay.Text = "Working Time ";
            // 
            // noOfWorkingDays
            // 
            this.noOfWorkingDays.AutoSize = true;
            this.noOfWorkingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noOfWorkingDays.Location = new System.Drawing.Point(112, 24);
            this.noOfWorkingDays.Name = "noOfWorkingDays";
            this.noOfWorkingDays.Size = new System.Drawing.Size(138, 17);
            this.noOfWorkingDays.TabIndex = 3;
            this.noOfWorkingDays.Text = "No. of Working Days";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(0, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1084, 405);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(265, 594);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(139, 594);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(75)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(13, 594);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addWorkingDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 690);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "addWorkingDays";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Institute";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label btmlabel;
        private System.Windows.Forms.Label addWorkingDaysHours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox sunday;
        private System.Windows.Forms.CheckBox saturday;
        private System.Windows.Forms.CheckBox friday;
        private System.Windows.Forms.CheckBox thursday;
        private System.Windows.Forms.CheckBox wednesday;
        private System.Windows.Forms.CheckBox tuesday;
        private System.Windows.Forms.CheckBox monday;
        private System.Windows.Forms.Label workingDays;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label workingTimePerDay;
        private System.Windows.Forms.Label noOfWorkingDays;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
    }
}