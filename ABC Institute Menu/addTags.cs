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
    public partial class addTags : Form
    {
        public addTags()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addTags_Load(object sender, EventArgs e)
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

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }


        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from tags";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            //   dataGridView2.DataSource = DT;
            sql_con.Close();

        }

        private void addWorkingDaysHours_Click(object sender, EventArgs e)
        {

        }

        private void noOfWorkingDays_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into tags (TagName,TagCode,RelevantTag) values('" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("insert Successfully !! ");
            return;
        }
        /*private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void label3_Click(object sender, EventArgs e)
        {

        }*/


        /* private void dataGridView2_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
         {
             textBox3.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
             textBox7.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
             textBox1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
             textBox2.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();   
         }

         private void button4_Click(object sender, EventArgs e)
         {
             string txtQuery = "delete from tags where TagID ='" + textBox3.Text + "'";
             ExecuteQuery(txtQuery);
             LoadData();

             MessageBox.Show("Record Deleted !! ");
             return;
         }

         private void button5_Click(object sender, EventArgs e)
         {
             string txtQuery = "update tags set TagName='" +textBox7.Text+ "',TagCode = '" +textBox1.Text+ "',RelevantTag = '" +textBox2.Text+ "'where TagID = '" + textBox3.Text+"'";
             ExecuteQuery(txtQuery);
             LoadData();

             MessageBox.Show("updated successfully !! ");
             return;
         }*/
    }
}
