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
            var aclass= new Class("Spo", 17);
            aschool.NumberofStudent.Add(aclass);
            //Console.WriteLine($"{aschool}");
            Console.ReadKey();
        }
    }
}
