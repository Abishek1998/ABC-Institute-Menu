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
    public partial class Add_Subjects : Form
    {
        public Add_Subjects()
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
            string CommandText = "select * from tbSubjects";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_Subjects_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into tbSubjects (OfferedYear,OfferedSemester,SubjectName,SubjectCode,NoOfLectureHr,NoOfTutorialHr,NoOfLabHr,NoOfEvaluationHr) values ('" + textBox1.Text + "', '" + Semester + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";

            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("One Record Added Successfully !! ");
            return;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "update tbLecturers set OfferedYear = '" + textBox1.Text + "',OfferedSemester = '" + Semester + "',SubjectName = '" + textBox3.Text + "',NoOfLectureHr = '" + textBox4.Text + "',NoOfTutorialHr = '" + textBox5.Text + "',NoOfLabHr='" + textBox6.Text + "',NoOfEvaluationHr = '" + textBox7.Text + "' where SubjectCode = '" + textBox2.Text + "' ";

            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated Successfully !! ");
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Semester = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tbSubjects where SubjectCode = '" + textBox2.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Record Deleted !! ");
            return;
        }

        String Semester;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Semester = "2nd Sem";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Semester = "1st Sem";
        }
    }
}
