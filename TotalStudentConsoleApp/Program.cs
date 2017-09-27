using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalStudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var theStudents = Student.GetInformation();
            Console.WriteLine($"The total student is { theStudents.Count}");

            Console.WriteLine(new string('*',30));

            Console.WriteLine(theStudents.Count(x => x.Value.Name.Contains("A")));
            Console.WriteLine("-------------------------------------------------------");
            foreach (var item in theStudents.Values)
            {
                Console.WriteLine(item.StudentId + " " + item.StudentId + " " + item.Grade);
            }
            Console.WriteLine(new string('*', 30));
            foreach (var item in theStudents)
            {
                Console.WriteLine(item.Key + " " + item.Value.StudentId + " " + item.Value.Name + " " + item.Value.Email + " " + item.Value.Grade);
            }
            Console.WriteLine(new string('*', 30));

       
           var students = theStudents["Class1"];
           Console.WriteLine($"Student ID  for class1 is {students.StudentId} Student Name is {students.Name} Student Email is {students.Email} Student ID is {students.Grade}");
            Console.ReadKey();
        }
    }
}
