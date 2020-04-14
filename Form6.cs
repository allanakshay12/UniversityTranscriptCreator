using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityTranscriptCreator
{
    public partial class BranchForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        public BranchForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            //cnn.Open();
            SubjectGroupBox.Enabled = false;
            FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
            FillBranchData("select * from dbo.BranchList;");
            cnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select Code from dbo.Subject;";

            commandbr = new SqlCommand(sqlbr, cnn);
            /*dataReaderbr = commandbr.ExecuteReader();

            //BranchView.Items.Add("All Branches");

            while (dataReaderbr.Read())
            {
                SubjectComboBoxAdd.Items.Add(dataReaderbr.GetValue(0).ToString());
                //BranchModify.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            dataReaderbr.Close();*/


            PopulateBranchComboBox();
            
            SubjectComboBoxAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SubjectComboBoxAdd.AutoCompleteSource = AutoCompleteSource.ListItems;


            cnn.Close();
        }

        void PopulateBranchComboBox()
        {
            ActualBranchModifyComboBox.Items.Clear();
            BranchComboBoxAdd.Items.Clear();
            BranchModify.Items.Clear();
            SqlConnection newcnn = new SqlConnection(connectionString);
            newcnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;
            sqlbr = "Select Branch from dbo.BranchList;";

            commandbr = new SqlCommand(sqlbr, newcnn);
            dataReaderbr = commandbr.ExecuteReader();

            while (dataReaderbr.Read())
            {
                //SubjectComboBoxAdd.Items.Add(dataReaderbr.GetValue(0).ToString());
                BranchComboBoxAdd.Items.Add(dataReaderbr.GetValue(0).ToString());
                BranchModify.Items.Add(dataReaderbr.GetValue(0).ToString());
                ActualBranchModifyComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());
            }
            try
            {
                ActualBranchModifyComboBox.SelectedIndex = 0;
            } catch (Exception ex)
            {

            }
            dataReaderbr.Close();
            //ActualBranchModifyComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //ActualBranchModifyComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            BranchComboBoxAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BranchComboBoxAdd.AutoCompleteSource = AutoCompleteSource.ListItems;
            BranchModify.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            BranchModify.AutoCompleteSource = AutoCompleteSource.ListItems;
            newcnn.Close();
        }
        void FillStudentData(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtb = new DataTable();
                sqlDa.Fill(dtb);
                DataGridSubject.DataSource = dtb;
                sqlCon.Close();
            }
        }

        void FillBranchData(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtb = new DataTable();
                sqlDa.Fill(dtb);
                BranchDataGrid.DataSource = dtb;
                sqlCon.Close();
            }
        }

        private void AddPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string subjectnamequery = SubjectNameView.Text.Trim();

            string semesterquery = SemesterView.Text.Trim();

            string subjectcodequery = SubjectCodeView.Text.Trim();

            string branchquery = BranchView.Text.Trim();
            if (!subjectnamequery.Equals(""))
            {
                subjectnamequery = " Title like \'%" + subjectnamequery + "%\' and";
            }

            if (!semesterquery.Equals(""))
            {
                semesterquery = " Semester like \'%" + semesterquery + "%\' and";
            }

            if (!subjectcodequery.Equals(""))
            {
                subjectcodequery = " dbo.BranchSubject.Code like \'%" + subjectcodequery + "%\' and";
            }

            if (!branchquery.Equals(""))
            {
                branchquery = " Branch like \'%" + branchquery + "%\' and";
            }

            string query = "select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code and" + subjectnamequery + semesterquery + subjectcodequery + branchquery;
            query = query.Substring(0, query.Length - 3) + ";";
            //MessageBox.Show(query);
            if (subjectnamequery.Equals("") && semesterquery.Equals("") && subjectcodequery.Equals("") && branchquery.Equals(""))
            {
                FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
            }
            else
            {
                try
                {
                    FillStudentData(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured with the query. Kindly try again.");
                    FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;








            SqlCommand command;

            string sql;



            //MessageBox.Show(date);

            try
            {


                if (!SemesterModify.Text.Trim().Equals(""))
                {
                    cmd.CommandText = "update dbo.BranchSubject set Semester=\'" + SemesterModify.Text.ToString() + "\' where Branch=\'" + BranchModify.Text.ToString() + "\' and Code=\'" + SubjectModify.SelectedItem.ToString().Trim() +"\'; ";//insert dbo.BranchSubject (Branch, Code, Semester) values (\'" + BranchComboBoxAdd.Text.Trim() + "\', \'" + SubjectComboBoxAdd.Text.Trim() + "\', \'" + SemesterAdd.Text.Trim() + "\');";

                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subject Successfully Updated.");
                        FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
                        SemesterModify.Text = "";
                        SubjectModify.Text = "";
                        SubjectGroupBox.Enabled = false;
                        BranchModify.Enabled = true;
                        button1.Enabled = true;
                        SubjectModify.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update the subject. Kindly check the details again and try again.");
                    }
                    sqlConnection1.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            } catch (Exception ex)
            {
                SubjectGroupBox.Enabled = false;
                BranchModify.Enabled = true;
                button1.Enabled = true;
                SubjectModify.Text = "";
            }
            
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {

            Boolean marksexist = false;
            SqlConnection sqlConnection2 = new SqlConnection(connectionString);
            SqlCommand markcmd = new SqlCommand();
            markcmd.CommandType = CommandType.Text;
            markcmd.CommandText = "select * from dbo.EnrollList, dbo.BranchSubject, dbo.StudentDetails where dbo.EnrollList.Code=dbo.BranchSubject.Code and dbo.BranchSubject.Branch=dbo.StudentDetails.Branch and dbo.EnrollList.RegNo = dbo.StudentDetails.RegNo and dbo.EnrollList.Code=\'" + SubjectModify.SelectedItem.ToString() + "\';";
            markcmd.Connection = sqlConnection2;
            sqlConnection2.Open();
            SqlDataReader stuff;
            stuff = markcmd.ExecuteReader();

            if (stuff.HasRows)
                marksexist = true;
            stuff.Close();
            sqlConnection2.Close();

            if (!marksexist)
            {
                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from dbo.BranchSubject where Branch=\'" + BranchModify.Text.Trim() + "\' and Code=\'" + SubjectModify.SelectedItem.ToString() + "\';";

                cmd.Connection = sqlConnection1;



                sqlConnection1.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Branch Subject Successfully Deleted.");
                    FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
                    BranchModify.Enabled = true;
                    button1.Enabled = true;
                    SubjectModify.Text = "";

                    SubjectGroupBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete the Branch Subject.");
                }

                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Students of this branch have currently enrolled into this subject. Unable to delete.");
                BranchModify.Enabled = true;
                button1.Enabled = true;
                SubjectModify.Text = "";

                SubjectGroupBox.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectModify.Items.Clear();
            cnn.Open();
            BranchModify.Enabled = false;
            button1.Enabled = false;
            string code_string = BranchModify.Text.Trim();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * from dbo.BranchSubject where Branch=\'" + code_string + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SubjectGroupBox.Enabled = true;
                    while (dataReader.Read())
                    {

                        SubjectModify.Items.Add(dataReader.GetValue(1).ToString());
                        SemesterModify.Text = dataReader.GetValue(2).ToString();

                    }
                    SubjectModify.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Branch not associated with any subject.");
                    SubjectGroupBox.Enabled = false;
                    BranchModify.Enabled = true;
                    button1.Enabled = true;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                SubjectGroupBox.Enabled = false;
                BranchModify.Enabled = true;
                button1.Enabled = true;
            }
            cnn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;








            SqlCommand command;

            string sql;



            //MessageBox.Show(date);


            if (!BranchComboBoxAdd.Text.Trim().Equals("") && !SubjectComboBoxAdd.Text.Trim().Equals("") && !SemesterAdd.Text.Trim().Equals(""))
            {
                cmd.CommandText = "insert dbo.BranchSubject (Branch, Code, Semester) values (\'" + BranchComboBoxAdd.Text.Trim() + "\', \'" + SubjectComboBoxAdd.Text.Trim() + "\', \'" + SemesterAdd.Text.Trim() + "\');";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Successfully Added.");
                    FillStudentData("select dbo.BranchSubject.Branch, dbo.BranchSubject.Code, dbo.Subject.Title, dbo.BranchSubject.Semester from dbo.BranchSubject, dbo.Subject where dbo.BranchSubject.Code=dbo.Subject.Code;");
                    BranchComboBoxAdd.Text = "";
                    SubjectComboBoxAdd.Text = "";
                    SemesterAdd.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add the subject. Kindly check the details again and try again.");
                }
                sqlConnection1.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void SemesterModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;








            SqlCommand command;

            string sql;



            //MessageBox.Show(date);


            if (!ActualBranchAdd.Text.Trim().Equals(""))
            {
                cmd.CommandText = "insert dbo.BranchList (Branch) values (\'" + ActualBranchAdd.Text.Trim() + "\');";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Branch Successfully Added.");
                    ActualBranchAdd.Text = "";
                    FillBranchData("select * from dbo.BranchList");
                    PopulateBranchComboBox();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add the branch. Kindly check the details again and try again.");
                }
                sqlConnection1.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = "delete from dbo.BranchList where Branch=\'" + ActualBranchModifyComboBox.SelectedItem.ToString().Trim() + "\';";
            } catch (Exception ex)
            {

            }

            cmd.Connection = sqlConnection1;

            if (!ActualBranchModifyComboBox.SelectedItem.ToString().Trim().Equals(""))
            {



                sqlConnection1.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Branch Successfully Deleted.");

                    ActualBranchModifyComboBox.Text = "";

                    FillBranchData("select * from dbo.BranchList");
                    PopulateBranchComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete the Branch.");
                }

                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields.");
            }

        }

        private void SubjectModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);

            cnn1.Open();

            SqlCommand command1;
            SqlDataReader dataReader1;
            string sql1;

            sql1 = "Select Semester from dbo.BranchSubject where Branch=\'" + BranchModify.Text.Trim() + "\' and Code=\'" + SubjectModify.SelectedItem.ToString() + "\';";

            command1 = new SqlCommand(sql1, cnn1);

            dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {

                SemesterModify.Text = dataReader1.GetValue(0).ToString();
                

            }

            dataReader1.Close();

            cnn1.Close();
        }

        private void BranchComboBoxAdd_TextChanged(object sender, EventArgs e)
        {
            SubjectComboBoxAdd.Items.Clear();
            cnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select Code from dbo.Subject where Code not in (select Code from dbo.BranchSubject where Branch=\'" +BranchComboBoxAdd.Text.Trim()+"\');";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            //BranchView.Items.Add("All Branches");

            while (dataReaderbr.Read())
            {
                SubjectComboBoxAdd.Items.Add(dataReaderbr.GetValue(0).ToString());
                //BranchModify.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            dataReaderbr.Close();


            //PopulateBranchComboBox();

            SubjectComboBoxAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SubjectComboBoxAdd.AutoCompleteSource = AutoCompleteSource.ListItems;


            cnn.Close();
        }

        private void BranchComboBoxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectComboBoxAdd.Items.Clear();
            cnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select Code from dbo.Subject where Code not in (select Code from dbo.BranchSubject where Branch=\'" + BranchComboBoxAdd.SelectedItem.ToString() + "\');";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            //BranchView.Items.Add("All Branches");

            while (dataReaderbr.Read())
            {
                SubjectComboBoxAdd.Items.Add(dataReaderbr.GetValue(0).ToString());
                //BranchModify.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            dataReaderbr.Close();


            //PopulateBranchComboBox();

            SubjectComboBoxAdd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SubjectComboBoxAdd.AutoCompleteSource = AutoCompleteSource.ListItems;


            cnn.Close();
        }
    }
}

