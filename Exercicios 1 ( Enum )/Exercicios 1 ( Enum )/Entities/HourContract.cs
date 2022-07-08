using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_1___Enum__.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract (DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public HourContract ()
        {

        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
