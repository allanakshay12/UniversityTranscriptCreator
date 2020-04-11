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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "ManageStudentForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                ManageStudentForm manageStudentForm = new ManageStudentForm();
                manageStudentForm.Show();
            }
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "SubjectForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                SubjectForm manageStudentForm = new SubjectForm();
                manageStudentForm.Show();
            }
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "EnrollmentForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                EnrollmentForm manageStudentForm = new EnrollmentForm();
                manageStudentForm.Show();
            }
        }

        private void BranchButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "BranchForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                BranchForm manageStudentForm = new BranchForm();
                manageStudentForm.Show();
            }
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "UserForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                UserForm manageStudentForm = new UserForm();
                manageStudentForm.Show();
            }
        }

        private void MarksButton_Click(object sender, EventArgs e)
        {
            Boolean bFormNameOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "MarksForm")
                {
                    bFormNameOpen = true;
                    frm.BringToFront();
                }
            }
            if (!bFormNameOpen)
            {
                MarksForm manageStudentForm = new MarksForm();
                manageStudentForm.Show();
            }
        }
    }
}
