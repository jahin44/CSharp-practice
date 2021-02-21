using System;

namespace Classpractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Base obj = new Child();
            obj.Name ="Jahin Hasan";
            Base.age = 20;
            MapClass obj2 = new MapClass();
            obj2.Location = "Farmget,Dhaka";
            obj2.HouseNumber = 9;
            obj2.Address();
            obj2.map();
            obj.method();
            obj.Person();
            ChildInChild obj1 = new ChildInChild();
            obj1.Name = "Israt Jahan supty";
            Base.age = 30;
            obj1.method();
            obj1.Person();
            var Box = new GenericClass<String,int,double>();
            Box.BoxColour = "Green";
            Box.BoxPrice =300.20;
            Box.BoxSize = 20;
            Box.Box();
            Console.WriteLine("Hello World!");
        }
    }
}
