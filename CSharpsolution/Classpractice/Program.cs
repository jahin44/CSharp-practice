using System;

namespace Classpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Name ="Jahin Hasan";
            obj.age = 20;
             
            obj.method();
            obj.Person();
            ChildInChild obj1 = new ChildInChild();
            obj1.Name = "Israt Jahan supty";
            obj1.age = 30;
            obj1.method();
            obj1.Person();
            Console.WriteLine("Hello World!");
        }
    }
}
