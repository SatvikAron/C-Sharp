using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEAccountLIb
{
    public class Account
    {
        public string Name { get; set; }
        public bool IsSummary { get; set; }
        public List<Account> Children { get; set; }
    }
}
