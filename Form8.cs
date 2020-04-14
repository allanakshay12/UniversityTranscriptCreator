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
    public partial class MarksForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        public MarksForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            //cnn.Open();
            SubjectGroupBox.Enabled = false;
            FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
            cnn.Open();

            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select RegNo from dbo.StudentDetails;";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            while (dataReaderbr.Read())
            {
                AddStudentRegNoComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());
                ModifyRegNoComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            AddStudentRegNoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AddStudentRegNoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            ModifyRegNoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ModifyRegNoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            dataReaderbr.Close();
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AddMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddOutOf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SemesterModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SemesterView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void AddStudentRegNoComboBox_TextUpdate(object sender, EventArgs e)
        {
            AddSubjectComboBox.Items.Clear();
            cnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;
            try
            {
                sqlbr = "Select dbo.BranchSubject.Code from dbo.StudentDetails, dbo.BranchSubject, dbo.EnrollList where dbo.BranchSubject.Branch=dbo.StudentDetails.Branch and dbo.BranchSubject.Code=dbo.EnrollList.Code and dbo.EnrollList.RegNo=dbo.StudentDetails.RegNo and dbo.StudentDetails.RegNo=\'" + ((ComboBox)sender).Text.Trim() + "\' and dbo.BranchSubject.Code not in (select Code from dbo.Marks where RegNo=\'" + ((ComboBox)sender).Text.Trim() + "\');";

                commandbr = new SqlCommand(sqlbr, cnn);

                dataReaderbr = commandbr.ExecuteReader();

                //BranchView.Items.Add("All Branches");

                while (dataReaderbr.Read())
                {
                    AddSubjectComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());

                }
                AddSubjectComboBox.SelectedIndex = 0;

                //AddBranchComboBox.SelectedIndex = 0;

                //BranchView.SelectedIndex = 0;


                dataReaderbr.Close();
            }
            catch (Exception ex)
            {

            }

            cnn.Close();
        }

        private void AddStudentRegNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddSubjectComboBox.Items.Clear();
            cnn.Open();



            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;
            try
            {
                sqlbr = "Select dbo.BranchSubject.Code from dbo.StudentDetails, dbo.BranchSubject, dbo.EnrollList where dbo.BranchSubject.Branch=dbo.StudentDetails.Branch and dbo.BranchSubject.Code=dbo.EnrollList.Code and dbo.EnrollList.RegNo=dbo.StudentDetails.RegNo and dbo.StudentDetails.RegNo=\'" + ((ComboBox)sender).SelectedItem.ToString().Trim() + "\' and dbo.BranchSubject.Code not in (select Code from dbo.Marks where RegNo=\'" + ((ComboBox)sender).SelectedItem.ToString().Trim() + "\');";

                commandbr = new SqlCommand(sqlbr, cnn);

                dataReaderbr = commandbr.ExecuteReader();

                //BranchView.Items.Add("All Branches");



                while (dataReaderbr.Read())
                {
                    AddSubjectComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());

                }
                AddSubjectComboBox.SelectedIndex = 0;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string namequery = ViewSubjectName.Text.Trim();

            string codequery = ViewSubject.Text.Trim();

            string regnoquery = ViewRegistrationNo.Text.Trim();

            string marksquery = ViewMarks.Text.Trim();

            string outofquery = ViewOutOf.Text.Trim();
            if (!codequery.Equals(""))
            {
                codequery = " dbo.Marks.Code like \'%" + codequery + "%\' and";
            }

            if (!regnoquery.Equals(""))
            {
                regnoquery = " RegNo like \'%" + regnoquery + "%\' and";
            }

            if (!namequery.Equals(""))
            {
                namequery = " Title like \'%" + namequery + "%\' and";
            }

            if (!marksquery.Equals(""))
            {
                marksquery = " Marks like \'%" + marksquery + "%\' and";
            }

            if (!outofquery.Equals(""))
            {
                outofquery = " Out_Of like \'%" + outofquery + "%\' and";
            }
            string query = "select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code and" + codequery + namequery + regnoquery + marksquery + outofquery;
            query = query.Substring(0, query.Length - 3) + ";";
            //MessageBox.Show(query);
            if (namequery.Equals("") && regnoquery.Equals("") && codequery.Equals("") && marksquery.Equals("") && outofquery.Equals(""))
            {
                FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
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
                    FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifySubjectComboBox.Items.Clear();
            cnn.Open();
            ModifyRegNoComboBox.Enabled = false;
            button1.Enabled = false;
            string regno_string = ModifyRegNoComboBox.Text.Trim();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * from dbo.Marks where RegNo=\'" + regno_string + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    SubjectGroupBox.Enabled = true;
                    while (dataReader.Read())
                    {

                        ModifySubjectComboBox.Items.Add(dataReader.GetValue(0).ToString());

                    }
                    ModifySubjectComboBox.SelectedIndex = 0;

                    SqlConnection cnn1 = new SqlConnection(connectionString);

                    cnn1.Open();

                    SqlCommand command1;
                    SqlDataReader dataReader1;
                    string sql1;

                    sql1 = "Select Marks, Out_Of from dbo.Marks where RegNo=\'" + regno_string + "\' and Code=\'" + ModifySubjectComboBox.SelectedItem.ToString() + "\';";

                    command1 = new SqlCommand(sql1, cnn1);

                    dataReader1 = command1.ExecuteReader();
                    while (dataReader1.Read())
                    {

                        ModifyMarks.Text = dataReader1.GetValue(0).ToString();
                        ModifyOutOf.Text = dataReader1.GetValue(1).ToString();

                    }

                    dataReader1.Close();

                    cnn1.Close();


                }
                else
                {
                    MessageBox.Show("Student hasn't secured marks in any subject.");
                    SubjectGroupBox.Enabled = false;
                    ModifyRegNoComboBox.Enabled = true;
                    button1.Enabled = true;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                SubjectGroupBox.Enabled = false;
                ModifyRegNoComboBox.Enabled = true;
                button1.Enabled = true;
            }
            cnn.Close();
        }

        private void ModifySubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection(connectionString);

            cnn1.Open();

            SqlCommand command1;
            SqlDataReader dataReader1;
            string sql1;

            sql1 = "Select Marks, Out_Of from dbo.Marks where RegNo=\'" + ModifyRegNoComboBox.Text.Trim() + "\' and Code=\'" + ModifySubjectComboBox.SelectedItem.ToString() + "\';";

            command1 = new SqlCommand(sql1, cnn1);

            dataReader1 = command1.ExecuteReader();
            while (dataReader1.Read())
            {

                ModifyMarks.Text = dataReader1.GetValue(0).ToString();
                ModifyOutOf.Text = dataReader1.GetValue(1).ToString();

            }

            dataReader1.Close();

            cnn1.Close();
        }

        private void DeleteSubject_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dbo.Marks where RegNo=\'" + ModifyRegNoComboBox.Text.Trim() + "\' and Code=\'" + ModifySubjectComboBox.SelectedItem.ToString() + "\';";

            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Marks Successfully Deleted.");
                FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
                ModifyRegNoComboBox.Enabled = true;
                button1.Enabled = true;
                ModifySubjectComboBox.Text = "";
                ModifyOutOf.Text = "";
                ModifyMarks.Text = "";
                SubjectGroupBox.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete the Marks.");
            }

            sqlConnection1.Close();
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


                if (!ModifyMarks.Text.Trim().Equals("") && !ModifyOutOf.Text.Trim().Equals(""))
                {
                    cmd.CommandText = "update dbo.Marks set Marks=\'" + ModifyMarks.Text.ToString() + "\', Out_Of=\'" + ModifyOutOf.Text.ToString() + "\' where RegNo=\'" + ModifyRegNoComboBox.Text.ToString() + "\' and Code=\'" + ModifySubjectComboBox.SelectedItem.ToString().Trim() + "\';";//insert dbo.BranchSubject (Branch, Code, Semester) values (\'" + BranchComboBoxAdd.Text.Trim() + "\', \'" + SubjectComboBoxAdd.Text.Trim() + "\', \'" + SemesterAdd.Text.Trim() + "\');";

                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Marks Successfully Updated.");
                        FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
                        ModifyMarks.Text = "";
                        ModifySubjectComboBox.Text = "";
                        SubjectGroupBox.Enabled = false;
                        ModifyRegNoComboBox.Enabled = true;
                        button1.Enabled = true;
                        ModifyOutOf.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to update the marks. Kindly check the details again and try again.");
                    }
                    sqlConnection1.Close();
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.");
                }
            }
            catch (Exception ex)
            {
                SubjectGroupBox.Enabled = false;
                ModifyRegNoComboBox.Enabled = true;
                button1.Enabled = true;
                ModifySubjectComboBox.Text = "";
                ModifyOutOf.Text = "";
                ModifyMarks.Text = "";
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


            if (!AddStudentRegNoComboBox.Text.Trim().Equals("") && !AddSubjectComboBox.Text.Trim().Equals("") && !AddMarks.Text.Trim().Equals("") && !AddOutOf.Text.Trim().Equals(""))
            {
                cmd.CommandText = "insert dbo.Marks (RegNo, Code, Marks, Out_Of) values (\'" + AddStudentRegNoComboBox.Text.Trim() + "\', \'" + AddSubjectComboBox.Text.Trim() + "\', \'" + AddMarks.Text.Trim() + "\', \'" + AddOutOf.Text.Trim() + "\');";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Marks Successfully Added.");
                    FillStudentData("select dbo.Marks.RegNo, dbo.Marks.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject where dbo.Marks.Code=dbo.Subject.Code;");
                    AddStudentRegNoComboBox.Text = "";
                    AddSubjectComboBox.Text = "";
                    AddMarks.Text = "";
                    AddOutOf.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add marks. Kindly check the details again and try again.");
                }
                sqlConnection1.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void AddSubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
