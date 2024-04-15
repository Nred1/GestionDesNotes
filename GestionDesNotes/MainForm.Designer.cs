using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;

namespace GestionDesNotes
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.listBoxGrades = new System.Windows.Forms.ListBox();
            this.textBoxStudentNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(16, 15);
            this.listBoxStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(265, 116);
            this.listBoxStudents.TabIndex = 0;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 16;
            this.listBoxCourses.Location = new System.Drawing.Point(16, 153);
            this.listBoxCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(265, 116);
            this.listBoxCourses.TabIndex = 1;
            // 
            // listBoxGrades
            // 
            this.listBoxGrades.FormattingEnabled = true;
            this.listBoxGrades.ItemHeight = 16;
            this.listBoxGrades.Location = new System.Drawing.Point(16, 289);
            this.listBoxGrades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxGrades.Name = "listBoxGrades";
            this.listBoxGrades.Size = new System.Drawing.Size(265, 116);
            this.listBoxGrades.TabIndex = 2;
            // 
            // textBoxStudentNumber
            // 
            this.textBoxStudentNumber.Location = new System.Drawing.Point(16, 450);
            this.textBoxStudentNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxStudentNumber.Name = "textBoxStudentNumber";
            this.textBoxStudentNumber.Size = new System.Drawing.Size(132, 22);
            this.textBoxStudentNumber.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxStudentNumber);
            this.Controls.Add(this.listBoxGrades);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.listBoxStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Student Management App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.ListBox listBoxGrades;
        private System.Windows.Forms.TextBox textBoxStudentNumber;
    }
}

