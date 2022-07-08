using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_3__enum_.Entities.Enum
{
    enum OrderStatus :int
    {
        Pending_Paymente = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
