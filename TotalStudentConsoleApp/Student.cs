using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalStudentConsoleApp
{
   public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Grade { get; set; }
        public Student(int studId, string nam, string email, string grade)
        {
            StudentId = studId;
            Name = nam;
            Email = email;
            Grade = grade;

        }
        public static Dictionary<string, Student> GetInformation()
        {
            var studentdictinary = new Dictionary<string, Student>();
            var sut = new Student(1001, "Aron", "Aron@gmail.com", "VG");
            studentdictinary.Add("Class1", sut);
            sut = new Student(1002, "AAron", "Bron@gmail.com", "G");
            studentdictinary.Add("Class2", sut);
            sut = new Student(1003, "Cron", "Bron@gmail.com", "IG");
            studentdictinary.Add("Class3", sut);
            return studentdictinary;
        }

    }
}

