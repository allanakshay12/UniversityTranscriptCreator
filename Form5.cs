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
    public partial class EnrollmentForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        public EnrollmentForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            //cnn.Open();
            SubjectGroupBox.Enabled = false;
            FillStudentData("select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code;");
            cnn.Open();



            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select RegNo from dbo.StudentDetails;";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            //BranchView.Items.Add("All Branches");

            while (dataReaderbr.Read())
            {
                AddCode.Items.Add(dataReaderbr.GetValue(0).ToString());
                CodeModify.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            AddCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AddCode.AutoCompleteSource = AutoCompleteSource.ListItems;
            CodeModify.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CodeModify.AutoCompleteSource = AutoCompleteSource.ListItems;

            //AddBranchComboBox.SelectedIndex = 0;

            //BranchView.SelectedIndex = 0;


            dataReaderbr.Close();

            /*sqlbr = "Select RegNo from dbo.StudentDetails";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();
            while (dataReaderbr.Read())
            {
                AddCode.Items.Add(dataReaderbr.GetValue(0).ToString());

            }
            dataReaderbr.Close();

            cnn.Close();*/

            //AddSubjectName.Enabled = false;


            cnn.Close();

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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string namequery = SubjectNameView.Text.Trim();

            string regnoquery = CodeView.Text.Trim();
            if (!namequery.Equals(""))
            {
                namequery = " dbo.EnrollList.Code like \'%" + namequery + "%\' and";
            }

            if (!regnoquery.Equals(""))
            {
                regnoquery = " RegNo like \'%" + regnoquery + "%\' and";
            }
            string query = "select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code and" + namequery + regnoquery;
            query = query.Substring(0, query.Length - 3) + ";";
            //MessageBox.Show(query);
            if (namequery.Equals("") && regnoquery.Equals(""))
            {
                FillStudentData("select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code;");
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
                    FillStudentData("select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code;");
                }
            }
        }

        private void AddCode_TextUpdate(object sender, EventArgs e)
        {
            AddSubjectName.Items.Clear();
            cnn.Open();



            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;
            try 
            { 
            sqlbr = "Select Code from dbo.StudentDetails, dbo.BranchSubject where dbo.StudentDetails.Branch=dbo.BranchSubject.Branch and RegNo=\'" + ((ComboBox)sender).Text.Trim()+"\' and Code not in (select Code from dbo.EnrollList where RegNo=\'" + ((ComboBox)sender).Text.Trim() + "\');";

            commandbr = new SqlCommand(sqlbr, cnn);
            
                dataReaderbr = commandbr.ExecuteReader();

                //BranchView.Items.Add("All Branches");

                while (dataReaderbr.Read())
                {
                    AddSubjectName.Items.Add(dataReaderbr.GetValue(0).ToString());

                }
                AddSubjectName.SelectedIndex = 0;

                //AddBranchComboBox.SelectedIndex = 0;

                //BranchView.SelectedIndex = 0;


                dataReaderbr.Close();
            } catch(Exception ex)
            {

            }

            cnn.Close();
        }

        private void AddCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            AddSubjectName.Items.Clear();
            cnn.Open();



            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;
            try
            {
                sqlbr = "Select Code from dbo.StudentDetails, dbo.BranchSubject where dbo.StudentDetails.Branch=dbo.BranchSubject.Branch and RegNo=\'" + ((ComboBox)sender).SelectedItem.ToString() + "\' and Code not in (select Code from dbo.EnrollList where RegNo=\'" + ((ComboBox)sender).SelectedItem.ToString() + "\');";

                commandbr = new SqlCommand(sqlbr, cnn);

                dataReaderbr = commandbr.ExecuteReader();

                //BranchView.Items.Add("All Branches");

                

                while (dataReaderbr.Read())
                {
                    AddSubjectName.Items.Add(dataReaderbr.GetValue(0).ToString());

                }
                AddSubjectName.SelectedIndex = 0;
                //AddBranchComboBox.SelectedIndex = 0;

                //BranchView.SelectedIndex = 0;


                dataReaderbr.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
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

            try
            {


                if (!AddCode.SelectedItem.ToString().Trim().Equals("") && !AddSubjectName.SelectedItem.ToString().Trim().Equals(""))
                {
                    cmd.CommandText = "insert dbo.EnrollList (RegNo, Code) values (\'" + AddCode.SelectedItem.ToString().Trim() + "\', \'" + AddSubjectName.SelectedItem.ToString().Trim() + "\');";

                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Student Successfully Enrolled.");
                        FillStudentData("select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code;");
                        AddCode.Text = "";
                        AddSubjectName.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to enroll Student. Kindly check the details again and try again.");
                    }
                    sqlConnection1.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to enroll Student. Kindly check the details again and try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubjectNameModify.Items.Clear();
            cnn.Open();
            CodeModify.Enabled = false;
            button1.Enabled = false;
            string code_string = CodeModify.Text.Trim();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * from dbo.EnrollList where RegNo=\'" + code_string + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SubjectGroupBox.Enabled = true;
                    while (dataReader.Read())
                    {

                        SubjectNameModify.Items.Add(dataReader.GetValue(1).ToString());

                    }
                    SubjectNameModify.SelectedIndex = 0;
                    
                }
                else
                {
                    MessageBox.Show("Student not enrolled in any subject.");
                    SubjectGroupBox.Enabled = false;
                    CodeModify.Enabled = true;
                    button1.Enabled = true;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                SubjectGroupBox.Enabled = false;
                CodeModify.Enabled = true;
                button1.Enabled = true;
            }
            cnn.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SubjectGroupBox.Enabled = false;
            CodeModify.Enabled = true;
            button1.Enabled = true;
            SubjectNameModify.Text = "";
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            Boolean marksexist = false;
            SqlConnection sqlConnection2 = new SqlConnection(connectionString);
            SqlCommand markcmd  = new SqlCommand();
            markcmd.CommandType = CommandType.Text;
            markcmd.CommandText = "select RegNo from dbo.Marks where RegNo=\'" + CodeModify.Text.Trim() + "\' and Code=\'" + SubjectNameModify.SelectedItem.ToString() + "\';";
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
                cmd.CommandText = "delete from dbo.EnrollList where RegNo=\'" + CodeModify.Text.Trim() + "\' and Code=\'" + SubjectNameModify.SelectedItem.ToString() + "\';";

                cmd.Connection = sqlConnection1;



                sqlConnection1.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Enrollment Successfully Deleted.");
                    FillStudentData("select dbo.EnrollList.RegNo, dbo.EnrollList.Code, dbo.Subject.Title from dbo.EnrollList, dbo.Subject where dbo.EnrollList.Code=dbo.Subject.Code;");
                    CodeModify.Enabled = true;
                    button1.Enabled = true;
                    SubjectNameModify.Text = "";

                    SubjectGroupBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to delete the Enrollment.");
                }

                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Marks exist for this student in the selected subject. Can't delete the enrollment.");
                CodeModify.Enabled = true;
                button1.Enabled = true;
                SubjectNameModify.Text = "";

                SubjectGroupBox.Enabled = false;
            }
        }
    }
}
