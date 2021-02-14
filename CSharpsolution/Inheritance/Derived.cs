using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Derived : Base 
    {
        public string name;
        public override BaseFunction(string nam)
        {

        }
        public void Inherit()
        {
            name = BaseFunction("BMW");
            Console.WriteLine(name + "I want to Buy this");
        }


    }
}
