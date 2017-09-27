

using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentDemo();
            InheritanceDemo();
            Console.ReadLine();
        }

        private static void InheritanceDemo()
        {
            var anAnimal = new Animal();
            anAnimal.Eat();
            Lion alion = new Lion();
            alion.Eat();
            //TellAnimalToEatRwice(alion);
        }

        //private static void TellAnimalToEatRwice(Animal animal)
        //{
        //    anAnimal.Eat();
        //    anAnimal.Eat();
        //}

        private static void StudentDemo()
        {
            var aron = new Student();
            aron.Name = "Satvik Aron";
            aron.Email = "Satvik_Aron@gmail.com";
            aron.TooTired += Aron_TooTired;
            aron.StudyHarder();
            aron.StudyHarder();
            aron.StudyHarder();

            //Console.WriteLine(aron.Name+aron.Email);
            Console.WriteLine($"Hello World to {aron}");
            Console.ReadLine();

        }

        private static void Aron_TooTired(object sender, EventArgs e)
        {
            Console.WriteLine("Student needs to rest");
        }
    }

  
}
