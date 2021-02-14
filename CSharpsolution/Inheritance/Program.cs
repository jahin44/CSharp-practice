using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Derived obj1 = new Derived();
            obj1.Inherit();
            parents obj2 = new Child();
            obj2.parentsFunction();
            parents obj3 = new child2nd();
            obj3.parentsFunction();


        }
    }
}
