using System.Collections.Generic;
using System.Linq;

namespace GrandTotal_StudentConsoleApp
{
    internal class School
    {
        private string Name;

        public School(string name)
        {
            this.Name = name;
        }

        public List<NumberofStudents> NumberofStudent { get; internal set; } = new List<NumberofStudents>();
        public int Total
        {
            get
            {
                return this.NumberofStudent.Sum(x => x.Total);
            }
                }

        public override string ToString()
        {
            return this.Name;
        }
    }
}