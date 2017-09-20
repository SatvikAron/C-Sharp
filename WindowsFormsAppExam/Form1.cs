using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppExam
{
    public partial class Form1 : Form
    {
        Exam exam = new Exam("");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtStudent.Text);//h
            exam.Assign(student);
            exam.Grade(student, combograde.SelectedItem.ToString());
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            var gradeCountDictionary = exam.GenerateStatistics();
            var IGCounter = gradeCountDictionary["IG"];
            label1.Text = $"IG: {IGCounter}";

            var GCounter = gradeCountDictionary["G"];
            label2.Text = $"G: {GCounter}";

            var VGCounter = gradeCountDictionary["VG"];
            label3.Text = $"VG: {VGCounter}";
        }
    }
}
