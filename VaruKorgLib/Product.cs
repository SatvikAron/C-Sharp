using System;
using System.Collections.Generic;
using System.Text;

namespace VaruKorgLib
{
    public class Product
    {
        private string name;

        public Product(string name)
        {
            this.name = name;
        }

        public int Pris { get; set; }
    }
}
