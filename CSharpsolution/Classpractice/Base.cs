using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    public abstract class Base
    {
       
        public int age { get; set; }
        public string Name { get; set; }

        
        public virtual void method()
        {
            Console.WriteLine($"Inside the base class {Name}{age}");
           
        }
        public abstract void Person();
        



    }
}
