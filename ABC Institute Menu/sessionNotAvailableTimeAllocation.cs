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
    public partial class sessionNotAvailableTimeAllocation : Form
    {

        public sessionNotAvailableTimeAllocation()
        {
            InitializeComponent();
            LoadLecturer();
            LoadSessionID();
            LoadGroup();
            LoadSubGroup();
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
            string CommandText = "select * from sessionNotAvailableTimeLocation";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "Insert into sessionNotAvailableTimeLocation (ID, selectLecturer, selectSessionID, selectGroup, selectSubGroup, startTime, endTime) values ('" + txtId.Text + "' ,'" + comboBox1.Text + "' , '" + comboBox4.Text + "' , '" + comboBox3.Text + "' , '" + comboBox2.Text + "' , '" + dateTimePicker1.Text + "' , '" + dateTimePicker2.Text + "' )";
            ExecuteQuery(txtQuery);
            LoadData();
            
            System.Windows.Forms.MessageBox.Show("Data Added Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "Update sessionNotAvailableTimeLocation set selectLecturer = '" + comboBox1.Text + "' , selectSessionID = '" + comboBox4.Text + "' , selectGroup = '" + comboBox3.Text + "' , selectSubGroup = '" + comboBox2.Text + "' , startTime = '" + dateTimePicker1.Text + "' , endTime = '" + dateTimePicker2.Text + "' where ID = '" + txtId.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            
            System.Windows.Forms.MessageBox.Show("Data Updated Successfully!");
        }

        private void sessionNotAvailableTimeAllocation_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this record?", "Delete Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something go sgag
                string txtQuery = "delete from sessionNotAvailableTimeLocation where ID = '" + txtId.Text + "'";
                ExecuteQuery(txtQuery);
                LoadData();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void LoadLecturer()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select EmployeeName from tbLecturers";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox1.Items.Add(dr["EmployeeName"].ToString());
            }
            sql_con.Close();
        }

        private void LoadSessionID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select ID from manageSession";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox4.Items.Add(dr["ID"].ToString());
            }
            sql_con.Close();
        }

        private void LoadGroup()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select GroupNumber from studentGroup";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox3.Items.Add(dr["GroupNumber"].ToString());
            }
            sql_con.Close();
        }

        private void LoadSubGroup()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubGroupNumber from studentGroup";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox2.Items.Add(dr["SubGroupNumber"].ToString());
            }
            sql_con.Close();
        }
    }
}
