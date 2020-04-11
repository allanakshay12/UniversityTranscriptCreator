namespace UniversityTranscriptCreator
{
    partial class BranchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SubjectComboBoxAdd = new System.Windows.Forms.ComboBox();
            this.BranchComboBoxAdd = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SemesterAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BranchModify = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.SemesterModify = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SubjectModify = new System.Windows.Forms.ComboBox();
            this.DeleteSubject = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridSubject = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SubjectNameView = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SemesterView = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SubjectCodeView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BranchView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BranchDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ActualBranchModifyComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ActualBranchAdd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SubjectGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchDataGrid)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SubjectComboBoxAdd);
            this.groupBox1.Controls.Add(this.BranchComboBoxAdd);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.SemesterAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Branch Subjects";
            // 
            // SubjectComboBoxAdd
            // 
            this.SubjectComboBoxAdd.FormattingEnabled = true;
            this.SubjectComboBoxAdd.Location = new System.Drawing.Point(10, 99);
            this.SubjectComboBoxAdd.Name = "SubjectComboBoxAdd";
            this.SubjectComboBoxAdd.Size = new System.Drawing.Size(255, 21);
            this.SubjectComboBoxAdd.TabIndex = 14;
            // 
            // BranchComboBoxAdd
            // 
            this.BranchComboBoxAdd.FormattingEnabled = true;
            this.BranchComboBoxAdd.Location = new System.Drawing.Point(10, 43);
            this.BranchComboBoxAdd.Name = "BranchComboBoxAdd";
            this.BranchComboBoxAdd.Size = new System.Drawing.Size(256, 21);
            this.BranchComboBoxAdd.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(10, 199);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(68, 0, 68, 0);
            this.AddButton.Size = new System.Drawing.Size(255, 53);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Subject";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SemesterAdd
            // 
            this.SemesterAdd.Location = new System.Drawing.Point(10, 154);
            this.SemesterAdd.MaxLength = 2;
            this.SemesterAdd.Name = "SemesterAdd";
            this.SemesterAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SemesterAdd.Size = new System.Drawing.Size(255, 20);
            this.SemesterAdd.TabIndex = 8;
            this.SemesterAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPhNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Semester Assigned:";
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
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BranchModify);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.SubjectGroupBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Branch Subjects";
            // 
            // BranchModify
            // 
            this.BranchModify.FormattingEnabled = true;
            this.BranchModify.Location = new System.Drawing.Point(10, 42);
            this.BranchModify.Name = "BranchModify";
            this.BranchModify.Size = new System.Drawing.Size(175, 21);
            this.BranchModify.TabIndex = 5;
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
            // SubjectGroupBox
            // 
            this.SubjectGroupBox.Controls.Add(this.SemesterModify);
            this.SubjectGroupBox.Controls.Add(this.label8);
            this.SubjectGroupBox.Controls.Add(this.SubjectModify);
            this.SubjectGroupBox.Controls.Add(this.DeleteSubject);
            this.SubjectGroupBox.Controls.Add(this.CancelButton);
            this.SubjectGroupBox.Controls.Add(this.label7);
            this.SubjectGroupBox.Location = new System.Drawing.Point(10, 68);
            this.SubjectGroupBox.Name = "SubjectGroupBox";
            this.SubjectGroupBox.Size = new System.Drawing.Size(255, 127);
            this.SubjectGroupBox.TabIndex = 3;
            this.SubjectGroupBox.TabStop = false;
            this.SubjectGroupBox.Text = "Subject Details";
            // 
            // SemesterModify
            // 
            this.SemesterModify.Location = new System.Drawing.Point(138, 43);
            this.SemesterModify.MaxLength = 2;
            this.SemesterModify.Name = "SemesterModify";
            this.SemesterModify.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SemesterModify.Size = new System.Drawing.Size(111, 20);
            this.SemesterModify.TabIndex = 15;
            this.SemesterModify.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SemesterModify_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Semester Assigned:";
            // 
            // SubjectModify
            // 
            this.SubjectModify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectModify.FormattingEnabled = true;
            this.SubjectModify.Location = new System.Drawing.Point(6, 44);
            this.SubjectModify.Name = "SubjectModify";
            this.SubjectModify.Size = new System.Drawing.Size(117, 21);
            this.SubjectModify.TabIndex = 17;
            this.SubjectModify.SelectedIndexChanged += new System.EventHandler(this.SubjectModify_SelectedIndexChanged);
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.BackColor = System.Drawing.Color.White;
            this.DeleteSubject.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSubject.Image")));
            this.DeleteSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSubject.Location = new System.Drawing.Point(129, 80);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Size = new System.Drawing.Size(120, 38);
            this.DeleteSubject.TabIndex = 16;
            this.DeleteSubject.Text = "Delete Subject";
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
            this.CancelButton.Size = new System.Drawing.Size(117, 38);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Update Details";
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
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
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branch:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(293, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 475);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Branch Subjects";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridSubject);
            this.groupBox5.Location = new System.Drawing.Point(9, 185);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 281);
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
            this.DataGridSubject.Location = new System.Drawing.Point(6, 18);
            this.DataGridSubject.Name = "DataGridSubject";
            this.DataGridSubject.Size = new System.Drawing.Size(332, 254);
            this.DataGridSubject.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SubjectNameView);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.SemesterView);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.SubjectCodeView);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.BranchView);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 155);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Parameters";
            // 
            // SubjectNameView
            // 
            this.SubjectNameView.Location = new System.Drawing.Point(189, 74);
            this.SubjectNameView.Name = "SubjectNameView";
            this.SubjectNameView.Size = new System.Drawing.Size(155, 20);
            this.SubjectNameView.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Subject Name:";
            // 
            // SemesterView
            // 
            this.SemesterView.Location = new System.Drawing.Point(189, 34);
            this.SemesterView.MaxLength = 2;
            this.SemesterView.Name = "SemesterView";
            this.SemesterView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SemesterView.Size = new System.Drawing.Size(155, 20);
            this.SemesterView.TabIndex = 15;
            this.SemesterView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Semester Assigned:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(6, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(120, 0, 120, 0);
            this.SearchButton.Size = new System.Drawing.Size(338, 49);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SubjectCodeView
            // 
            this.SubjectCodeView.Location = new System.Drawing.Point(6, 74);
            this.SubjectCodeView.Name = "SubjectCodeView";
            this.SubjectCodeView.Size = new System.Drawing.Size(155, 20);
            this.SubjectCodeView.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Subject Code:";
            // 
            // BranchView
            // 
            this.BranchView.Location = new System.Drawing.Point(6, 34);
            this.BranchView.Name = "BranchView";
            this.BranchView.Size = new System.Drawing.Size(155, 20);
            this.BranchView.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Branch:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(668, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(270, 475);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Branch List";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.BranchDataGrid);
            this.groupBox9.Location = new System.Drawing.Point(6, 258);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(258, 208);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Table View";
            // 
            // BranchDataGrid
            // 
            this.BranchDataGrid.AllowUserToAddRows = false;
            this.BranchDataGrid.AllowUserToDeleteRows = false;
            this.BranchDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.BranchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchDataGrid.GridColor = System.Drawing.Color.White;
            this.BranchDataGrid.Location = new System.Drawing.Point(6, 19);
            this.BranchDataGrid.Name = "BranchDataGrid";
            this.BranchDataGrid.Size = new System.Drawing.Size(246, 180);
            this.BranchDataGrid.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ActualBranchModifyComboBox);
            this.groupBox8.Controls.Add(this.button3);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(6, 139);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(258, 113);
            this.groupBox8.TabIndex = 22;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Delete Branch";
            // 
            // ActualBranchModifyComboBox
            // 
            this.ActualBranchModifyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActualBranchModifyComboBox.FormattingEnabled = true;
            this.ActualBranchModifyComboBox.Location = new System.Drawing.Point(6, 37);
            this.ActualBranchModifyComboBox.Name = "ActualBranchModifyComboBox";
            this.ActualBranchModifyComboBox.Size = new System.Drawing.Size(246, 21);
            this.ActualBranchModifyComboBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 64);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(65, 0, 65, 0);
            this.button3.Size = new System.Drawing.Size(246, 38);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete Branch";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Branch Name:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.ActualBranchAdd);
            this.groupBox7.Location = new System.Drawing.Point(6, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(258, 113);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Add Branch";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(6, 64);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(75, 0, 75, 0);
            this.button2.Size = new System.Drawing.Size(246, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add Branch";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Branch Name:";
            // 
            // ActualBranchAdd
            // 
            this.ActualBranchAdd.Location = new System.Drawing.Point(6, 38);
            this.ActualBranchAdd.Name = "ActualBranchAdd";
            this.ActualBranchAdd.Size = new System.Drawing.Size(246, 20);
            this.ActualBranchAdd.TabIndex = 20;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 499);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BranchForm";
            this.Text = "Manage Branches";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchDataGrid)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SubjectComboBoxAdd;
        private System.Windows.Forms.ComboBox BranchComboBoxAdd;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox SemesterAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox BranchModify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox SubjectGroupBox;
        private System.Windows.Forms.ComboBox SubjectModify;
        private System.Windows.Forms.Button DeleteSubject;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataGridSubject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox SubjectNameView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SemesterView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SubjectCodeView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BranchView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SemesterModify;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView BranchDataGrid;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox ActualBranchModifyComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ActualBranchAdd;
        private System.Windows.Forms.Button button3;
    }
}