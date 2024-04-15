using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesNotes
{

    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<Grade> grades = new List<Grade>();
        public TextBox txtStudentID;
        public TextBox txtFirstName;
        public TextBox txtLastName;
        public TextBox txtCourseID;
        public TextBox txtCourseCode;
        public TextBox txtCourseTitle;
        public TextBox txtGradeStudentID;
        public TextBox txtGradeCourseID;
        public TextBox txtGradeScore;
        public TextBox txtTranscriptStudentID;

        public MainForm()
        {
            InitializeComponent();
            InitializeTextBoxes();
        }

        private void InitializeTextBoxes()
        {
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCourseID = new TextBox();
            txtCourseCode = new TextBox();
            txtCourseTitle = new TextBox();
            txtGradeStudentID = new TextBox();
            txtGradeCourseID = new TextBox();
            txtGradeScore = new TextBox();
            txtTranscriptStudentID = new TextBox();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtGradeStudentID = new System.Windows.Forms.TextBox();
            this.txtGradeCourseID = new System.Windows.Forms.TextBox();
            this.txtGradeScore = new System.Windows.Forms.TextBox();
            this.txtTranscriptStudentID = new System.Windows.Forms.TextBox();
        }

        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStudentID.Text) &&
                !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                !string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                if (int.TryParse(txtStudentID.Text, out int studentID))
                {
                    Student student = new Student(studentID, txtFirstName.Text, txtLastName.Text);
                    students.Add(student);
                    MessageBox.Show("Étudiant ajouté avec succès !");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un ID d'étudiant valide.", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }

        private void BtnAddCourse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCourseID.Text) &&
                !string.IsNullOrWhiteSpace(txtCourseCode.Text) &&
                !string.IsNullOrWhiteSpace(txtCourseTitle.Text))
            {
                if (int.TryParse(txtCourseID.Text, out int courseID))
                {
                    Course course = new Course(courseID, txtCourseCode.Text, txtCourseTitle.Text);
                    courses.Add(course);
                    MessageBox.Show("Cours ajouté avec succès !");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un ID de cours valide.", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtGradeStudentID.Text) &&
                !string.IsNullOrWhiteSpace(txtGradeCourseID.Text) &&
                !string.IsNullOrWhiteSpace(txtGradeScore.Text))
            {
                if (int.TryParse(txtGradeStudentID.Text, out int studentID) &&
                    int.TryParse(txtGradeCourseID.Text, out int courseID) &&
                    double.TryParse(txtGradeScore.Text, out double score))
                {
                    Grade grade = new Grade(studentID, courseID, score);
                    grades.Add(grade);
                    MessageBox.Show("Note ajoutée avec succès !");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer des valeurs valides pour l'ID d'étudiant, l'ID de cours et la note.", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }

        private void BtnDisplayTranscript_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTranscriptStudentID.Text))
            {
                if (int.TryParse(txtTranscriptStudentID.Text, out int studentID))
                {
                    string transcript = "Relevé de notes pour l'étudiant avec l'ID " + studentID + " :\n\n";

                    foreach (Grade grade in grades)
                    {
                        if (grade.StudentID == studentID)
                        {
                            Student student = students.Find(s => s.StudentID == studentID);
                            Course course = courses.Find(c => c.CourseID == grade.CourseID);
                            transcript += "Cours: " + course.Title + "\t Note: " + grade.Score + "\n";
                        }
                    }

                    MessageBox.Show(transcript, "Relevé de notes");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un ID d'étudiant valide.", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur");
            }
        }
    }
}

