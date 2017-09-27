using System.Collections.Generic;

namespace GrandTotal_StudentConsoleApp
{
    internal class School
    {
        private string Name;

        public School(string name)
        {
            this.Name = name;
        }

        public List<NumberofStudent> numberofstudents  { get; internal set; }  = new List<NumberofStudent>();

        public override string ToString()
        {
            return this.Name;
        }
    }
}