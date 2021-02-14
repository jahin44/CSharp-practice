using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Base
    {
        public string vehicle;
        public string name;
        public int wheel;
        public bool IsTrue;

        public abstract void BaseFunction()
        {     
            Console.WriteLine(wheel);
            Console.WriteLine(IsTrue);
            Console.WriteLine(vehicle);
        }


    }
}
