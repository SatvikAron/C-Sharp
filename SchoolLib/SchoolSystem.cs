using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolLib
{
    public class SchoolSystem
    {
        private List<Class> classes = new List<Class>();
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

        public void AddClass(string classname, int numberofstudent)

        {
            var mlass = classes.SingleOrDefault(x => x.Name == classname);
            if (mlass !=null)
            {
               mlass. NumberofStudent += numberofstudent;
            }
            else
            classes.Add(new Class { Name = classname, NumberofStudent = numberofstudent });
        }
    }
}
