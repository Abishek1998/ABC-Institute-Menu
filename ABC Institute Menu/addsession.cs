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
            string CommandText = "select * from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }


      
        private void addSessions_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       
       /* private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "update tbsessionDetails set Lecturer1 = '" + textBox2.Text + "',Lecturer2 = '" + textBox3.Text + "',Tag = '" + Tag + "',SubCode = '" + textBox4.Text + "',GroupID = '" + textBox5.Text + "',SubGroupID='" + textBox6.Text + "',NoOfStudents = '" + textBox7.Text + "',Duration = '" + textBox8.Text + "' where SessionID = '" + textBox1.Text + "' ";

            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated Successfully !! ");
            return;
        }*/

       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Tag = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }*/

       /* private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tbsessionDetails where SessionID = '" + textBox1.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Record Deleted !! ");
            return;
        }*/

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        //add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "Insert into tbsessionDetails (SessionID,Lecturer1, Lecturer2 , Tag , SubCode  , GroupID , SubGroupID , NoOfStudents , Duration ) values ('" + textBox1.Text + "','" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + Tag + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "' )";



            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("One Record Added Successfully !! ");
            return;
        }

        //update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "update tbsessionDetails set Lecturer1 = '" + textBox2.Text + "',Lecturer2 = '" + textBox3.Text + "',Tag = '" + Tag + "',SubCode = '" + textBox4.Text + "',GroupID = '" + textBox5.Text + "',SubGroupID='" + textBox6.Text + "',NoOfStudents = '" + textBox7.Text + "',Duration = '" + textBox8.Text + "' where SessionID = '" + textBox1.Text + "' ";

            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Updated Successfully !! ");
            return;
        }

        //deleted button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tbsessionDetails where SessionID = '" + textBox1.Text + "' ";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Record Deleted !! ");
            return;
        }

        String Tag;
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Tag = "Lecture";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Tag = "Lab";
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            Tag = "Tute";
        }

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

            
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void addWorkingDaysHours_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Tag = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
