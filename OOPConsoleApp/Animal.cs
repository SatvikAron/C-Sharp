using System;

namespace OOPConsoleApp
{
    internal class Animal
    {
        public Animal()
        {
        }

        internal virtual void Eat()
        {
            Console.WriteLine("Grumph.");
        }
    }
}