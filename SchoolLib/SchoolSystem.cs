using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLib
{
    public class SchoolSystem
    {
        private List<Class> classes = new List<Class>();
        private string v;

        public SchoolSystem()
        {
        }

        public SchoolSystem(string v)
        {
            this.v = v;
        }

        public int ClassCount { get
            {
                return  classes.Count;
            }
        }
        public int StudentCount {
            get
            {
                return classes.Sum(x=>x.NumberofStudent);
            }
                
                }

        public string SchoolName { get {
                return "Ec Utbulding";
            } }

        public void AddClass(string classname, int numberofstudent)

        {
            var mlass = classes.SingleOrDefault(x => x.Name == classname);
            if (mlass != null)
            {
                mlass.NumberofStudent += numberofstudent;
            }
            else
                classes.Add(new Class { Name = classname, NumberofStudent = numberofstudent });

        }
    }
}
