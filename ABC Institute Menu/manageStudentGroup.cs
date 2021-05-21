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
    public partial class manageStudentGroup : Form
    {

        public manageStudentGroup()
        {
            InitializeComponent();

        }



        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();



        private void manageStudentGroup_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source = timetable.db; Version=3;New=False;Compress=True;");
        }

        //set exeutequery code

        private void ExecuteQuery(string txtxQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtxQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from studentGroup";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox1.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "update studentGroup set AcedemicYear='" + textBox1.Text + "',Semester = '" + textBox6.Text + "',DegreeProgram = '" + textBox5.Text + "',GroupNumber ='" + textBox4.Text + "', SubGroupNumber ='" + textBox3.Text + "', GroupID ='" + textBox2.Text + "' where ID = '" + textBox7.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("updated successfully !! ");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from studentGroup where ID ='" + textBox6.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("Record Deleted !! ");
            return;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        
    }
}

