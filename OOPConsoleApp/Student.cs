using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    class Student
    {
        public string Name;
        public string Email;
        private int StudyharderCounter = 0;
        public event EventHandler TooTired;
        public override string ToString()
        {
            return $"{this. Name} \n {this.Email}";


        }

        internal void StudyHarder()
        {
            StudyharderCounter++;
            if (StudyharderCounter > 2)

                TooTired?.Invoke(this, null);
            
           
            Name = "Super " + Name;
        }
    }
}
