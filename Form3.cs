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
using System.Data;


namespace UniversityTranscriptCreator
{
    public partial class ManageStudentForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        private TextBox ModifyRegNo = new TextBox();

        public ManageStudentForm()
        {
            InitializeComponent();
            System.Text.RegularExpressions.Regex.IsMatch(AddPhNo.Text, "[ ^ 0-9]");
            AddDOBCalendar.MaxDate = DateTime.Now;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            StudentGroupBox.Enabled = false;
            AddDOBCalendar.MaxSelectionCount = 1;
            FillStudentData("select * from dbo.StudentDetails;");

            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select distinct Branch from dbo.BranchSubject";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            BranchView.Items.Add("All Branches");

            while (dataReaderbr.Read())
            {
                AddBranchComboBox.Items.Add(dataReaderbr.GetValue(0).ToString());
                BranchComboBoxModify.Items.Add(dataReaderbr.GetValue(0).ToString());
                BranchView.Items.Add(dataReaderbr.GetValue(0).ToString());
            }

            AddBranchComboBox.SelectedIndex = 0;

            BranchView.SelectedIndex = 0;


            dataReaderbr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPhNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



        private void PhNoModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DOBModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RegNoModify.Enabled = false;
            button1.Enabled = false;
            string regno_string = ModifyRegNo.Text.Trim();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "Select * from dbo.StudentDetails where RegNo=\'" + regno_string + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    StudentGroupBox.Enabled = true;
                    while (dataReader.Read())
                    {

                        NameModify.Text = dataReader.GetValue(1).ToString();
                        PhNoModify.Text = dataReader.GetValue(2).ToString();
                        BranchComboBoxModify.Text = dataReader.GetValue(3).ToString();
                        DOBModify.Text = dataReader.GetValue(4).ToString().Substring(0, 10).Replace('-', '/');
                    }
                }
                else
                {
                    MessageBox.Show("Student not found.");
                    StudentGroupBox.Enabled = false;
                    RegNoModify.Enabled = true;
                    button1.Enabled = true;
                }
                dataReader.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                RegNoModify.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void RegNoModify_TextChanged(object sender, EventArgs e)
        {
            ModifyRegNo = (TextBox)sender;
        }

        void FillStudentData(string query)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                DataTable dtb = new DataTable();
                sqlDa.Fill(dtb);
                DataGridStudent.DataSource = dtb;

            }
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;
            string date = DOBModify.Text.Trim();
            string[] caldate = date.Split('/');
            date = caldate[2] + caldate[1] + caldate[0];
            sql = "Update dbo.StudentDetails set Name=\'" + NameModify.Text.Trim() + "\', Phone_Number=\'" + PhNoModify.Text.Trim() + "\', Branch=\'" + BranchComboBoxModify.SelectedItem.ToString() + "\', DOB = \'" + date + "\' where RegNo=\'" + RegNoModify.Text.Trim() + "\';";

            command = new SqlCommand(sql, cnn);

            try
            {
                dataReader = command.ExecuteReader();
                MessageBox.Show("Details Successfully updated.");
                StudentGroupBox.Enabled = false;
                dataReader.Close();
                RegNoModify.Enabled = true;
                button1.Enabled = true;
                DOBModify.Text = "";
                PhNoModify.Text = "";
                NameModify.Text = "";

            } catch (Exception ex)
            {
                MessageBox.Show("Unable to Update Details. Kindly check the details again and try again." + ex.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection1 = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;








            SqlCommand command;

            string sql;

            string date;

            string[] caldate = AddDOBCalendar.SelectionRange.Start.ToShortDateString().Split('-');



            date = caldate[2] + "-" + caldate[1] + "-" + caldate[0];

            //MessageBox.Show(date);


            if (!AddRegNo.Text.Trim().Equals("") && !AddName.Text.Trim().Equals("") && !AddPhNo.Text.Trim().Equals(""))
            {
                cmd.CommandText = "insert dbo.StudentDetails (RegNo, Name, Phone_Number, Branch, DOB) values (\'" + AddRegNo.Text.Trim() + "\', \'" + AddName.Text.Trim() + "\', \'" + AddPhNo.Text.Trim() + "\', \'" + AddBranchComboBox.SelectedItem.ToString() + "\', \'" + date + "\');";

                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Successfully Added.");
                    AddPhNo.Text = "";
                    AddRegNo.Text = "";
                    AddName.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to add Student. Kindly check the details again and try again.");
                }
                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields.");
            }

            //command = new SqlCommand(sql, cnn);


            /*try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Added.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to add Student. Kindly check the details again and try again." + ex.ToString());
            }*/

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dbo.StudentDetails where RegNo=\'" + RegNoModify.Text.Trim() + "\';";

            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Successfully Deleted.");
                RegNoModify.Enabled = true;
                button1.Enabled = true;
                DOBModify.Text = "";
                PhNoModify.Text = "";
                NameModify.Text = "";
                StudentGroupBox.Enabled = false;
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to delete Student.");
            }

            sqlConnection1.Close();
        }

        private void PhNoView_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DOBView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '/')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string namequery = NameView.Text.Trim();
            string branchquery = BranchView.SelectedItem.ToString();
            string phnoquery = PhNoView.Text.Trim();
            string dobquery = DOBView.Text.Trim();
            string regnoquery = RegNoView.Text.Trim();
            if (!namequery.Equals(""))
            {
                namequery = " Name like \'%" + namequery + "%\' and";
            }
            if (!branchquery.Equals("All Branches"))
            {
                branchquery = " Branch like \'%" + branchquery + "%\' and";
            } else
            {
                branchquery = "";
            }
            if (!phnoquery.Equals(""))
            {
                phnoquery = " Phone_Number like \'%" + phnoquery + "%\' and";
            }
            if (!dobquery.Equals(""))
            {
                string[] inter = dobquery.Split('/');
                try
                {
                    dobquery = inter[2] + "-" + inter[1] + "-" + inter[0];
                    dobquery = " DOB like \'%" + dobquery + "%\' and";
                } catch (Exception ex)
                {
                    dobquery = " DOB like \'%" + dobquery + "%\' and";
                }
            }
            if (!regnoquery.Equals(""))
            {
                regnoquery = " RegNo like \'%" + regnoquery + "%\' and";
            }
            string query = "select * from dbo.StudentDetails where" + namequery + branchquery + phnoquery + dobquery + regnoquery;
            query = query.Substring(0, query.Length-3) + ";";
            //MessageBox.Show(query);
            if (dobquery.Equals("") && regnoquery.Equals("") && branchquery.Equals("All Branches") && phnoquery.Equals("") && dobquery.Equals(""))
            {
                FillStudentData("select * from dbo.StudentDetails;");
            }
            else
            {
                try
                {
                    FillStudentData(query);
                } catch (Exception ex)
                {
                    MessageBox.Show("An error occured with the query. Kindly try again." + ex.ToString());
                    FillStudentData("select * from dbo.StudentDetails;");
                }
            }
        }
    }
}
  

