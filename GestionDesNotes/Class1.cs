using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// Classe représentant un étudiant
public class Student
{
    public int StudentID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(int studentID, string firstName, string lastName)
    {
        StudentID = studentID;
        FirstName = firstName;
        LastName = lastName;
    }

    // Méthode pour générer un fichier texte contenant les informations de l'étudiant
    public void GenerateStudentFile()
    {
        string fileName = $"{StudentID}_{LastName}_{FirstName}.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Student ID: {StudentID}");
            writer.WriteLine($"First Name: {FirstName}");
            writer.WriteLine($"Last Name: {LastName}");
        }
    }
}

// Classe représentant un cours
public class Course
{
    public int CourseID { get; set; }
    public string Code { get; set; }
    public string Title { get; set; }

    public Course(int courseID, string code, string title)
    {
        CourseID = courseID;
        Code = code;
        Title = title;
    }
}

// Classe représentant une note
public class Grade
{
    public int StudentID { get; set; }
    public int CourseID { get; set; }
    public double Score { get; set; }

    public Grade(int studentID, int courseID, double score)
    {
        StudentID = studentID;
        CourseID = courseID;
        Score = score;
    }
}



    


