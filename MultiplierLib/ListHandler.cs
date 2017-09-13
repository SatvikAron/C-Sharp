using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();
        

        public void AddFiveStrings()
        {
            List.Add("Red");
            List.Add("Green");
            List.Add("Blue");
            List.Add("Orange");
            List.Add("Skyblue");

        }

        public void RemoveThirdString()
        {
            List.Remove("Blue");
        }

        public void Sort()
        {
            List.Sort();
        }
    }
}