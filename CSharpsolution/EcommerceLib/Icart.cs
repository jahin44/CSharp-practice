using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLib
{
    interface Icart<T> where T: Iproduct
    {
        Iproduct Product { get; set; }
        int Quantity { get; set; }

    }
}
