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
    public partial class addWorkingDays : Form
    {

        public addWorkingDays()
        {
            InitializeComponent();

        }


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        //set Connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=timetable.db;version=3;New=False;Compress=True");
        }

        //set execute query
        private void ExecuteQuery(String txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set LoadDb
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from workingDaysHours";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void hours_Click(object sender, EventArgs e)
        {

        }


        //ADD
        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            string workingDays = "";

            if (monday.CheckState == CheckState.Checked)
            {
                workingDays += "Monday";
            }

            if (tuesday.CheckState == CheckState.Checked)
            {
                workingDays += ", Tuesday";
            }

            if (wednesday.CheckState == CheckState.Checked)
            {
                workingDays += ", Wednesday";
            }

            if (thursday.CheckState == CheckState.Checked)
            {
                workingDays += ", Thursday";
            }

            if (friday.CheckState == CheckState.Checked)
            {
                workingDays += ", Friday";
            }

            if (saturday.CheckState == CheckState.Checked)
            {
                workingDays += ", Saturday";
            }

            if (sunday.CheckState == CheckState.Checked)
            {
                workingDays += ", Sunday";
            }

           


            string txtQuery = "Insert into workingDaysHours (ID, noOfWorkingDays, hours, minutes, workingDays) values ('" + txtId.Text + "' , '" + numericUpDown1.Text + "' , '" + numericUpDown2.Text + "' , '" + numericUpDown3.Text + "' ,'" + workingDays + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Added Successfully!");
        }

        
        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "Update workingDaysHours set noOfWorkingDays = '" + numericUpDown1.Text + "' , hours = '" + numericUpDown2.Text + "' , minutes = '" + numericUpDown3.Text + "' where ID = '" + txtId.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Updated Successfully!");


            
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this record?", "Delete Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                string txtQuery = "delete from workingDaysHours where ID = '" + txtId.Text + "'";
                ExecuteQuery(txtQuery);
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            numericUpDown1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            numericUpDown3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtId_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
