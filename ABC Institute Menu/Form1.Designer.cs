using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ABC_Institute_Menu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSession = new System.Windows.Forms.Panel();
            this.btnManageSession = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnSession = new System.Windows.Forms.Button();
            this.panelLocation = new System.Windows.Forms.Panel();
            this.btnManageLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.panelTag = new System.Windows.Forms.Panel();
            this.btnManageTags = new System.Windows.Forms.Button();
            this.btnAddTags = new System.Windows.Forms.Button();
            this.btnTags = new System.Windows.Forms.Button();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.panelSubjects = new System.Windows.Forms.Panel();
            this.manageSubjects = new System.Windows.Forms.Button();
            this.addSubjects = new System.Windows.Forms.Button();
            this.btnSubjects = new System.Windows.Forms.Button();
            this.panelLecturers = new System.Windows.Forms.Panel();
            this.manageLecturers = new System.Windows.Forms.Button();
            this.addLecturers = new System.Windows.Forms.Button();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.panelWorkingDaysHours = new System.Windows.Forms.Panel();
            this.manageWorkingDaysHours = new System.Windows.Forms.Button();
            this.addWorkingDaysHours = new System.Windows.Forms.Button();
            this.btnWorkingDaysHours = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btngenerateTimetable = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelSide.SuspendLayout();
            this.panelSession.SuspendLayout();
            this.panelLocation.SuspendLayout();
            this.panelTag.SuspendLayout();
            this.panelStudents.SuspendLayout();
            this.panelSubjects.SuspendLayout();
            this.panelLecturers.SuspendLayout();
            this.panelWorkingDaysHours.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSide.Controls.Add(this.panelSession);
            this.panelSide.Controls.Add(this.btnSession);
            this.panelSide.Controls.Add(this.panelLocation);
            this.panelSide.Controls.Add(this.btnLocation);
            this.panelSide.Controls.Add(this.panelTag);
            this.panelSide.Controls.Add(this.btnTags);
            this.panelSide.Controls.Add(this.panelStudents);
            this.panelSide.Controls.Add(this.btnStudents);
            this.panelSide.Controls.Add(this.panelSubjects);
            this.panelSide.Controls.Add(this.btnSubjects);
            this.panelSide.Controls.Add(this.panelLecturers);
            this.panelSide.Controls.Add(this.btnLecturers);
            this.panelSide.Controls.Add(this.panelWorkingDaysHours);
            this.panelSide.Controls.Add(this.btnWorkingDaysHours);
            this.panelSide.Controls.Add(this.btnStatistics);
            this.panelSide.Controls.Add(this.btngenerateTimetable);
            this.panelSide.Controls.Add(this.panelLogo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(333, 897);
            this.panelSide.TabIndex = 0;
            // 
            // panelSession
            // 
            this.panelSession.Controls.Add(this.btnManageSession);
            this.panelSession.Controls.Add(this.btnAddSession);
            this.panelSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSession.Location = new System.Drawing.Point(0, 1230);
            this.panelSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(312, 111);
            this.panelSession.TabIndex = 16;
            // 
            // btnManageSession
            // 
            this.btnManageSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSession.FlatAppearance.BorderSize = 0;
            this.btnManageSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnManageSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSession.Location = new System.Drawing.Point(0, 49);
            this.btnManageSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageSession.Name = "btnManageSession";
            this.btnManageSession.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnManageSession.Size = new System.Drawing.Size(312, 49);
            this.btnManageSession.TabIndex = 1;
            this.btnManageSession.Text = "Manage Session";
            this.btnManageSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageSession.UseVisualStyleBackColor = true;
            this.btnManageSession.Click += new System.EventHandler(this.btnManageSession_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSession.FlatAppearance.BorderSize = 0;
            this.btnAddSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSession.Location = new System.Drawing.Point(0, 0);
            this.btnAddSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddSession.Size = new System.Drawing.Size(312, 49);
            this.btnAddSession.TabIndex = 0;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnSession
            // 
            this.btnSession.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSession.FlatAppearance.BorderSize = 0;
            this.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSession.Location = new System.Drawing.Point(0, 1181);
            this.btnSession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSession.Name = "btnSession";
            this.btnSession.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSession.Size = new System.Drawing.Size(312, 49);
            this.btnSession.TabIndex = 15;
            this.btnSession.Text = "Session";
            this.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSession.UseVisualStyleBackColor = true;
            this.btnSession.Click += new System.EventHandler(this.btnSession_Click);
            // 
            // panelLocation
            // 
            this.panelLocation.Controls.Add(this.btnManageLocation);
            this.panelLocation.Controls.Add(this.btnAddLocation);
            this.panelLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocation.Location = new System.Drawing.Point(0, 1070);
            this.panelLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(312, 111);
            this.panelLocation.TabIndex = 14;
            // 
            // btnManageLocation
            // 
            this.btnManageLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageLocation.FlatAppearance.BorderSize = 0;
            this.btnManageLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnManageLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLocation.Location = new System.Drawing.Point(0, 49);
            this.btnManageLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageLocation.Name = "btnManageLocation";
            this.btnManageLocation.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnManageLocation.Size = new System.Drawing.Size(312, 49);
            this.btnManageLocation.TabIndex = 1;
            this.btnManageLocation.Text = "Manage Location";
            this.btnManageLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLocation.UseVisualStyleBackColor = true;
            this.btnManageLocation.Click += new System.EventHandler(this.btnManageLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Location = new System.Drawing.Point(0, 0);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddLocation.Size = new System.Drawing.Size(312, 49);
            this.btnAddLocation.TabIndex = 0;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocation.FlatAppearance.BorderSize = 0;
            this.btnLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Location = new System.Drawing.Point(0, 1021);
            this.btnLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLocation.Size = new System.Drawing.Size(312, 49);
            this.btnLocation.TabIndex = 13;
            this.btnLocation.Text = "Location";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // panelTag
            // 
            this.panelTag.Controls.Add(this.btnManageTags);
            this.panelTag.Controls.Add(this.btnAddTags);
            this.panelTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTag.Location = new System.Drawing.Point(0, 910);
            this.panelTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTag.Name = "panelTag";
            this.panelTag.Size = new System.Drawing.Size(312, 111);
            this.panelTag.TabIndex = 12;
            // 
            // btnManageTags
            // 
            this.btnManageTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageTags.FlatAppearance.BorderSize = 0;
            this.btnManageTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnManageTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTags.Location = new System.Drawing.Point(0, 49);
            this.btnManageTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageTags.Name = "btnManageTags";
            this.btnManageTags.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnManageTags.Size = new System.Drawing.Size(312, 49);
            this.btnManageTags.TabIndex = 1;
            this.btnManageTags.Text = "Manage Tags";
            this.btnManageTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageTags.UseVisualStyleBackColor = true;
            this.btnManageTags.Click += new System.EventHandler(this.btnManageTags_Click);
            // 
            // btnAddTags
            // 
            this.btnAddTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTags.FlatAppearance.BorderSize = 0;
            this.btnAddTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnAddTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTags.Location = new System.Drawing.Point(0, 0);
            this.btnAddTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddTags.Size = new System.Drawing.Size(312, 49);
            this.btnAddTags.TabIndex = 0;
            this.btnAddTags.Text = "Add Tags";
            this.btnAddTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTags.UseVisualStyleBackColor = true;
            this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Location = new System.Drawing.Point(0, 861);
            this.btnTags.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(312, 49);
            this.btnTags.TabIndex = 11;
            this.btnTags.Text = "Tags";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // panelStudents
            // 
            this.panelStudents.Controls.Add(this.btnManageStudents);
            this.panelStudents.Controls.Add(this.btnAddStudents);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudents.Location = new System.Drawing.Point(0, 750);
            this.panelStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(312, 111);
            this.panelStudents.TabIndex = 10;
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageStudents.FlatAppearance.BorderSize = 0;
            this.btnManageStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudents.Location = new System.Drawing.Point(0, 49);
            this.btnManageStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnManageStudents.Size = new System.Drawing.Size(312, 49);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btnAddStudents.Size = new System.Drawing.Size(312, 49);
            this.btnAddStudents.TabIndex = 0;
            this.btnAddStudents.Text = "Add Students";
            this.btnAddStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudents.UseVisualStyleBackColor = true;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Location = new System.Drawing.Point(0, 701);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnStudents.Size = new System.Drawing.Size(312, 49);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // panelSubjects
            // 
            this.panelSubjects.Controls.Add(this.manageSubjects);
            this.panelSubjects.Controls.Add(this.addSubjects);
            this.panelSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubjects.Location = new System.Drawing.Point(0, 590);
            this.panelSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Size = new System.Drawing.Size(312, 111);
            this.panelSubjects.TabIndex = 8;
            // 
            // manageSubjects
            // 
            this.manageSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageSubjects.FlatAppearance.BorderSize = 0;
            this.manageSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.manageSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSubjects.Location = new System.Drawing.Point(0, 49);
            this.manageSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageSubjects.Name = "manageSubjects";
            this.manageSubjects.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.manageSubjects.Size = new System.Drawing.Size(312, 49);
            this.manageSubjects.TabIndex = 1;
            this.manageSubjects.Text = "Manage Subjects";
            this.manageSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageSubjects.UseVisualStyleBackColor = true;
            this.manageSubjects.Click += new System.EventHandler(this.manageSubjects_Click);
            // 
            // addSubjects
            // 
            this.addSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.addSubjects.FlatAppearance.BorderSize = 0;
            this.addSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.addSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubjects.Location = new System.Drawing.Point(0, 0);
            this.addSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addSubjects.Name = "addSubjects";
            this.addSubjects.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.addSubjects.Size = new System.Drawing.Size(312, 49);
            this.addSubjects.TabIndex = 0;
            this.addSubjects.Text = "Add Subjects";
            this.addSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubjects.UseVisualStyleBackColor = true;
            this.addSubjects.Click += new System.EventHandler(this.addSubjects_Click);
            // 
            // btnSubjects
            // 
            this.btnSubjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubjects.FlatAppearance.BorderSize = 0;
            this.btnSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubjects.Location = new System.Drawing.Point(0, 541);
            this.btnSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubjects.Name = "btnSubjects";
            this.btnSubjects.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnSubjects.Size = new System.Drawing.Size(312, 49);
            this.btnSubjects.TabIndex = 7;
            this.btnSubjects.Text = "Subjects";
            this.btnSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubjects.UseVisualStyleBackColor = true;
            this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
            // 
            // panelLecturers
            // 
            this.panelLecturers.Controls.Add(this.manageLecturers);
            this.panelLecturers.Controls.Add(this.addLecturers);
            this.panelLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLecturers.Location = new System.Drawing.Point(0, 430);
            this.panelLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLecturers.Name = "panelLecturers";
            this.panelLecturers.Size = new System.Drawing.Size(312, 111);
            this.panelLecturers.TabIndex = 6;
            // 
            // manageLecturers
            // 
            this.manageLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageLecturers.FlatAppearance.BorderSize = 0;
            this.manageLecturers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.manageLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageLecturers.Location = new System.Drawing.Point(0, 49);
            this.manageLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageLecturers.Name = "manageLecturers";
            this.manageLecturers.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.manageLecturers.Size = new System.Drawing.Size(312, 49);
            this.manageLecturers.TabIndex = 1;
            this.manageLecturers.Text = "Manage Lecturers";
            this.manageLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageLecturers.UseVisualStyleBackColor = true;
            this.manageLecturers.Click += new System.EventHandler(this.manageLecturers_Click);
            // 
            // addLecturers
            // 
            this.addLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.addLecturers.FlatAppearance.BorderSize = 0;
            this.addLecturers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.addLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLecturers.Location = new System.Drawing.Point(0, 0);
            this.addLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addLecturers.Name = "addLecturers";
            this.addLecturers.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.addLecturers.Size = new System.Drawing.Size(312, 49);
            this.addLecturers.TabIndex = 0;
            this.addLecturers.Text = "Add Lecturers";
            this.addLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLecturers.UseVisualStyleBackColor = true;
            this.addLecturers.Click += new System.EventHandler(this.addLecturers_Click);
            // 
            // btnLecturers
            // 
            this.btnLecturers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLecturers.FlatAppearance.BorderSize = 0;
            this.btnLecturers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnLecturers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturers.Location = new System.Drawing.Point(0, 381);
            this.btnLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnLecturers.Size = new System.Drawing.Size(312, 49);
            this.btnLecturers.TabIndex = 5;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.btnLecturers_Click);
            // 
            // panelWorkingDaysHours
            // 
            this.panelWorkingDaysHours.Controls.Add(this.manageWorkingDaysHours);
            this.panelWorkingDaysHours.Controls.Add(this.addWorkingDaysHours);
            this.panelWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorkingDaysHours.Location = new System.Drawing.Point(0, 270);
            this.panelWorkingDaysHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelWorkingDaysHours.Name = "panelWorkingDaysHours";
            this.panelWorkingDaysHours.Size = new System.Drawing.Size(312, 111);
            this.panelWorkingDaysHours.TabIndex = 4;
            // 
            // manageWorkingDaysHours
            // 
            this.manageWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageWorkingDaysHours.FlatAppearance.BorderSize = 0;
            this.manageWorkingDaysHours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.manageWorkingDaysHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageWorkingDaysHours.Location = new System.Drawing.Point(0, 49);
            this.manageWorkingDaysHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageWorkingDaysHours.Name = "manageWorkingDaysHours";
            this.manageWorkingDaysHours.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.manageWorkingDaysHours.Size = new System.Drawing.Size(312, 49);
            this.manageWorkingDaysHours.TabIndex = 1;
            this.manageWorkingDaysHours.Text = "Manage Working Days, Hours";
            this.manageWorkingDaysHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageWorkingDaysHours.UseVisualStyleBackColor = true;
            this.manageWorkingDaysHours.Click += new System.EventHandler(this.manageWorkingDaysHours_Click);
            // 
            // addWorkingDaysHours
            // 
            this.addWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.addWorkingDaysHours.FlatAppearance.BorderSize = 0;
            this.addWorkingDaysHours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.addWorkingDaysHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkingDaysHours.Location = new System.Drawing.Point(0, 0);
            this.addWorkingDaysHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addWorkingDaysHours.Name = "addWorkingDaysHours";
            this.addWorkingDaysHours.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.addWorkingDaysHours.Size = new System.Drawing.Size(312, 49);
            this.addWorkingDaysHours.TabIndex = 0;
            this.addWorkingDaysHours.Text = "Add Working Days, Hours";
            this.addWorkingDaysHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorkingDaysHours.UseVisualStyleBackColor = true;
            this.addWorkingDaysHours.Click += new System.EventHandler(this.addWorkingDaysHours_Click);
            // 
            // btnWorkingDaysHours
            // 
            this.btnWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkingDaysHours.FlatAppearance.BorderSize = 0;
            this.btnWorkingDaysHours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnWorkingDaysHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingDaysHours.Location = new System.Drawing.Point(0, 221);
            this.btnWorkingDaysHours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWorkingDaysHours.Name = "btnWorkingDaysHours";
            this.btnWorkingDaysHours.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnWorkingDaysHours.Size = new System.Drawing.Size(312, 49);
            this.btnWorkingDaysHours.TabIndex = 3;
            this.btnWorkingDaysHours.Text = "Working Days , Hours";
            this.btnWorkingDaysHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkingDaysHours.UseVisualStyleBackColor = true;
            this.btnWorkingDaysHours.Click += new System.EventHandler(this.btnWorkingDaysHours_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Location = new System.Drawing.Point(0, 172);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnStatistics.Size = new System.Drawing.Size(312, 49);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btngenerateTimetable
            // 
            this.btngenerateTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btngenerateTimetable.FlatAppearance.BorderSize = 0;
            this.btngenerateTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerateTimetable.Location = new System.Drawing.Point(0, 123);
            this.btngenerateTimetable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenerateTimetable.Name = "btngenerateTimetable";
            this.btngenerateTimetable.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btngenerateTimetable.Size = new System.Drawing.Size(312, 49);
            this.btngenerateTimetable.TabIndex = 1;
            this.btngenerateTimetable.Text = "Generate Timetable";
            this.btngenerateTimetable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngenerateTimetable.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(312, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelChildForm.Controls.Add(this.panel6);
            this.panelChildForm.Controls.Add(this.panel5);
            this.panelChildForm.Controls.Add(this.panel3);
            this.panelChildForm.Controls.Add(this.panel2);
            this.panelChildForm.Controls.Add(this.panel4);
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(333, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1467, 897);
            this.panelChildForm.TabIndex = 1;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 198);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(644, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 198);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(644, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 198);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(47, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 198);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(171, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registered Lecturers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(171, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registered Subjects";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(31, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 95);
            this.label4.TabIndex = 2;
            this.label4.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(187, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registered Student Groups";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(47, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 95);
            this.label6.TabIndex = 4;
            this.label6.Text = "25";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label7.Location = new System.Drawing.Point(187, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 36);
            this.label7.TabIndex = 5;
            this.label7.Text = "Registered Rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(47, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 95);
            this.label8.TabIndex = 4;
            this.label8.Text = "30";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(47, 587);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 331);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(644, 587);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(613, 331);
            this.panel6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(57, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Location Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(58, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Latest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label11.Location = new System.Drawing.Point(58, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "Latest Lecturer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(58, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Latest Group";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(58, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Latest Subject";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label14.Location = new System.Drawing.Point(320, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Mr. Senura Diwantha";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label15.Location = new System.Drawing.Point(320, 202);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Y3 S2 WE June";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(320, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "ITPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSide);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1815, 934);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Institute Timetable";
            this.panelSide.ResumeLayout(false);
            this.panelSession.ResumeLayout(false);
            this.panelLocation.ResumeLayout(false);
            this.panelTag.ResumeLayout(false);
            this.panelStudents.ResumeLayout(false);
            this.panelSubjects.ResumeLayout(false);
            this.panelLecturers.ResumeLayout(false);
            this.panelWorkingDaysHours.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.Button btnManageSession;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnSession;
        private System.Windows.Forms.Panel panelLocation;
        private System.Windows.Forms.Button btnManageLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Panel panelTag;
        private System.Windows.Forms.Button btnManageTags;
        private System.Windows.Forms.Button btnAddTags;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Panel panelSubjects;
        private System.Windows.Forms.Button manageSubjects;
        private System.Windows.Forms.Button addSubjects;
        private System.Windows.Forms.Button btnSubjects;
        private System.Windows.Forms.Panel panelLecturers;
        private System.Windows.Forms.Button manageLecturers;
        private System.Windows.Forms.Button addLecturers;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Panel panelWorkingDaysHours;
        private System.Windows.Forms.Button manageWorkingDaysHours;
        private System.Windows.Forms.Button addWorkingDaysHours;
        private System.Windows.Forms.Button btnWorkingDaysHours;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btngenerateTimetable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }



}

