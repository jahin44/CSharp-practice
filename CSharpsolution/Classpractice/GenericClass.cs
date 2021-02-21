using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    class GenericClass<T,V,Z> 
    {
        public T BoxColour { get; set; }
        public V BoxSize { get; set; }
        public Z BoxPrice { get; set; }

        public void Box()
        {
            Console.WriteLine($"Box Colour: {BoxColour} \nBox Size: {BoxSize} \nBox Price: {BoxPrice:F3}  ");
        }


    }
}
