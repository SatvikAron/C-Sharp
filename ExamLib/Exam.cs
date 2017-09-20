using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
       public string CourseName;
        private Dictionary<Student, string> Studentdictionary = new Dictionary<Student, string>();
        List<Student> StudentsList = new List<Student>();

        public Exam(string coursename)
        {
            this.CourseName = coursename;
        }

        public void Assign(Student student)
        {
            StudentsList.Add(student);
            Studentdictionary.Add(student,"IG");


        }
      

        public void Grade(Student student, string betyg)
        {
            Studentdictionary[student] = betyg;
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            Dictionary<string, int> Statistik = new Dictionary<string, int>();
            Statistik.Add("IG", 0);
            Statistik.Add("G", 0);
            Statistik.Add("VG", 0);
            foreach (var item in Studentdictionary)
            {
                Statistik[item.Value]++;
            }
            return Statistik;
        }
    }
}
