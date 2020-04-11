namespace UniversityTranscriptCreator
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YourProfileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YourProfileUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YourProfilePassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeletePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.UpdateProfileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateProfileButton);
            this.groupBox1.Controls.Add(this.YourProfilePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.YourProfileUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.YourProfileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // YourProfileName
            // 
            this.YourProfileName.Location = new System.Drawing.Point(10, 37);
            this.YourProfileName.Name = "YourProfileName";
            this.YourProfileName.Size = new System.Drawing.Size(152, 20);
            this.YourProfileName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // YourProfileUsername
            // 
            this.YourProfileUsername.Location = new System.Drawing.Point(10, 87);
            this.YourProfileUsername.Name = "YourProfileUsername";
            this.YourProfileUsername.Size = new System.Drawing.Size(152, 20);
            this.YourProfileUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // YourProfilePassword
            // 
            this.YourProfilePassword.Location = new System.Drawing.Point(10, 140);
            this.YourProfilePassword.Name = "YourProfilePassword";
            this.YourProfilePassword.PasswordChar = '*';
            this.YourProfilePassword.Size = new System.Drawing.Size(152, 20);
            this.YourProfilePassword.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateUserButton);
            this.groupBox2.Controls.Add(this.NewPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NewUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NewName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(190, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 222);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Profile";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(9, 140);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.PasswordChar = '*';
            this.NewPassword.Size = new System.Drawing.Size(148, 20);
            this.NewPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(9, 87);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(148, 20);
            this.NewUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Username:";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(9, 37);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(148, 20);
            this.NewName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteUserButton);
            this.groupBox3.Controls.Add(this.DeletePassword);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DeleteUsername);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.DeleteName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(363, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 222);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Profile";
            // 
            // DeletePassword
            // 
            this.DeletePassword.Location = new System.Drawing.Point(10, 140);
            this.DeletePassword.Name = "DeletePassword";
            this.DeletePassword.PasswordChar = '*';
            this.DeletePassword.Size = new System.Drawing.Size(149, 20);
            this.DeletePassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Password:";
            // 
            // DeleteUsername
            // 
            this.DeleteUsername.Location = new System.Drawing.Point(10, 87);
            this.DeleteUsername.Name = "DeleteUsername";
            this.DeleteUsername.Size = new System.Drawing.Size(149, 20);
            this.DeleteUsername.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Username:";
            // 
            // DeleteName
            // 
            this.DeleteName.Location = new System.Drawing.Point(10, 37);
            this.DeleteName.Name = "DeleteName";
            this.DeleteName.Size = new System.Drawing.Size(149, 20);
            this.DeleteName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.BackColor = System.Drawing.Color.White;
            this.DeleteUserButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteUserButton.Image")));
            this.DeleteUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUserButton.Location = new System.Drawing.Point(6, 173);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.DeleteUserButton.Size = new System.Drawing.Size(153, 38);
            this.DeleteUserButton.TabIndex = 16;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.Color.White;
            this.CreateUserButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateUserButton.Image")));
            this.CreateUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateUserButton.Location = new System.Drawing.Point(9, 173);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.CreateUserButton.Size = new System.Drawing.Size(148, 38);
            this.CreateUserButton.TabIndex = 16;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateUserButton.UseVisualStyleBackColor = false;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // UpdateProfileButton
            // 
            this.UpdateProfileButton.BackColor = System.Drawing.Color.White;
            this.UpdateProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateProfileButton.Image")));
            this.UpdateProfileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProfileButton.Location = new System.Drawing.Point(10, 173);
            this.UpdateProfileButton.Name = "UpdateProfileButton";
            this.UpdateProfileButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.UpdateProfileButton.Size = new System.Drawing.Size(152, 38);
            this.UpdateProfileButton.TabIndex = 16;
            this.UpdateProfileButton.Text = "Update Profile";
            this.UpdateProfileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateProfileButton.UseVisualStyleBackColor = false;
            this.UpdateProfileButton.Click += new System.EventHandler(this.UpdateProfileButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 248);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Manage Users";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YourProfilePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox YourProfileUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YourProfileName;
        private System.Windows.Forms.Button UpdateProfileButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.TextBox DeletePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeleteUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeleteName;
        private System.Windows.Forms.Label label9;
    }
}