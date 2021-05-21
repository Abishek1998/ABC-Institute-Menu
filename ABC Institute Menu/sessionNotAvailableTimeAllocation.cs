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


        private void LoadData_1()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Consecutive";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }

        private void LoadData_2()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Parallel";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView3.DataSource = DT;
            sql_con.Close();
        }

        private void LoadData_3()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Overlapping";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView4.DataSource = DT;
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
            string txtQuery = "Update sessionNotAvailableTimeLocation set selectLecturer = '" + comboBox1.Text + "' , selectSessionID = '" + comboBox4.Text + "' , selectGroup = '" + comboBox3.Text + "' , selectSubGroup = '" + comboBox2.Text + " , selectSubGroup = '" + comboBox2.Text + " ' where ID = '" + txtId.Text + "' ";
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
                //do something
                string txtQuery = "delete from workingDaysHours where ID = '" + txtId.Text + "'";
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
       

        private void Consecutive_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            LoadData_1();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            LoadData_2();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            LoadData_3();
        }
        //=========================================insert=====================================================================================
        private void AddSessionBtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Consecutive (SessionID,Lecturer1,Lecturer2,SubCode,GroupID,SubGroupID,Tag,Duration)values('" + IDtext.Text +
                "','" + Lecturer1.Text + "','" + Lecturer2.Text + "','" + SubCode.Text + "','" + SubName.Text + "','" + GroupID.Text + "',"
                + "'" + Tag.Text + "','" + Duration.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData_1();

            MessageBox.Show("Session insert successfully !! ");
            return;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Parallel (SessionID,Lecturer1,Lecturer2,SubCode,GroupID,SubGroupID,Tag,Duration)values('" + IDcomboBox.Text +
                "','" + LecturecomboBox.Text + "','" + Lecture2comboBox.Text + "','" + SubcodecomboBox.Text + "','" + SubnamecomboBox.Text + "','" + GroupIDcomboBox.Text + "',"
                + "'" + TagcomboBox.Text + "','" + DurationcomboBox.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData_2();

            MessageBox.Show("Session insert successfully !! ");
            return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Overlapping (SessionID,Lecturer1,Lecturer2,SubCode,GroupID,SubGroupID,Tag,Duration)values('" + ID_comboBox.Text +
                "','" + Lecture_comboBox.Text + "','" + Lecture2_comboBox.Text + "','" + subCode_comboBox.Text + "','" + subName_comboBox.Text + "','" + GroupID_comboBox.Text + "',"
                + "'" + Tag_comboBox.Text + "','" + Duration_comboBox.Text + "')";
            ExecuteQuery(txtQuery);
            LoadData_3();

            MessageBox.Show("Session insert successfully !! ");
            return;
        }

        //=========================================update=====================================================================================

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Consecutive set SessionID='" + IDtext.Text + "',Lecturer1 = '" + Lecturer1.Text + "',Lecturer2 = '" + Lecturer2.Text + "',SubCode ='" + SubCode.Text + "',GroupID ='" + SubName.Text + "',SubGroupID ='" + GroupID.Text + "',Tag ='" + Tag.Text + "',Duration ='" + Duration.Text + "' where ID = '" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_1();

            MessageBox.Show("Session updated successfully !! ");
            return;


        }
        private void button10_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Overlapping set SessionID='" + ID_comboBox.Text + "',Lecturer1 = '" + Lecture_comboBox.Text + "',Lecturer2 = '" + Lecture2_comboBox.Text + "',SubCode ='" + subCode_comboBox.Text + "',GroupID ='" + subName_comboBox.Text + "',SubGroupID ='" + GroupID_comboBox.Text + "',Tag ='" + Tag_comboBox.Text + "',Duration ='" + Duration_comboBox.Text + "' where ID = '" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_3();

            MessageBox.Show("Session updated successfully !! ");
            return;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Parallel set SessionID='" + IDcomboBox.Text + "',Lecturer1 = '" + LecturecomboBox.Text + "',Lecturer2 = '" + Lecture2comboBox.Text + "',SubCode ='" + SubcodecomboBox.Text + "',GroupID ='" + SubnamecomboBox.Text + "',SubGroupID ='" + GroupIDcomboBox.Text + "',Tag ='" + TagcomboBox.Text + "',Duration ='" + DurationcomboBox.Text + "' where ID = '" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_2();

            MessageBox.Show("Session updated successfully !! ");
            return;
        }

        //=========================================Delete=====================================================================================

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Consecutive where ID ='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_1();

            MessageBox.Show("Session Deleted !! ");
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Parallel where ID ='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_2();

            MessageBox.Show("Session Deleted !! ");
            return;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Overlapping where ID ='" + textBox1.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData_3();

            MessageBox.Show("Session Deleted !! ");
            return;
        }

        //=========================================clear all====================================================================================

        private void button4_Click(object sender, EventArgs e)
        {
            //clear pa
        }

        

        private void Clearall_Btn_Click(object sender, EventArgs e)
        {
            //clear con
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //clear overlapping
        }


        //Gridview===========================================================================================================================

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtext.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            Lecturer1.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            Lecturer2.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            SubCode.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            SubName.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
            GroupID.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            Tag.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            Duration.Text = dataGridView2.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDcomboBox.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            LecturecomboBox.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            Lecture2comboBox.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            SubcodecomboBox.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            SubnamecomboBox.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            GroupIDcomboBox.Text = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();
            TagcomboBox.Text = dataGridView3.SelectedRows[0].Cells[7].Value.ToString();
            DurationcomboBox.Text = dataGridView3.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_comboBox.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            Lecture_comboBox.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            Lecture2_comboBox.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            subCode_comboBox.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            subName_comboBox.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
            GroupID_comboBox.Text = dataGridView4.SelectedRows[0].Cells[6].Value.ToString();
            Tag_comboBox.Text = dataGridView4.SelectedRows[0].Cells[7].Value.ToString();
            Duration_comboBox.Text = dataGridView4.SelectedRows[0].Cells[8].Value.ToString();
            
        }

        //===============================================================================================================================

        //not overlapping

        private void LoadSessionID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SessionID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                ID_comboBox.Items.Add(dr["SessionID"].ToString());
            }
            sql_con.Close();
        }

        private void ID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSessionID();
        }


        private void LoadLecturer1()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer1 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Lecture_comboBox.Items.Add(dr["Lecturer1"].ToString());
            }
            sql_con.Close();
        }

        private void Lecture_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLecturer1();
        }

        private void LoadLecturer2()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer2 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Lecture2_comboBox.Items.Add(dr["Lecturer2"].ToString());
            }
            sql_con.Close();
        }

        private void Lecture2_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLecturer2();
        }

        private void LoadSubCode()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubCode from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                subCode_comboBox.Items.Add(dr["SubCode"].ToString());
            }
            sql_con.Close();
        }

        private void subCode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubCode();
        }

        private void LoadGroupID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select GroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                subName_comboBox.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        private void subName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGroupID();
        }


        private void LoadSubGroupID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubGroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                GroupID_comboBox.Items.Add(dr["SubGroupID"].ToString());
            }
            sql_con.Close();
        }

        private void GroupID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubGroupID();
        }

        private void LoadTag()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Tag from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Tag_comboBox.Items.Add(dr["Tag"].ToString());
            }
            sql_con.Close();
        }

        private void Tag_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTag();
        }

        private void LoadDuration()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Duration from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Duration_comboBox.Items.Add(dr["Duration"].ToString());
            }
            sql_con.Close();
        }

        private void Duration_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuration();
        }
        //====================================================================================================================================

        //Parallel

        

        private void LoadsessionID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SessionID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                IDcomboBox.Items.Add(dr["SessionID"].ToString());
            }
            sql_con.Close();
        }

        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadsessionID();
        }

        private void LoadLecturer()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer1 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                LecturecomboBox.Items.Add(dr["Lecturer1"].ToString());
            }
            sql_con.Close();
        }

        private void LecturecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLecturer();
        }

        private void LoadLecturer_2()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer2 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Lecture2comboBox.Items.Add(dr["Lecturer2"].ToString());
            }
            sql_con.Close();
        }

        private void Lecture2comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLecturer_2();
        }

        private void LoadSubcode()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubCode from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                SubcodecomboBox.Items.Add(dr["SubCode"].ToString());
            }
            sql_con.Close();
        }

        private void SubcodecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubcode();
        }

        private void LoadgroupID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select GroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                SubnamecomboBox.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        private void SubnamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadgroupID();
        }

        private void LoadsubGroupID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubGroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                GroupIDcomboBox.Items.Add(dr["SubGroupID"].ToString());
            }
            sql_con.Close();
        }

        private void GroupIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadsubGroupID();
        }

        private void LoadTags()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Tag from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                TagcomboBox.Items.Add(dr["Tag"].ToString());
            }
            sql_con.Close();
        }

        private void TagcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTags();
        }

        private void Loadduration()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Duration from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                DurationcomboBox.Items.Add(dr["Duration"].ToString());
            }
            sql_con.Close();
        }

        private void DurationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadduration();
        }
//==================================================================================================================================================
        //consecutive

        private void Loadsession_ID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SessionID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                IDtext.Items.Add(dr["SessionID"].ToString());
            }
            sql_con.Close();
        }

        private void IDtext_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadsession_ID();
        }

        private void LoadLecturer_1()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer1 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Lecturer1.Items.Add(dr["Lecturer1"].ToString());
            }
            sql_con.Close();
        }

        private void Lecturer1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLecturer_1();
        }

        private void Loadlecturer_2()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Lecturer2 from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Lecturer2.Items.Add(dr["Lecturer2"].ToString());
            }
            sql_con.Close();
        }

        private void Lecturer2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadlecturer_2();
        }

        private void LoadSub_code()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubCode from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                SubCode.Items.Add(dr["SubCode"].ToString());
            }
            sql_con.Close();
        }
        private void SubCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSub_code();
        }

        private void Loadgroup_ID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select GroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                SubName.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        private void SubName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadgroup_ID();
        }

        private void LoadSubgroupID()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select SubGroupID from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                GroupID.Items.Add(dr["SubGroupID"].ToString());
            }
            sql_con.Close();
        }

        private void GroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSubgroupID();
        }

        private void Load_Tag()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Tag from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Tag.Items.Add(dr["Tag"].ToString());
            }
            sql_con.Close();
        }

        private void Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Tag();
        }
        private void Load_Duration()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select Duration from tbsessionDetails";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                Duration.Items.Add(dr["Duration"].ToString());
            }
            sql_con.Close();
        }

        private void Duration_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Duration();
        }

        
        //==================================================================================================================================================


    }
 }
