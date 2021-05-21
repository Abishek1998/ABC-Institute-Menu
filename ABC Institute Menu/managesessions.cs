using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Institute_Menu
{
    public partial class managesessions : Form
    {
        public managesessions()
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
            string CommandText = "select * from notAvailableTimesRoom";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }

        private void managesessions_Load(object sender, EventArgs e)
        {
            
            LoadData();                      
        }

        private void NotAvailableTimes_Click(object sender, EventArgs e)
        {

        }

       

        //NotAvailableTimes
        private void button1_Click(object sender, EventArgs e)
        {
           
            //int n = dataGridView2.Rows.Add();
            //dataGridView2.Rows[n].Cells[0].Value = (n + 1).ToString();
           // dataGridView2.Rows[n].Cells[1].Value = dateTimePicker1.Value.ToString();
           // dataGridView2.Rows[n].Cells[2].Value = dateTimePicker2.Value.ToString();

            string txtQuery = "Insert into notAvailableTimesRoom (ID, selectRoom, selectDay, startTime, endTime) values ('" + txtId.Text + "' ,'" + textBox5.Text + "' , '" + DayComboDay.Text + "' , '" + dateTimePicker1.Text + "' , '" + dateTimePicker2.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Added Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "Update notAvailableTimesRoom set selectRoom = '" + textBox5.Text + "' , selectDay = '" + DayComboDay.Text + "' , startTime = '" + dateTimePicker1.Text + "' , endTime = '" + dateTimePicker2.Text + "' where ID = '" + txtId.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Updated Successfully!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this record?", "Delete Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                string txtQuery = "delete from notAvailableTimesRoom where ID = '" + txtId.Text + "'";
                ExecuteQuery(txtQuery);
                LoadData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            DayComboDay.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            //dataGridView2.SelectedRows[0].Cells[3].Value = dateTimePicker1.Value.ToString("t");
           //dataGridView2.SelectedRows[0].Cells[4].Value = dateTimePicker2.Value.ToString("t");
            //dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            //dateTimePicker2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            DayComboDay.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            DayComboDay.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }


        //EndNotAvailableTimes
    }
}
