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
    public partial class SubjectForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        public SubjectForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            //cnn.Open();
            SubjectGroupBox.Enabled = false;
            FillStudentData("select * from dbo.Subject;");
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;








            SqlCommand command;

            string sql;

           

            //MessageBox.Show(date);


            if (!AddCode.Text.Trim().Equals("") && !AddSubjectName.Text.Trim().Equals(""))
            {
                cmd.CommandText = "insert dbo.Subject (Code, Title) values (\'" + AddCode.Text.Trim() + "\', \'" + AddSubjectName.Text.Trim() + "\');";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Successfully Added.");
                    FillStudentData("select * from dbo.Subject;");
                    AddCode.Text = "";
                    AddSubjectName.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Subject. Kindly check the details again and try again.");
                }
                sqlConnection1.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            CodeModify.Enabled = false;
            button1.Enabled = false;
            string code_string = CodeModify.Text.Trim();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * from dbo.Subject where Code=\'" + code_string + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SubjectGroupBox.Enabled = true;
                    while (dataReader.Read())
                    {

                        SubjectNameModify.Text = dataReader.GetValue(1).ToString();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Subject not found.");
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

        private void UpdateSubject_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            
            sql = "Update dbo.Subject set Title=\'" + SubjectNameModify.Text.Trim() +  "\' where Code=\'" + CodeModify.Text.Trim() + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {
                dataReader = command.ExecuteReader();
                MessageBox.Show("Details Successfully updated.");
                FillStudentData("select * from dbo.Subject;");
                SubjectGroupBox.Enabled = false;
                dataReader.Close();
                CodeModify.Enabled = true;
                button1.Enabled = true;
                SubjectNameModify.Text = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update Details. Kindly check the details again and try again.");
            }
            cnn.Close();
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dbo.Subject where Code=\'" + CodeModify.Text.Trim() + "\';";

            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject Successfully Deleted.");
                FillStudentData("select * from dbo.Subject;");
                CodeModify.Enabled = true;
                button1.Enabled = true;
                SubjectNameModify.Text = "";
        
                SubjectGroupBox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete Subject.");
            }

            sqlConnection1.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string namequery = SubjectNameView.Text.Trim();
           
            string regnoquery = CodeView.Text.Trim();
            if (!namequery.Equals(""))
            {
                namequery = " Title like \'%" + namequery + "%\' and";
            }
       
            if (!regnoquery.Equals(""))
            {
                regnoquery = " Code like \'%" + regnoquery + "%\' and";
            }
            string query = "select * from dbo.Subject where" + namequery + regnoquery;
            query = query.Substring(0, query.Length - 3) + ";";
            //MessageBox.Show(query);
            if (namequery.Equals("") && regnoquery.Equals(""))
            {
                FillStudentData("select * from dbo.Subject;");
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
                    FillStudentData("select * from dbo.Subject;");
                }
            }
        }
    }
}
