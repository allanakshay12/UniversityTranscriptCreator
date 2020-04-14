namespace UniversityTranscriptCreator
{
    partial class MarksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddOutOf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.AddStudentRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddMarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModifyRegNoComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.ModifyOutOf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ModifyMarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ModifySubjectComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSubject = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridSubject = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ViewSubjectName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ViewOutOf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ViewMarks = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ViewSubject = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ViewRegistrationNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SubjectGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddOutOf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddSubjectComboBox);
            this.groupBox1.Controls.Add(this.AddStudentRegNoComboBox);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddMarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Marks";
            // 
            // AddOutOf
            // 
            this.AddOutOf.Location = new System.Drawing.Point(116, 154);
            this.AddOutOf.MaxLength = 3;
            this.AddOutOf.Name = "AddOutOf";
            this.AddOutOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddOutOf.Size = new System.Drawing.Size(82, 20);
            this.AddOutOf.TabIndex = 16;
            this.AddOutOf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddOutOf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "/";
            // 
            // AddSubjectComboBox
            // 
            this.AddSubjectComboBox.FormattingEnabled = true;
            this.AddSubjectComboBox.Location = new System.Drawing.Point(10, 99);
            this.AddSubjectComboBox.Name = "AddSubjectComboBox";
            this.AddSubjectComboBox.Size = new System.Drawing.Size(268, 21);
            this.AddSubjectComboBox.TabIndex = 14;
            this.AddSubjectComboBox.SelectedIndexChanged += new System.EventHandler(this.AddSubjectComboBox_SelectedIndexChanged);
            // 
            // AddStudentRegNoComboBox
            // 
            this.AddStudentRegNoComboBox.FormattingEnabled = true;
            this.AddStudentRegNoComboBox.Location = new System.Drawing.Point(10, 42);
            this.AddStudentRegNoComboBox.Name = "AddStudentRegNoComboBox";
            this.AddStudentRegNoComboBox.Size = new System.Drawing.Size(268, 21);
            this.AddStudentRegNoComboBox.TabIndex = 13;
            this.AddStudentRegNoComboBox.SelectedIndexChanged += new System.EventHandler(this.AddStudentRegNoComboBox_SelectedIndexChanged);
            this.AddStudentRegNoComboBox.TextUpdate += new System.EventHandler(this.AddStudentRegNoComboBox_TextUpdate);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(10, 199);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(78, 0, 78, 0);
            this.AddButton.Size = new System.Drawing.Size(268, 53);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Marks";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddMarks
            // 
            this.AddMarks.Location = new System.Drawing.Point(10, 154);
            this.AddMarks.MaxLength = 3;
            this.AddMarks.Name = "AddMarks";
            this.AddMarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddMarks.Size = new System.Drawing.Size(82, 20);
            this.AddMarks.TabIndex = 8;
            this.AddMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddMarks_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marks Assigned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModifyRegNoComboBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.SubjectGroupBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 204);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify / Delete Marks";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ModifyRegNoComboBox
            // 
            this.ModifyRegNoComboBox.FormattingEnabled = true;
            this.ModifyRegNoComboBox.Location = new System.Drawing.Point(10, 42);
            this.ModifyRegNoComboBox.Name = "ModifyRegNoComboBox";
            this.ModifyRegNoComboBox.Size = new System.Drawing.Size(187, 21);
            this.ModifyRegNoComboBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(203, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubjectGroupBox
            // 
            this.SubjectGroupBox.Controls.Add(this.ModifyOutOf);
            this.SubjectGroupBox.Controls.Add(this.label5);
            this.SubjectGroupBox.Controls.Add(this.ModifyMarks);
            this.SubjectGroupBox.Controls.Add(this.label8);
            this.SubjectGroupBox.Controls.Add(this.ModifySubjectComboBox);
            this.SubjectGroupBox.Controls.Add(this.DeleteSubject);
            this.SubjectGroupBox.Controls.Add(this.CancelButton);
            this.SubjectGroupBox.Controls.Add(this.label7);
            this.SubjectGroupBox.Location = new System.Drawing.Point(10, 68);
            this.SubjectGroupBox.Name = "SubjectGroupBox";
            this.SubjectGroupBox.Size = new System.Drawing.Size(268, 127);
            this.SubjectGroupBox.TabIndex = 3;
            this.SubjectGroupBox.TabStop = false;
            this.SubjectGroupBox.Text = "Subject Marks";
            // 
            // ModifyOutOf
            // 
            this.ModifyOutOf.Location = new System.Drawing.Point(212, 43);
            this.ModifyOutOf.MaxLength = 3;
            this.ModifyOutOf.Name = "ModifyOutOf";
            this.ModifyOutOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModifyOutOf.Size = new System.Drawing.Size(50, 20);
            this.ModifyOutOf.TabIndex = 20;
            this.ModifyOutOf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "/";
            // 
            // ModifyMarks
            // 
            this.ModifyMarks.Location = new System.Drawing.Point(138, 43);
            this.ModifyMarks.MaxLength = 3;
            this.ModifyMarks.Name = "ModifyMarks";
            this.ModifyMarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModifyMarks.Size = new System.Drawing.Size(50, 20);
            this.ModifyMarks.TabIndex = 15;
            this.ModifyMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemesterModify_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Marks Assigned:";
            // 
            // ModifySubjectComboBox
            // 
            this.ModifySubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModifySubjectComboBox.FormattingEnabled = true;
            this.ModifySubjectComboBox.Location = new System.Drawing.Point(6, 43);
            this.ModifySubjectComboBox.Name = "ModifySubjectComboBox";
            this.ModifySubjectComboBox.Size = new System.Drawing.Size(117, 21);
            this.ModifySubjectComboBox.TabIndex = 17;
            this.ModifySubjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ModifySubjectComboBox_SelectedIndexChanged);
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.BackColor = System.Drawing.Color.White;
            this.DeleteSubject.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSubject.Image")));
            this.DeleteSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSubject.Location = new System.Drawing.Point(138, 80);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DeleteSubject.Size = new System.Drawing.Size(124, 38);
            this.DeleteSubject.TabIndex = 16;
            this.DeleteSubject.Text = "Delete Marks";
            this.DeleteSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSubject.UseVisualStyleBackColor = false;
            this.DeleteSubject.Click += new System.EventHandler(this.DeleteSubject_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelButton.Image")));
            this.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelButton.Location = new System.Drawing.Point(6, 80);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CancelButton.Size = new System.Drawing.Size(124, 38);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Update Marks";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subject Code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student Registration Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(306, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 475);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Marks";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridSubject);
            this.groupBox5.Location = new System.Drawing.Point(9, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 274);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Table View";
            // 
            // DataGridSubject
            // 
            this.DataGridSubject.AllowUserToAddRows = false;
            this.DataGridSubject.AllowUserToDeleteRows = false;
            this.DataGridSubject.BackgroundColor = System.Drawing.Color.White;
            this.DataGridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSubject.GridColor = System.Drawing.Color.White;
            this.DataGridSubject.Location = new System.Drawing.Point(6, 19);
            this.DataGridSubject.Name = "DataGridSubject";
            this.DataGridSubject.Size = new System.Drawing.Size(339, 246);
            this.DataGridSubject.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ViewSubjectName);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.ViewOutOf);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.ViewMarks);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.ViewSubject);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ViewRegistrationNo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 162);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Parameters";
            // 
            // ViewSubjectName
            // 
            this.ViewSubjectName.Location = new System.Drawing.Point(189, 76);
            this.ViewSubjectName.Name = "ViewSubjectName";
            this.ViewSubjectName.Size = new System.Drawing.Size(156, 20);
            this.ViewSubjectName.TabIndex = 20;
            this.ViewSubjectName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Subject Name:";
            // 
            // ViewOutOf
            // 
            this.ViewOutOf.Location = new System.Drawing.Point(275, 34);
            this.ViewOutOf.MaxLength = 3;
            this.ViewOutOf.Name = "ViewOutOf";
            this.ViewOutOf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViewOutOf.Size = new System.Drawing.Size(62, 20);
            this.ViewOutOf.TabIndex = 18;
            this.ViewOutOf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "/";
            // 
            // ViewMarks
            // 
            this.ViewMarks.Location = new System.Drawing.Point(189, 34);
            this.ViewMarks.MaxLength = 3;
            this.ViewMarks.Name = "ViewMarks";
            this.ViewMarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViewMarks.Size = new System.Drawing.Size(62, 20);
            this.ViewMarks.TabIndex = 15;
            this.ViewMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemesterView_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Marks Assigned:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(6, 102);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(125, 0, 125, 0);
            this.SearchButton.Size = new System.Drawing.Size(339, 53);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewSubject
            // 
            this.ViewSubject.Location = new System.Drawing.Point(6, 76);
            this.ViewSubject.Name = "ViewSubject";
            this.ViewSubject.Size = new System.Drawing.Size(155, 20);
            this.ViewSubject.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Subject Code:";
            // 
            // ViewRegistrationNo
            // 
            this.ViewRegistrationNo.Location = new System.Drawing.Point(6, 34);
            this.ViewRegistrationNo.Name = "ViewRegistrationNo";
            this.ViewRegistrationNo.Size = new System.Drawing.Size(155, 20);
            this.ViewRegistrationNo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Student Registration Number:";
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MarksForm";
            this.Text = "Manage Marks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SubjectGroupBox.ResumeLayout(false);
            this.SubjectGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AddSubjectComboBox;
        private System.Windows.Forms.ComboBox AddStudentRegNoComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddMarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddOutOf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ModifyRegNoComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox SubjectGroupBox;
        private System.Windows.Forms.TextBox ModifyOutOf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ModifyMarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ModifySubjectComboBox;
        private System.Windows.Forms.Button DeleteSubject;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataGridSubject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ViewOutOf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ViewMarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ViewSubject;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ViewRegistrationNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ViewSubjectName;
        private System.Windows.Forms.Label label13;
    }
}