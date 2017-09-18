using System;
using System.Collections.Generic;
using System.Linq;

namespace VaruKorgLib
{
    public class VaruKorg
    {
        
        public Kund kund { get; set; }
        public Orderbekräftelse Orderbekräftelse { get; set; }
        private List<Product> producter = new List<Product>();
        public int Total
        {
            get
            {
                return producter.Sum(x => x.Pris);
            }
        }

      
public void Beställ()
        {
            this.Orderbekräftelse = new Orderbekräftelse
            {
                Meddelande = $"{this.kund.FirstName+" "+this.kund.LastName} har beställt varor för {this.Total} kr"
            };
        }

        public void LäggTillProdukt(Product item)
        {
            this.producter.Add(item);
        }
    }
}
