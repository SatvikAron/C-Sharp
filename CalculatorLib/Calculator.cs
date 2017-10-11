using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorLib
{
    public class Calculator
    {
        private string buffer = "";
        public int Display { get; set; }
        private List<int> numbers = new List<int>();
        public void Poweron()
        {
            Display = 0;
        }

        public void Press(string key)

        {
            if (key== "+")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
            }
            else if (key == "=")
            {
                var number = int.Parse(buffer);
                numbers.Add(number);
                buffer = "";
                Display = numbers.Sum();
            }
            else
            {
                buffer += key;
                Display = int.Parse(buffer);
            }
        }
        }
    }

