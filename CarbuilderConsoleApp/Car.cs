using System.Collections.Generic;
using System.Linq;

namespace CarbuilderConsoleApp
{
    internal class Car
    {
        private string Name;

        public Car(string name)
        {
            this.Name = name;
        }

        public List<Part> Parts { get; internal set; } = new List<Part>();
        public decimal Cost {
            get
            {
                return this.Parts.Sum(x => x.Cost) * 1.3M;

                 }
        }
         
        public override string ToString()
        {
            return this.Name;
        }
    }
}