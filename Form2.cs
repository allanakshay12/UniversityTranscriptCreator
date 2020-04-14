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
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace UniversityTranscriptCreator
{
    public partial class MainForm : Form
    {
        private SqlConnection cnn;
        private string connectionString;
        public MainForm()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jerry Allan Akshay\Documents\GitHub\University Transcript Creator\UniversityTranscriptCreator\Database2.mdf;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
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

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string reg_no = RegNoTranscript.Text.Trim();
            Boolean studentexists = false;
            cnn.Open();
            SqlCommand commandbr;
            SqlDataReader dataReaderbr;
            string sqlbr;

            sqlbr = "Select * from dbo.StudentDetails where RegNo=\'" + reg_no + "\';";

            commandbr = new SqlCommand(sqlbr, cnn);
            dataReaderbr = commandbr.ExecuteReader();

            //BranchView.Items.Add("All Branches");
            
            if (dataReaderbr.HasRows)
            {
                studentexists = true;
            }

            dataReaderbr.Close();


            cnn.Close();

            if(studentexists)
            {
                cnn.Open();
                sqlbr = "Select dbo.StudentDetails.Name, dbo.StudentDetails.RegNo, dbo.StudentDetails.Branch, dbo.BranchSubject.Semester, dbo.Subject.Code, dbo.Subject.Title, dbo.Marks.Marks, dbo.Marks.Out_Of from dbo.Marks, dbo.Subject, dbo.BranchSubject, dbo.StudentDetails where dbo.Marks.RegNo=\'" + reg_no + "\' and dbo.Marks.Code=dbo.Subject.Code and dbo.StudentDetails.RegNo=dbo.Marks.RegNo and dbo.StudentDetails.Branch=dbo.BranchSubject.Branch and dbo.BranchSubject.Code=dbo.Marks.Code order by dbo.BranchSubject.Semester ASC;";

                commandbr = new SqlCommand(sqlbr, cnn);
                dataReaderbr = commandbr.ExecuteReader();
                if (dataReaderbr.HasRows)
                {
                    try
                    {

                        string dest = "C:\\Users\\Jerry Allan Akshay\\Documents\\GitHub\\University Transcript Creator\\UniversityTranscriptCreator\\Transcripts\\" + reg_no + ".pdf";
                        PdfWriter transwriter = new PdfWriter(dest);
                        PdfDocument transpdf = new PdfDocument(transwriter);
                        Document document = new Document(transpdf, PageSize.A4);
                        PdfFont font = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.TIMES_ROMAN);
                        document.SetFont(font);
                        document.SetMargins(20, 20, 20, 20);
                        iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:\\Users\\Jerry Allan Akshay\\Documents\\GitHub\\University Transcript Creator\\UniversityTranscriptCreator\\Icon.jpg"));
                        logo.SetHeight(70);
                        logo.SetFixedPosition(510, 760);
                        string name = "", branch = "", regno = "", sub_code = "", sub_title = "", marks = "", outof = "";
                        int prev_semester = 0, cur_semester = 0;
                        float cur_sem_total = 0, cur_sem_max = 0;
                        float percentage = 0;
                        int count = 1;
                        float sub_avg_marks = 0;
                        float sub_avg_outof = 0, sub_avg_per = 0;
                        List<string> sem_text = new List<string>();
                        float[] pointColumnWidths = { 40F, 80F, 150F, 80F, 80F, 70F, 90F };
                        Table table = new Table(pointColumnWidths);
                        table.SetBorder(border:Border.NO_BORDER);
                        table.UseAllAvailableWidth();
                        while (dataReaderbr.Read())
                        {
                            name = dataReaderbr.GetString(0);
                            regno = dataReaderbr.GetString(1);
                            branch = dataReaderbr.GetString(2);
                            cur_semester = dataReaderbr.GetInt32(3);
                            sub_code = dataReaderbr.GetString(4);
                            sub_title = dataReaderbr.GetString(5);
                            marks = dataReaderbr.GetInt32(6).ToString();
                            outof = dataReaderbr.GetInt32(7).ToString();
                            
                            if (cur_semester != prev_semester)
                            {
                                if (cur_semester != 1)
                                {
                                    /*foreach (string s in sem_text) {
                                        document.Add(new Paragraph(s));
                                    }*/
                                    document.Add(new Paragraph("\n\n"));
                                    document.Add(table);
                                    table = new Table(pointColumnWidths);
                                    sem_text.Clear();
                                    percentage = (float)((float)(cur_sem_total / cur_sem_max) * 100);
                                    float[] lastwidth = { 300F};
                                    Table lasttable = new Table(lastwidth);
                                    lasttable.SetBorder(border: Border.NO_BORDER);
                                    lasttable.AddCell((new Cell().Add((new Paragraph("Total Marks: " + cur_sem_total)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    lasttable.AddCell((new Cell().Add((new Paragraph("Max. Marks: " + cur_sem_max)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    lasttable.AddCell((new Cell().Add((new Paragraph("Percentage Secured: " + String.Format("{0:0.00}", percentage))).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    document.Add(new Paragraph("\n\n"));
                                    document.Add(lasttable);
                                    //document.Add((new Paragraph("\n\nTotal Marks: " + cur_sem_total + "\t\tMax Marks: " + cur_sem_max + "\t\tPercentage Secured: " + String.Format("{0:0.00}", percentage))));
                                    cur_sem_total = 0;
                                    cur_sem_max = 0;
                                    count = 1;
                                    prev_semester = cur_semester;
                                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                                    document.Add(logo);
                                    //document.Add(new Paragraph("Hello World!"));

                                    float[] headerwidth = { 500F, 500F };
                                    Table headtable = new Table(headerwidth);
                                    headtable.SetBorder(border: Border.NO_BORDER);
                                    headtable.AddCell((new Cell().Add((new Paragraph("Institution Name: Bangalore University")).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Course: Bachelor of Engineering")).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Registration Number: " + regno)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Student Name: " + name)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Branch: " + branch)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Semester: " + cur_semester)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    document.Add(new Paragraph(""));
                                    document.Add(headtable);
                                    //document.Add((new Paragraph("Institution Name: Bangalore University\nStudent Name: " + name + "\t\tRegistration Number: " + regno + "\nBranch: " + branch + "\t\tSemester: " + cur_semester.ToString() + "\n\n\n")));
                                    //sem_text.Add("Sl.No." + "\t\tSubject Code" + "\t\tSubject Title" + "\t\tMarks Secured" + "\t\tMax Marks" + "\t\tSubject Average");
                                    table.AddCell((new Cell().Add((new Paragraph("Sl. No.")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Subject Code")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Subject Title")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Marks Secured")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Max. Marks")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Percentage")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Overall Subject Average")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                } else
                                {
                                    sem_text.Clear();
                                    cur_sem_total = 0;
                                    cur_sem_max = 0;
                                    count = 1;
                                    prev_semester = cur_semester;
                                    document.Add(logo);
                                    //document.Add(new Paragraph("Hello World!"));

                                    float[] headerwidth = { 500F, 500F };
                                    Table headtable = new Table(headerwidth);
                                    headtable.SetBorder(border: Border.NO_BORDER);
                                    headtable.AddCell((new Cell().Add((new Paragraph("Institution Name: Bangalore University")).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Course: Bachelor of Engineering")).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Registration Number: " + regno)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Student Name: " + name)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Branch: " + branch)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    headtable.AddCell((new Cell().Add((new Paragraph("Semester: " + cur_semester)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                                    document.Add(new Paragraph(""));
                                    document.Add(headtable);
                                    //document.Add((new Paragraph("Institution Name: Bangalore University\nStudent Name: " + name + "\t\tRegistration Number: " + regno + "\nBranch: " + branch + "\t\tSemester: " + cur_semester.ToString() + "\n\n\n")));
                                    //sem_text.Add("Sl.No." + "\t\tSubject Code" + "\t\tSubject Title" + "\t\tMarks Secured" + "\t\tMax Marks" + "\t\tSubject Average");
                                    table.AddCell((new Cell().Add((new Paragraph("Sl. No.")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border:Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Subject Code")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Subject Title")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Marks Secured")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Max. Marks")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Percentage")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                                    table.AddCell((new Cell().Add((new Paragraph("Overall Subject Average")).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));

                                }

                            }
                            cur_sem_total = cur_sem_total + float.Parse(marks);
                            cur_sem_max = cur_sem_max + float.Parse(outof);


                            SqlConnection ncnn = new SqlConnection(connectionString);
                            ncnn.Open();
                            SqlCommand ncommandbr;
                            SqlDataReader ndataReaderbr;
                            string nsqlbr;

                            nsqlbr = "Select CAST(AVG(ALL Marks) as decimal(10,2)), CAST(AVG(ALL Out_Of) as decimal(10,2)) from dbo.Marks where Code=\'" + sub_code + "\';";

                            ncommandbr = new SqlCommand(nsqlbr, ncnn);
                            ndataReaderbr = ncommandbr.ExecuteReader();
                            while(ndataReaderbr.Read())
                            {
                                sub_avg_marks = float.Parse(ndataReaderbr.GetValue(0).ToString());
                                sub_avg_outof = float.Parse(ndataReaderbr.GetValue(1).ToString());
                                sub_avg_per = (sub_avg_marks / sub_avg_outof) * 100;
                            }
                            ndataReaderbr.Close();
                            ncnn.Close();
                            //sem_text.Add(count.ToString() + "\t\t" + sub_code + "\t\t" + sub_title + "\t\t" + marks + "\t\t" + outof + "\t\t" + String.Format("{0:0.00}", sub_avg_per));
                            //table.AddCell(count.ToString()).SetBorder(border: Border.NO_BORDER);
                            //table.AddCell(sub_code).SetBorder(border: Border.NO_BORDER);
                            //table.AddCell(sub_title).SetBorder(border: Border.NO_BORDER);
                            //table.AddCell(marks).SetBorder(border: Border.NO_BORDER);
                            //table.AddCell(outof).SetBorder(border: Border.NO_BORDER);
                            //table.AddCell(String.Format("{0:0.00}", sub_avg_per)).SetBorder(border: Border.NO_BORDER);
                            table.AddCell((new Cell().Add((new Paragraph(count.ToString())).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(sub_code)).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(sub_title)).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(marks)).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(outof)).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(String.Format("{0:0.00}", (float.Parse(marks)/float.Parse(outof))*100))).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            table.AddCell((new Cell().Add((new Paragraph(String.Format("{0:0.00}", sub_avg_per))).SetTextAlignment(TextAlignment.CENTER))).SetVerticalAlignment(VerticalAlignment.MIDDLE));//.SetBorder(border: Border.NO_BORDER));
                            count = count + 1;
                        }
                        /*foreach (string s in sem_text)
                        {
                            document.Add(new Paragraph(s));
                        }*/
                        document.Add(new Paragraph("\n\n"));
                        document.Add(table);
                        percentage = (float)((cur_sem_total / cur_sem_max) * 100);
                        float[] actlastwidth = { 300F };
                        Table actlasttable = new Table(actlastwidth);
                        actlasttable.SetBorder(border: Border.NO_BORDER);
                        actlasttable.AddCell((new Cell().Add((new Paragraph("Total Marks: " + cur_sem_total)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                        actlasttable.AddCell((new Cell().Add((new Paragraph("Max. Marks: " + cur_sem_max)).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                        actlasttable.AddCell((new Cell().Add((new Paragraph("Percentage Secured: " + String.Format("{0:0.00}", percentage))).SetTextAlignment(TextAlignment.LEFT))).SetBorder(border: Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));
                        document.Add(new Paragraph("\n\n"));
                        document.Add(actlasttable);
                        //document.Add((new Paragraph("Total Marks: " + cur_sem_total + "\t\tMax Marks: " + cur_sem_max + "\t\tPercentage Secured: " + String.Format("{0:0.00}", percentage))));
                        document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));

                        SqlConnection newcnn = new SqlConnection(connectionString);
                        newcnn.Open();
                        SqlCommand subcommandbr;
                        SqlDataReader subdataReaderbr;
                        string subsqlbr;

                        subsqlbr = "Select DigitalSignature from dbo.Users where UserName=\'" + LoginForm.username_data + "\';";

                        subcommandbr = new SqlCommand(subsqlbr, newcnn);
                        subdataReaderbr = subcommandbr.ExecuteReader();
                        string dig = "";
                        while (subdataReaderbr.Read())
                        {
                            dig = subdataReaderbr.GetValue(0).ToString();
                        }
                        iText.Layout.Element.Image lastlogo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:\\Users\\Jerry Allan Akshay\\Documents\\GitHub\\University Transcript Creator\\UniversityTranscriptCreator\\Icon.jpg"));
                        lastlogo.SetHeight(200);
                        lastlogo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                        lastlogo.SetRelativePosition(0,275,0,0);
                        //lastlogo.SetFixedPosition(500, 750);
                        document.Add(lastlogo);
                        document.Add((new Paragraph("Digitally signed and verified by " + LoginForm.name_data +" (" + dig + ").")).SetTextAlignment(TextAlignment.CENTER).SetRelativePosition(0,300,0,0));
                        document.Close();
                        newcnn.Close();
                        MessageBox.Show("Transript generated and stored at:\n\n" + dest + ".");
                        System.Diagnostics.Process.Start(@dest);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The file is currently open. Please close the file and try again.");
                    }
                } else
                {
                    MessageBox.Show("The Student hasn't secured marks in any subject.");
                }
                dataReaderbr.Close();
                cnn.Close();
            } else
            {
                MessageBox.Show("The Student does not exist.");
            }
        }

       

    }

}
