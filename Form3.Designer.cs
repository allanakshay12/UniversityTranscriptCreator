namespace UniversityTranscriptCreator
{
    partial class ManageStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddRegNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDOBCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPhNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBranchComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RegNoModify = new System.Windows.Forms.TextBox();
            this.StudentGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NameModify = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhNoModify = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BranchComboBoxModify = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DOBModify = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridStudent = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.RegNoView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NameView = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PhNoView = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BranchView = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DOBView = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.StudentGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddBranchComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddPhNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddDOBCalendar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddRegNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Number:";
            // 
            // AddRegNo
            // 
            this.AddRegNo.Location = new System.Drawing.Point(10, 42);
            this.AddRegNo.Name = "AddRegNo";
            this.AddRegNo.Size = new System.Drawing.Size(151, 20);
            this.AddRegNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(10, 98);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(151, 20);
            this.AddName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date of Birth:";
            // 
            // AddDOBCalendar
            // 
            this.AddDOBCalendar.Location = new System.Drawing.Point(10, 157);
            this.AddDOBCalendar.MaxDate = new System.DateTime(2026, 9, 25, 0, 0, 0, 0);
            this.AddDOBCalendar.Name = "AddDOBCalendar";
            this.AddDOBCalendar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number:";
            // 
            // AddPhNo
            // 
            this.AddPhNo.Location = new System.Drawing.Point(212, 42);
            this.AddPhNo.MaxLength = 10;
            this.AddPhNo.Name = "AddPhNo";
            this.AddPhNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddPhNo.Size = new System.Drawing.Size(151, 20);
            this.AddPhNo.TabIndex = 8;
            this.AddPhNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.AddPhNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPhNo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Branch:";
            // 
            // AddBranchComboBox
            // 
            this.AddBranchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddBranchComboBox.FormattingEnabled = true;
            this.AddBranchComboBox.Location = new System.Drawing.Point(212, 97);
            this.AddBranchComboBox.Name = "AddBranchComboBox";
            this.AddBranchComboBox.Size = new System.Drawing.Size(151, 21);
            this.AddBranchComboBox.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(10, 336);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(115, 0, 115, 0);
            this.AddButton.Size = new System.Drawing.Size(353, 53);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Student";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.StudentGroupBox);
            this.groupBox2.Controls.Add(this.RegNoModify);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(395, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify / Delete Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Registration Number:";
            // 
            // RegNoModify
            // 
            this.RegNoModify.Location = new System.Drawing.Point(10, 42);
            this.RegNoModify.Name = "RegNoModify";
            this.RegNoModify.Size = new System.Drawing.Size(175, 20);
            this.RegNoModify.TabIndex = 2;
            this.RegNoModify.TextChanged += new System.EventHandler(this.RegNoModify_TextChanged);
            // 
            // StudentGroupBox
            // 
            this.StudentGroupBox.Controls.Add(this.DeleteStudent);
            this.StudentGroupBox.Controls.Add(this.UpdateStudent);
            this.StudentGroupBox.Controls.Add(this.DOBModify);
            this.StudentGroupBox.Controls.Add(this.label10);
            this.StudentGroupBox.Controls.Add(this.BranchComboBoxModify);
            this.StudentGroupBox.Controls.Add(this.label9);
            this.StudentGroupBox.Controls.Add(this.PhNoModify);
            this.StudentGroupBox.Controls.Add(this.label8);
            this.StudentGroupBox.Controls.Add(this.NameModify);
            this.StudentGroupBox.Controls.Add(this.label7);
            this.StudentGroupBox.Location = new System.Drawing.Point(10, 68);
            this.StudentGroupBox.Name = "StudentGroupBox";
            this.StudentGroupBox.Size = new System.Drawing.Size(255, 321);
            this.StudentGroupBox.TabIndex = 3;
            this.StudentGroupBox.TabStop = false;
            this.StudentGroupBox.Text = "Student Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name:";
            // 
            // NameModify
            // 
            this.NameModify.Location = new System.Drawing.Point(13, 43);
            this.NameModify.Name = "NameModify";
            this.NameModify.Size = new System.Drawing.Size(151, 20);
            this.NameModify.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number:";
            // 
            // PhNoModify
            // 
            this.PhNoModify.Location = new System.Drawing.Point(13, 111);
            this.PhNoModify.MaxLength = 10;
            this.PhNoModify.Name = "PhNoModify";
            this.PhNoModify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhNoModify.Size = new System.Drawing.Size(151, 20);
            this.PhNoModify.TabIndex = 13;
            this.PhNoModify.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhNoModify_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Branch:";
            // 
            // BranchComboBoxModify
            // 
            this.BranchComboBoxModify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchComboBoxModify.FormattingEnabled = true;
            this.BranchComboBoxModify.Location = new System.Drawing.Point(13, 172);
            this.BranchComboBoxModify.Name = "BranchComboBoxModify";
            this.BranchComboBoxModify.Size = new System.Drawing.Size(151, 21);
            this.BranchComboBoxModify.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Date of Birth (DD/MM/YYYY):";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DOBModify
            // 
            this.DOBModify.Location = new System.Drawing.Point(13, 231);
            this.DOBModify.MaxLength = 10;
            this.DOBModify.Name = "DOBModify";
            this.DOBModify.Size = new System.Drawing.Size(151, 20);
            this.DOBModify.TabIndex = 13;
            this.DOBModify.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DOBModify_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(191, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateStudent
            // 
            this.UpdateStudent.BackColor = System.Drawing.Color.White;
            this.UpdateStudent.Image = ((System.Drawing.Image)(resources.GetObject("UpdateStudent.Image")));
            this.UpdateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateStudent.Location = new System.Drawing.Point(6, 277);
            this.UpdateStudent.Name = "UpdateStudent";
            this.UpdateStudent.Size = new System.Drawing.Size(116, 38);
            this.UpdateStudent.TabIndex = 15;
            this.UpdateStudent.Text = "Update Details";
            this.UpdateStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateStudent.UseVisualStyleBackColor = false;
            this.UpdateStudent.Click += new System.EventHandler(this.UpdateStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.White;
            this.DeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("DeleteStudent.Image")));
            this.DeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteStudent.Location = new System.Drawing.Point(133, 277);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(116, 38);
            this.DeleteStudent.TabIndex = 16;
            this.DeleteStudent.Text = "Delete Student";
            this.DeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(677, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 403);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Student Details";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.DOBView);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.BranchView);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.PhNoView);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.NameView);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.RegNoView);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 155);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Parameters";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridStudent);
            this.groupBox5.Location = new System.Drawing.Point(9, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 204);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Table View";
            // 
            // DataGridStudent
            // 
            this.DataGridStudent.AllowUserToAddRows = false;
            this.DataGridStudent.AllowUserToDeleteRows = false;
            this.DataGridStudent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStudent.GridColor = System.Drawing.Color.White;
            this.DataGridStudent.Location = new System.Drawing.Point(6, 19);
            this.DataGridStudent.Name = "DataGridStudent";
            this.DataGridStudent.Size = new System.Drawing.Size(314, 179);
            this.DataGridStudent.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Registration Number:";
            // 
            // RegNoView
            // 
            this.RegNoView.Location = new System.Drawing.Point(6, 34);
            this.RegNoView.Name = "RegNoView";
            this.RegNoView.Size = new System.Drawing.Size(136, 20);
            this.RegNoView.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Name:";
            // 
            // NameView
            // 
            this.NameView.Location = new System.Drawing.Point(6, 74);
            this.NameView.Name = "NameView";
            this.NameView.Size = new System.Drawing.Size(136, 20);
            this.NameView.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Phone Number:";
            // 
            // PhNoView
            // 
            this.PhNoView.Location = new System.Drawing.Point(6, 118);
            this.PhNoView.MaxLength = 10;
            this.PhNoView.Name = "PhNoView";
            this.PhNoView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhNoView.Size = new System.Drawing.Size(136, 20);
            this.PhNoView.TabIndex = 9;
            this.PhNoView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhNoView_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(162, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Branch:";
            // 
            // BranchView
            // 
            this.BranchView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BranchView.FormattingEnabled = true;
            this.BranchView.Location = new System.Drawing.Point(165, 34);
            this.BranchView.Name = "BranchView";
            this.BranchView.Size = new System.Drawing.Size(155, 21);
            this.BranchView.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Date of Birth (DD/MM/YYYY):";
            // 
            // DOBView
            // 
            this.DOBView.Location = new System.Drawing.Point(165, 74);
            this.DOBView.MaxLength = 10;
            this.DOBView.Name = "DOBView";
            this.DOBView.Size = new System.Drawing.Size(155, 20);
            this.DOBView.TabIndex = 15;
            this.DOBView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DOBView_KeyPress);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(165, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(37, 0, 37, 0);
            this.SearchButton.Size = new System.Drawing.Size(155, 49);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 424);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageStudentForm";
            this.Text = "Manage Students";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.StudentGroupBox.ResumeLayout(false);
            this.StudentGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar AddDOBCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddPhNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox AddBranchComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox StudentGroupBox;
        private System.Windows.Forms.TextBox PhNoModify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameModify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RegNoModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DOBModify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BranchComboBoxModify;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button UpdateStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataGridStudent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox DOBView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox BranchView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PhNoView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NameView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RegNoView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SearchButton;
    }
}