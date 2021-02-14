using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLib
{
    public interface IshopingCart<T> where T : Iproduct
    {
        T[] Items { get; }
        void AddItem(T item, int quantity);
        double GetTotal();
    }
}
