using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTotal_StudentConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aschool = new School("Ec Utbuilding");
            var aclass= new Class("C#", 17);
            var bclass = new Class("Math", 27);
            var cclass = new Class("MVC", 37);
            var dclass = new Class("SQL", 38);

            aschool.NumberofStudent.Add(aclass);
            aschool.NumberofStudent.Add(bclass);
            aschool.NumberofStudent.Add(cclass);
            aschool.NumberofStudent.Add(dclass);
         int totalstudent = aschool.Total;
            Console.WriteLine($"the school name is {aschool}  and The total student is {totalstudent}");

          

           
            Console.ReadKey();
        }
    }
}
