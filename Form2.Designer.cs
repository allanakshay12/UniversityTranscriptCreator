namespace UniversityTranscriptCreator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UsersButton = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.BranchButton = new System.Windows.Forms.Button();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.MarksButton = new System.Windows.Forms.Button();
            this.SubjectButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.RegNoTranscript = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UsersButton);
            this.groupBox1.Controls.Add(this.StudentButton);
            this.groupBox1.Controls.Add(this.BranchButton);
            this.groupBox1.Controls.Add(this.EnrollButton);
            this.groupBox1.Controls.Add(this.MarksButton);
            this.groupBox1.Controls.Add(this.SubjectButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Databases";
            // 
            // UsersButton
            // 
            this.UsersButton.BackColor = System.Drawing.Color.White;
            this.UsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsersButton.Image = ((System.Drawing.Image)(resources.GetObject("UsersButton.Image")));
            this.UsersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersButton.Location = new System.Drawing.Point(38, 361);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Padding = new System.Windows.Forms.Padding(16, 0, 10, 0);
            this.UsersButton.Size = new System.Drawing.Size(185, 59);
            this.UsersButton.TabIndex = 5;
            this.UsersButton.Text = "Manage Users";
            this.UsersButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.BackColor = System.Drawing.Color.White;
            this.StudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentButton.Image")));
            this.StudentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentButton.Location = new System.Drawing.Point(38, 36);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StudentButton.Size = new System.Drawing.Size(185, 59);
            this.StudentButton.TabIndex = 0;
            this.StudentButton.Text = "Manage Students";
            this.StudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentButton.UseVisualStyleBackColor = false;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // BranchButton
            // 
            this.BranchButton.BackColor = System.Drawing.Color.White;
            this.BranchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BranchButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BranchButton.Image = ((System.Drawing.Image)(resources.GetObject("BranchButton.Image")));
            this.BranchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BranchButton.Location = new System.Drawing.Point(38, 296);
            this.BranchButton.Name = "BranchButton";
            this.BranchButton.Padding = new System.Windows.Forms.Padding(12, 0, 10, 0);
            this.BranchButton.Size = new System.Drawing.Size(185, 59);
            this.BranchButton.TabIndex = 4;
            this.BranchButton.Text = "Manage Branches";
            this.BranchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BranchButton.UseVisualStyleBackColor = false;
            this.BranchButton.Click += new System.EventHandler(this.BranchButton_Click);
            // 
            // EnrollButton
            // 
            this.EnrollButton.BackColor = System.Drawing.Color.White;
            this.EnrollButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnrollButton.Image = ((System.Drawing.Image)(resources.GetObject("EnrollButton.Image")));
            this.EnrollButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnrollButton.Location = new System.Drawing.Point(38, 231);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Padding = new System.Windows.Forms.Padding(13, 0, 10, 0);
            this.EnrollButton.Size = new System.Drawing.Size(185, 59);
            this.EnrollButton.TabIndex = 3;
            this.EnrollButton.Text = "Manage Enrollment";
            this.EnrollButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnrollButton.UseVisualStyleBackColor = false;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // MarksButton
            // 
            this.MarksButton.BackColor = System.Drawing.Color.White;
            this.MarksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MarksButton.Image = ((System.Drawing.Image)(resources.GetObject("MarksButton.Image")));
            this.MarksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarksButton.Location = new System.Drawing.Point(38, 166);
            this.MarksButton.Name = "MarksButton";
            this.MarksButton.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.MarksButton.Size = new System.Drawing.Size(185, 59);
            this.MarksButton.TabIndex = 2;
            this.MarksButton.Text = "Manage Marks";
            this.MarksButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MarksButton.UseVisualStyleBackColor = false;
            this.MarksButton.Click += new System.EventHandler(this.MarksButton_Click);
            // 
            // SubjectButton
            // 
            this.SubjectButton.BackColor = System.Drawing.Color.White;
            this.SubjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SubjectButton.Image = ((System.Drawing.Image)(resources.GetObject("SubjectButton.Image")));
            this.SubjectButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectButton.Location = new System.Drawing.Point(38, 101);
            this.SubjectButton.Name = "SubjectButton";
            this.SubjectButton.Padding = new System.Windows.Forms.Padding(13, 0, 10, 0);
            this.SubjectButton.Size = new System.Drawing.Size(185, 59);
            this.SubjectButton.TabIndex = 1;
            this.SubjectButton.Text = "Manage Subjects";
            this.SubjectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubjectButton.UseVisualStyleBackColor = false;
            this.SubjectButton.Click += new System.EventHandler(this.SubjectButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.RegNoTranscript);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(283, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Transcripts";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.White;
            this.GenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenerateButton.Image = ((System.Drawing.Image)(resources.GetObject("GenerateButton.Image")));
            this.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateButton.Location = new System.Drawing.Point(237, 41);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GenerateButton.Size = new System.Drawing.Size(162, 54);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate Transcript";
            this.GenerateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // RegNoTranscript
            // 
            this.RegNoTranscript.Location = new System.Drawing.Point(19, 62);
            this.RegNoTranscript.Name = "RegNoTranscript";
            this.RegNoTranscript.Size = new System.Drawing.Size(186, 20);
            this.RegNoTranscript.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Transcript Creator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button SubjectButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button BranchButton;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.Button MarksButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox RegNoTranscript;
        private System.Windows.Forms.Label label1;
    }
}