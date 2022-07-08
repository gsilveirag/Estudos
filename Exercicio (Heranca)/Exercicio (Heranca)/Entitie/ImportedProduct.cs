using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio__Heranca_.Entitie
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name
               + " $ "
               + TotalPrice().ToString("F2")
               + " (Customs fee: $ "
               + CustomsFee.ToString("F2")
               + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
