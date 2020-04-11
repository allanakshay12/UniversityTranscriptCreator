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
    public partial class UserForm : Form
    {
        private string connectionString;
        public UserForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            /*FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "UserForm")
                {

                    YourProfileUsername.Text = ((LoginForm)frm).getUsername();
                    YourProfilePassword.Text = ((LoginForm)frm).getPassword();
                    YourProfileName.Text = ((LoginForm)frm).getName();
                }
            }*/

            YourProfileUsername.Text = LoginForm.username_data;
            YourProfilePassword.Text = LoginForm.password_data;
            YourProfileName.Text = LoginForm.name_data;

            YourProfileUsername.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProfileButton_Click(object sender, EventArgs e)
        {
            if (!YourProfileUsername.Text.Equals("") && !YourProfilePassword.Text.Equals("") && !YourProfileName.Text.Trim().Equals(""))
            {
                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "delete from dbo.BranchSubject where Branch=\'" + BranchModify.Text.Trim() + "\' and Code=\'" + SubjectModify.SelectedItem.ToString() + "\';";
            cmd.CommandText = "Update dbo.Users set Name=\'" + YourProfileName.Text.Trim() + "\', Password=\'" + YourProfilePassword.Text + "\' where UserName=\'" + YourProfileUsername.Text + "\';";
            cmd.Connection = sqlConnection1;



            sqlConnection1.Open();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Successfully Updated.");
                LoginForm.username_data = YourProfileUsername.Text;
                LoginForm.password_data = YourProfilePassword.Text;
                LoginForm.name_data = YourProfileName.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update your profile.");
            }

            sqlConnection1.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            string digsign = Guid.NewGuid().ToString();
            if (!NewName.Text.Trim().Equals("") && !NewPassword.Equals("") && !NewUsername.Text.Trim().Equals(""))
            {
                SqlConnection sqlConnection1 = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "delete from dbo.BranchSubject where Branch=\'" + BranchModify.Text.Trim() + "\' and Code=\'" + SubjectModify.SelectedItem.ToString() + "\';";

                cmd.CommandText = "insert dbo.Users (Name, UserName, Password, DigitalSignature) values (\'" + NewName.Text.Trim() + "\', \'" + NewUsername.Text.Trim() + "\', \'" + NewPassword.Text + "\', \'" + digsign + "\');";
                cmd.Connection = sqlConnection1;
                sqlConnection1.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Created.");
                    NewName.Text = "";
                    NewPassword.Text = "";
                    NewUsername.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create user.");
                }

                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            SqlDataReader dataReaderbr;
            SqlConnection sqlConnection1 = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Users where UserName = \'" + DeleteUsername.Text.Trim() + "\' and Name = \'" + DeleteName.Text.Trim() + "\' and Password = \'" + DeletePassword.Text + "\';";
            cmd.Connection = sqlConnection1;
            

            if (!DeleteName.Text.Trim().Equals("") && !DeletePassword.Equals("") && !DeleteUsername.Text.Trim().Equals(""))
            {
                

                sqlConnection1.Open();
                try
                {
                    dataReaderbr = cmd.ExecuteReader();
                    if(dataReaderbr.HasRows)
                    {
                        if (!DeleteUsername.Text.Trim().Equals(LoginForm.username_data))
                        {
                            SqlConnection sqlConnection2 = new SqlConnection(connectionString);
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "delete from dbo.Users where UserName=\'" + DeleteUsername.Text.Trim() + "\';";
                            cmd1.Connection = sqlConnection2;
                            try
                            {
                                sqlConnection2.Open();
                                cmd1.ExecuteNonQuery();
                                DeleteUsername.Text = "";
                                DeletePassword.Text = "";
                                DeleteName.Text = "";
                                MessageBox.Show("User Successfully Deleted.");
                                sqlConnection2.Close();
                            }
                            catch (Exception ex)
                            {
                                sqlConnection2.Close();
                                MessageBox.Show("Unable to delete user.");
                            }
                        } else
                        {
                            MessageBox.Show("You cannot delete your own account.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Credentials don't match any user\'s credentials.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("The Credentials don't match any user\'s credentials.");
                }
                sqlConnection1.Close();
            } else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }
    }
}
