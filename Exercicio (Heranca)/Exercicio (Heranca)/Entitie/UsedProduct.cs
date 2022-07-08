using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__Heranca_.Entitie
{
    internal class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct (string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string PriceTag()
        {
            return Name
                +" (used) $ "
                + Price.ToString("F2")
                + " (Manufacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
