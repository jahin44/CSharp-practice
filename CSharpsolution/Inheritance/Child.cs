using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Child : parents, Base 
    {
        public void ChildFunction()
        {
            parentsFunction();
            Console.WriteLine("This is Child Function");
        }




    }
}
