﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
   public class PurchaseCalcution
    {
        public decimal EXecute(int qty, decimal amount, bool withVat)
        {
            if (withVat)
                return qty * amount * 1.25M;
             else
                return qty * amount;
        }
    }
}
