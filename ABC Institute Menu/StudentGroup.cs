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
    public partial class StudentGroup : Form
    {
        public StudentGroup()
        {
            InitializeComponent();
        }

        //SQLite connection
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        private void StudentGroup_Load(object sender, EventArgs e)
        {
            //load data to gridview
            //LoadData();

        }
        //set connection
        private void SetConnection()
        {
            //connect to the database
            sql_con = new SQLiteConnection("Data Source = timetable.db; Version=3;New=False;Compress=True;");
        }

        //set exeutequery code
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //loading data
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
            //dataGridView2.DataSource = DT;
            sql_con.Close();
            }


        // Labels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Text Boxes
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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

        //text Boxes validation 
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        //ADD Button
        private void button2_Click(object sender, EventArgs e)
        {
            //insert Query
            string txtQuery = "insert into studentGroup (AcedemicYear,Semester,DegreeProgram,GroupNumber,SubGroupNumber,GroupID)values('" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("insert Successfully !! ");
            return;
        }

        //CLEAR ALL Button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        //GENERATE ID Button
        private void button3_Click(object sender, EventArgs e)
        {

        }



        /* private void label8_Click(object sender, EventArgs e)
         {

         }

          private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {
              textBox6.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
              textBox7.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
              textBox1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
              textBox2.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
              textBox3.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
              textBox4.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
              textBox5.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
          }

          private void button5_Click(object sender, EventArgs e)
          {
              string txtQuery = "update studentGroup set AcedemicYear='"+textBox7.Text+ "',Semester = '" + textBox1.Text + "',DegreeProgram = '" + textBox2.Text + "',GroupNumber ='" + textBox3.Text + "',SubGroupNumber ='" + textBox4.Text + "',GroupID ='" + textBox5.Text + "' where ID = '" + textBox6.Text + "'";
              ExecuteQuery(txtQuery);
              LoadData();

              MessageBox.Show("updated successfully !! ");
              return;
          }



          private void button4_Click(object sender, EventArgs e)
          {
              string txtQuery = "delete from studentGroup where ID ='"+textBox6.Text+"'";
              ExecuteQuery(txtQuery);
              LoadData();

              MessageBox.Show("Record Deleted !! ");
              return;
          }

          private void textBox6_TextChanged(object sender, EventArgs e)
          {

          }*/
    }
}
