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
    public partial class addsession : Form
    {
        string Tag  ;

        public addsession()
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
            string CommandText = "select * from sessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addsession_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LectureHall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //ADD
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbLectures.Checked)
            {
                Tag = "Lecture";
            }

            if (rbLabs.Checked)
            {
                Tag = "Lab";
            }

            if (rbTutes.Checked)
            {
                Tag = "Tute";
            }


            string txtQuery = "Insert into sessionDetails (ID,Lecturer1, Lecturer2 , SubCode , Tag , GroupID , SubGroupID , Building , Room ) values ('" + textBox4.Text + "','" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox5.Text + "', '" + Tag + "', '" + textBox1.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "' )";



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
                string txtQuery = "delete from sessionDetails where ID = '" + textBox4.Text + "'";
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

        //Update
        private void button3_Click(object sender, EventArgs e)
        {

            if (rbLectures.Checked)
            {
                Tag = "Lecture";
            }

            if (rbLabs.Checked)
            {
                Tag = "Lab";
            }

            if (rbTutes.Checked)
            {
                Tag = "Tute";
            }


            string txtQuery = "update sessionDetails set Lecturer1 = '" + textBox2.Text + "' , Lecturer2 = '" + textBox3.Text + "',  SubCode = '" + textBox5.Text + "', Tag = '" + Tag + "', GroupID = '" + textBox1.Text + "', SubGroupID = '" + textBox6.Text + "', Building = '" + textBox7.Text + "', Room = '" + textBox8.Text + "'  where ID = '" + textBox4.Text + "' ";

            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated Successfully !! ");
            return;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();




            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lab")
            {
                rbLabs.Checked = true;
            }

            else if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lecture")
            {
                rbLectures.Checked = true;
            }
            else if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Lecture")
            {
                rbTutes.Checked = true;
            }

            else
            {
                rbLabs.Checked = false;
                rbLectures.Checked = false;
                rbTutes.Checked = false;
            }


        }
    }
}
