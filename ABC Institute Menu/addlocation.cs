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
    public partial class addlocation : Form
    {
        string RoomType;

        public addlocation()
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
            string CommandText = "select * from locationDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //ADD
        private void button1_Click(object sender, EventArgs e)
        {

            if (LectureHall.Checked)
            {
                RoomType = "Lecture Hall";
            }

            if (rbLab.Checked)
            {
                RoomType = "Lab";
            }

            string txtQuery = "Insert into locationDetails (ID,BuildingName, RoomName,Capacity,RoomType) values ('" + textBox4.Text + "','" + textBox1.Text + "' , '" + textBox3.Text + "' , '" + textBox2.Text + "', '" + RoomType + "' )";
           
            

            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("One Record Added Successfully !! ");
            return;
        }

       //Delete
        private void button2_Click(object sender, EventArgs e)
        {
           


            DialogResult dialogResult = MessageBox.Show("Are you sure do you want to delete this record?", "Delete Action", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                string txtQuery = "delete from locationDetails where ID = '" + textBox4.Text + "'";
                ExecuteQuery(txtQuery);
                LoadData();
                MessageBox.Show("Record Deleted !! ");
                return;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
                return;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Update Location details2
        private void button3_Click(object sender, EventArgs e)
        {
            if (LectureHall.Checked)
            {
                RoomType = "Lecture Hall";
            }

            else if (rbLab.Checked)
            {
                RoomType = "Lab";
            }

           

            string txtQuery = "update locationDetails set BuildingName = '" + textBox1.Text + "' , RoomName = '" + textBox3.Text + "',  Capacity = '" + textBox2.Text + "', RoomType = '" + RoomType + "'   where ID = '" + textBox4.Text + "' ";

            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated Successfully !! ");
            return;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lab")
            {
                rbLab.Checked = true;
            }
            
            else if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lecture Hall" )
            {
                LectureHall.Checked = true; 
            }

            else
            {
                rbLab.Checked = false;
                LectureHall.Checked = false;
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fill(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void addlocation_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}






