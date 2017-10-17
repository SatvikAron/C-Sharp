using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class> classes = new List<Class>();
            classes.Add(new Class { Count = 21, name = "Aron" });
            classes.Add(new Class { Count = 31, name = "Bron" });
            Console.WriteLine(classes.Count);
            Console.ReadLine();
        }
    }

    internal class Class
    {
        public int Count { get; set; }

        public string name { get; set; }

       
    }
}
