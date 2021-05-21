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
        string RoomType;

        public managesessions()
        {
            InitializeComponent();

            LoadRoom();
            LoadWorkingDays();
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
            //LoadSessionData();
            //LoadSessionID();
            
        }

        private void NotAvailableTimes_Click(object sender, EventArgs e)
        {

        }

       

        //NotAvailableTimes
        private void button1_Click(object sender, EventArgs e)
        {
           
      

            string txtQuery = "Insert into notAvailableTimesRoom (ID, selectRoom, selectDay, startTime, endTime) values ('" + txtId.Text + "' ,'" + comboBox3.Text + "' , '" + DayComboDay.Text + "' , '" + dateTimePicker1.Text + "' , '" + dateTimePicker2.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            System.Windows.Forms.MessageBox.Show("Data Added Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "Update workingDaysHours set selectRoom = '" + comboBox3.Text + "' , selectDay = '" + DayComboDay.Text + "' , startTime = '" + dateTimePicker1.Text + "' , endTime = '" + dateTimePicker2.Text + "' where ID = '" + txtId.Text + "' ";
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
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            DayComboDay.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            //dataGridView2.SelectedRows[0].Cells[3].Value = dateTimePicker1.Value.ToString("t");
           //dataGridView2.SelectedRows[0].Cells[4].Value = dateTimePicker2.Value.ToString("t");
            //dateTimePicker1.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            //dateTimePicker2.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }


        private void LoadRoom()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select RoomName from locationDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox3.Items.Add(dr["RoomName"].ToString());
            }
            sql_con.Close();
        }

        private void LoadWorkingDays()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select workingDays from workingDaysHours";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                comboBox3.Items.Add(dr["workingDays"].ToString());
            }
            sql_con.Close();
        }
        //EndNotAvailableTimes



        //ManageSession Starts here

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //set LoadSessionData
        private void LoadSessionData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from manageSession";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
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
            foreach (DataRow dr in DT.Rows )
            { 
            comboBox2.Items.Add(dr ["ID"].ToString()) ;
            }
            sql_con.Close();
        }


        //Insert Session Data
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (LectureHall.Checked)
            {
                RoomType = "Lecture Hall";
            }

            if (rbLab.Checked)
            {
                RoomType = "Lab";
            }

         //   string txtQuery = "Insert into manageSession (ID, Tag, SubjectID, Capacity,Room) values ('" + textBox4.Text + "' ,'" + RoomType + "' , '" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + comboBox1.Text + "')";
            //ExecuteQuery(txtQuery);
            LoadSessionData();
            System.Windows.Forms.MessageBox.Show("Data Added Successfully!");
        }

        private void LectureHall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Update Session Data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LectureHall.Checked)
            {
                RoomType = "Lecture Hall";
            }

            else if (rbLab.Checked)
            {
                RoomType = "Lab";
            }



            //string txtQuery = "update manageSession set SubjectID = '" + textBox1.Text + "' , Capacity = '" + textBox2.Text + "',  RoomType = '" + RoomType + "'   where ID = '" + textBox4.Text + "' ";

           // ExecuteQuery(txtQuery);
            LoadSessionData();
            MessageBox.Show("Updated Successfully !! ");
            return;


        }

        //Retrive Session Data
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           // textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "Lab")
            {
                rbLab.Checked = true;
            }

            else if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "Lecture Hall")
            {
                LectureHall.Checked = true;
            }

            else
            {
                rbLab.Checked = false;
                LectureHall.Checked = false;
            }


        }


        //Delete Session Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this record?", "Delete Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
               // string txtQuery = "delete from manageSession where ID = '" + textBox4.Text + "'";
                //ExecuteQuery(txtQuery);
                LoadSessionData();
                MessageBox.Show("Record Deleted !! ");
                return;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from manageSession where ID ='"+ comboBox2.Text + "' ";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
              //  textBox1.Text =DT.Cells[1].ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            }
            sql_con.Close();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            comboBox3.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            DayComboDay.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
