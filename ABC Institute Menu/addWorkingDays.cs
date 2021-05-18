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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hours_Click(object sender, EventArgs e)
        {

        }


        //ADD
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "Insert into workingDaysHours (ID, noOfWorkingDays, hours, minutes, workingDays) values ('" + textBox1.Text + "' , '" + numericUpDown1.Text + "' , '" + numericUpDown2.Text + "' , '" + numericUpDown3.Text + "' ,'" + monday + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Added");
        }

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "Update workingDaysHours set noOfWorkingDays = '" + numericUpDown1.Text + "' , hours = '" + numericUpDown2.Text + "' , minutes = '" + numericUpDown3.Text + "'  where ID = '" + textBox1.Text + "' ";
           
            ExecuteQuery(txtQuery);
            LoadData();
        }

        //"update Example set Info ='" + textBox2.Text + ", Text ='"+textBox3.Text + "where ID ='" + textBox1.Text +"'"

        private void monday_CheckedChanged(object sender, EventArgs e)
        {
            
            string workingDays;
            workingDays = "Monday";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
