using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelWorkingDaysHours.Visible = false;
            panelLecturers.Visible = false;
            panelSubjects.Visible = false;
            panelStudents.Visible = false;
            panelTag.Visible = false;
            panelLocation.Visible = false;
            panelSession.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelWorkingDaysHours.Visible == true)
                panelWorkingDaysHours.Visible = false;
            if (panelLecturers.Visible == true)
                panelLecturers.Visible = false;
            if (panelSubjects.Visible == true)
                panelSubjects.Visible = false;
            if (panelStudents.Visible == true)
                panelStudents.Visible = false;
            if (panelTag.Visible == true)
                panelTag.Visible = false;
            if (panelLocation.Visible == true)
                panelLocation.Visible = false;
            if (panelSession.Visible == true)
                panelSession.Visible = false;
        }

        private void showSubMenu(Panel sideMenu)
        {
            if (sideMenu.Visible == false)
            {
                hideSubMenu();
                sideMenu.Visible = true;
            }
            else
                sideMenu.Visible = false;
        }

        private void btnWorkingDaysHours_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkingDaysHours);
        }

        private void addWorkingDaysHours_Click(object sender, EventArgs e)
        {
            openChildForm(new addWorkingDays());
            hideSubMenu();
        }

        private void manageWorkingDaysHours_Click(object sender, EventArgs e)
        {
            openChildForm(new manageWorkingDaysHours());
            hideSubMenu();
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLecturers);
        }

        private void addLecturers_Click(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
            hideSubMenu();
        }

        private void manageLecturers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjects);
        }

        private void addSubjects_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void manageSubjects_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudents);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new addStudentGroup());
            hideSubMenu();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTag);
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLocation);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new addlocation());
            hideSubMenu();
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new locationTable());
            hideSubMenu();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSession);
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            openChildForm(new addsession());
            hideSubMenu();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
