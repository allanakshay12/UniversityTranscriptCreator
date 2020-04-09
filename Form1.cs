using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityTranscriptCreator
{
    public partial class Form1 : Form
    {
        private TextBox txtBox = new TextBox();
        private Button btnAdd = new Button();
        private ListBox lstBox = new ListBox();
        private CheckBox chkBox = new CheckBox();
        private Label lblCount = new Label();
        private Label username_label = new Label();
        private Label password_label = new Label();
        private TextBox username_tb = new TextBox();
        private TextBox password_tb = new TextBox();
        private Button login_button = new Button();
        public Form1()
        {
            InitializeComponent();
            this.Text = "University Transcript Creator";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(500, 300);
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

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

            this.username_label.Text = "Please enter the username:";
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
            this.Controls.Add(login_button);
            /*this.Controls.Add(btnAdd);
            this.Controls.Add(txtBox);
            this.Controls.Add(lstBox);
            this.Controls.Add(chkBox);
            this.Controls.Add(lblCount);*/
        }
    }
}

