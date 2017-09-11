using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalage = 0;
            for (int age = 0; age < 100; age++)
            {
                totalage += age;
                Console.WriteLine("we can see the upto 99 age is " +age);
                Console.WriteLine(new string('-',50));
            }
            Console.WriteLine("Sum for total age is " +totalage);
            Console.ReadKey();
        }
    }
}
