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
    public partial class LoginForm : Form
    {
        private TextBox username = new TextBox();
        private TextBox password = new TextBox();
        private Button login = new Button();
        private SqlConnection cnn;
        private string connectionString;

        public static string username_data;
        public static string password_data;
        public static string name_data;

        
        /*private ListBox lstBox = new ListBox();
        private CheckBox chkBox = new CheckBox();
        private Label lblCount = new Label();
        private Label username_label = new Label();
        private Label password_label = new Label();
        private TextBox username_tb = new TextBox();
        private TextBox password_tb = new TextBox();
        private Button login_button = new Button();*/
        public LoginForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            //string 
            //connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|".Substring(0, @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Data Directory|".Length-10) + @"\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //cnn.Open();

            /* this.Text = "University Transcript Creator";
             this.MaximizeBox = false;
             this.MinimizeBox = true;
             this.BackColor = Color.White;
             this.ForeColor = Color.Black;
             this.Size = new System.Drawing.Size(500, 300);
             this.WindowState = FormWindowState.Normal;
             this.FormBorderStyle = FormBorderStyle.FixedDialog;
             this.StartPosition = FormStartPosition.CenterScreen;*/

            /*this.btnAdd.BackColor = Color.Gray;
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(90, 25);
            this.btnAdd.Size = new System.Drawing.Size(50, 25);

            this.txtBox.Text = "Text";
            this.txtBox.Location = new System.Drawing.Point(10, 25);
            this.txtBox.Size = new System.Drawing.Size(70, 20);

            this.lstBox.Items.Add("One");
            this.lstBox.Items.Add("Two");
            this.lstBox.Items.Add("Three");
            this.lstBox.Items.Add("Four");
            this.lstBox.Sorted = true;
            this.lstBox.Location = new System.Drawing.Point(10, 55);
            this.lstBox.Size = new System.Drawing.Size(130, 95);


            this.chkBox.Text = "Disable";
            this.chkBox.Location = new System.Drawing.Point(15, 190);
            this.chkBox.Size = new System.Drawing.Size(110, 30);

            this.lblCount.Text = lstBox.Items.Count.ToString() + " items";
            this.lblCount.Location = new System.Drawing.Point(55, 160);
            this.lblCount.Size = new System.Drawing.Size(65, 15);*/

            /*this.username_label.Text = "Please enter the username:";
            this.username_label.Location = new System.Drawing.Point(30, 60);
            this.username_label.Size = new System.Drawing.Size(200, 15);

            this.username_tb.Location = new System.Drawing.Point(30, 90);
            this.username_tb.Size = new System.Drawing.Size(200, 15);



            this.password_label.Text = "Please enter the password:";
            this.password_label.Location = new System.Drawing.Point(30, 120);
            this.password_label.Size = new System.Drawing.Size(200, 15);

            this.password_tb.Location = new System.Drawing.Point(30, 150);
            this.password_tb.Size = new System.Drawing.Size(200, 15);
            this.password_tb.PasswordChar = '*';

            this.login_button.Location = new System.Drawing.Point(320, 117);
            this.login_button.Text = "Login";
            this.login_button.Size = new System.Drawing.Size(100, 30);

            this.Controls.Add(username_label);
            this.Controls.Add(password_label);
            this.Controls.Add(username_tb);
            this.Controls.Add(password_tb);
            this.Controls.Add(login_button);*/
            /*this.Controls.Add(btnAdd);
            this.Controls.Add(txtBox);
            this.Controls.Add(lstBox);
            this.Controls.Add(chkBox);
            this.Controls.Add(lblCount);*/

            /* Database2DataSet. UniversityDataset = Database2DataSet.UsersDataTable;

             Database2DataSet.UsersRow user = Database2DataSet.Users.FindByUserName("Hola");*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Close();
            string username_string = username.Text.Trim();
            string password_string = password.Text;

            username_data = username.Text.Trim();
            password_data = password.Text;


            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "Select Password from dbo.Users where UserName=\'" + username_string + "\'";

            command = new SqlCommand(sql, cnn);

            try
            {

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    try
                    {
                        Output = Output + dataReader.GetValue(0);
                    }
                    catch (Exception exc)
                    {
                        Output = "";
                    }
                }

                if (password_string.Equals(Output) && !Output.Equals(""))
                {
                    dataReader.Close();
                    cnn.Close();
                    MainForm form2 = new MainForm();
                    //form2.Closed += (s, args) => this.Close();
                    form2.Show();
                    password.Text = "";
                    username.Text = "";
                    this.Hide();

                    cnn.Open();
                    sql = "Select Name from dbo.Users where UserName=\'" + username_string + "\' and Password=\'"+password_string+"\';";
                    command = new SqlCommand(sql, cnn);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        try
                        {
                            name_data =  dataReader.GetValue(0).ToString();
                        }
                        catch (Exception exc)
                        {
                            
                        }
                    }

                    dataReader.Close();

                    cnn.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                    cnn.Close();

                }
                dataReader.Close();
                //cnn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = (TextBox)sender;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = (TextBox)sender;
        }

        public string getName()
        {
            return name_data;
        }
        public string getUsername()
        {
            return username_data;
        }

        public string getPassword()
        {
            return password_data;
        }
    }
}
