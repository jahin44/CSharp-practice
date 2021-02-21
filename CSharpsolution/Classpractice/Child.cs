using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    public class Child :Base
    {

        public override void  method()
        {
            
            Console.WriteLine(Name+" In child Class");
            
        }
        public override void Person()
        {
            Console.WriteLine($"Name: {Name} Age: {age}");
        }
    }
}
