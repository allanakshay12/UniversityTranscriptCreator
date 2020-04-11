namespace UniversityTranscriptCreator
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.SubjectNameModify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CodeModify = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridSubject = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SubjectNameView = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CodeView = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteSubject = new System.Windows.Forms.Button();
            this.UpdateSubject = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.AddSubjectName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Subject";
            // 
            // AddSubjectName
            // 
            this.AddSubjectName.Location = new System.Drawing.Point(10, 98);
            this.AddSubjectName.Name = "AddSubjectName";
            this.AddSubjectName.Size = new System.Drawing.Size(204, 20);
            this.AddSubjectName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Name:";
            // 
            // AddCode
            // 
            this.AddCode.Location = new System.Drawing.Point(10, 42);
            this.AddCode.Name = "AddCode";
            this.AddCode.Size = new System.Drawing.Size(204, 20);
            this.AddCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.SubjectGroupBox);
            this.groupBox2.Controls.Add(this.CodeModify);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(243, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify / Delete Subject";
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
            this.SubjectGroupBox.Controls.Add(this.DeleteSubject);
            this.SubjectGroupBox.Controls.Add(this.UpdateSubject);
            this.SubjectGroupBox.Controls.Add(this.SubjectNameModify);
            this.SubjectGroupBox.Controls.Add(this.label7);
            this.SubjectGroupBox.Location = new System.Drawing.Point(10, 68);
            this.SubjectGroupBox.Name = "SubjectGroupBox";
            this.SubjectGroupBox.Size = new System.Drawing.Size(255, 130);
            this.SubjectGroupBox.TabIndex = 3;
            this.SubjectGroupBox.TabStop = false;
            this.SubjectGroupBox.Text = "Subject Details";
            // 
            // SubjectNameModify
            // 
            this.SubjectNameModify.Location = new System.Drawing.Point(6, 43);
            this.SubjectNameModify.Name = "SubjectNameModify";
            this.SubjectNameModify.Size = new System.Drawing.Size(243, 20);
            this.SubjectNameModify.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Subject Name:";
            // 
            // CodeModify
            // 
            this.CodeModify.Location = new System.Drawing.Point(10, 42);
            this.CodeModify.Name = "CodeModify";
            this.CodeModify.Size = new System.Drawing.Size(175, 20);
            this.CodeModify.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subject Code:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(506, 186);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View Subject Details";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridSubject);
            this.groupBox5.Location = new System.Drawing.Point(182, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 155);
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
            this.DataGridSubject.Size = new System.Drawing.Size(302, 130);
            this.DataGridSubject.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.SubjectNameView);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.CodeView);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(9, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 155);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query Parameters";
            // 
            // SubjectNameView
            // 
            this.SubjectNameView.Location = new System.Drawing.Point(6, 74);
            this.SubjectNameView.Name = "SubjectNameView";
            this.SubjectNameView.Size = new System.Drawing.Size(155, 20);
            this.SubjectNameView.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Subject Name:";
            // 
            // CodeView
            // 
            this.CodeView.Location = new System.Drawing.Point(6, 34);
            this.CodeView.Name = "CodeView";
            this.CodeView.Size = new System.Drawing.Size(155, 20);
            this.CodeView.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Subject Code:";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.White;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(6, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Padding = new System.Windows.Forms.Padding(37, 0, 37, 0);
            this.SearchButton.Size = new System.Drawing.Size(155, 49);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Search";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DeleteSubject
            // 
            this.DeleteSubject.BackColor = System.Drawing.Color.White;
            this.DeleteSubject.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSubject.Image")));
            this.DeleteSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSubject.Location = new System.Drawing.Point(133, 80);
            this.DeleteSubject.Name = "DeleteSubject";
            this.DeleteSubject.Size = new System.Drawing.Size(116, 38);
            this.DeleteSubject.TabIndex = 16;
            this.DeleteSubject.Text = "Delete Subject";
            this.DeleteSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSubject.UseVisualStyleBackColor = false;
            this.DeleteSubject.Click += new System.EventHandler(this.DeleteSubject_Click);
            // 
            // UpdateSubject
            // 
            this.UpdateSubject.BackColor = System.Drawing.Color.White;
            this.UpdateSubject.Image = ((System.Drawing.Image)(resources.GetObject("UpdateSubject.Image")));
            this.UpdateSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateSubject.Location = new System.Drawing.Point(6, 80);
            this.UpdateSubject.Name = "UpdateSubject";
            this.UpdateSubject.Size = new System.Drawing.Size(116, 38);
            this.UpdateSubject.TabIndex = 15;
            this.UpdateSubject.Text = "Update Details";
            this.UpdateSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateSubject.UseVisualStyleBackColor = false;
            this.UpdateSubject.Click += new System.EventHandler(this.UpdateSubject_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(10, 139);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(43, 0, 43, 0);
            this.AddButton.Size = new System.Drawing.Size(204, 53);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add Subject";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SubjectForm";
            this.Text = "Manage Subects";
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
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox SubjectGroupBox;
        private System.Windows.Forms.Button DeleteSubject;
        private System.Windows.Forms.Button UpdateSubject;
        private System.Windows.Forms.TextBox SubjectNameModify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CodeModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DataGridSubject;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SubjectNameView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CodeView;
        private System.Windows.Forms.Label label11;
    }
}