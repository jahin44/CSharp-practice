using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    class ChildInChild :Child
    {

        public override void method()
        {
            Console.WriteLine($"In classInclass {Name}{age}");
        }
        
    }
}
