using System;
using System.Collections.Generic;
using System.Text;

namespace Classpractice
{
    public abstract class Base
    {
       
        public static int age { get; set; }
        public string Name { get; set; }

        public static void StaticMethod()
        {
            Console.WriteLine($"Inside the static Method {age}");
        }
        public virtual void method()
        {
            Console.WriteLine($"Inside the base class {Name}{age}");
           
        }
        public abstract void Person();
        



    }
}
