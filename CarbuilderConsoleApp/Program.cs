using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbuilderConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var acar = new Car("Aron Cybervan");
            var anEingine = new Engine(350,120000M);
            var door1 = new Door(2000);
            var door2 = new Door(1500);
            var chassi = new Chassi(50000M);
            acar.Parts.Add(anEingine);
            acar.Parts.Add(door1);
            acar.Parts.Add(anEingine);
            acar.Parts.Add(door2);
            decimal cost = acar.Cost;
            Console.WriteLine($"{acar} costs {cost}");

            Console.ReadLine();

        }
    }
}
