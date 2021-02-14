using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceLib
{
    public interface Iproduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Imageural { get; set; }
        
    }
}
