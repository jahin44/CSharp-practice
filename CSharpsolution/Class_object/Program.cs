using System;

namespace Class_object
{
    class Car
    {
        public string name;
    }
    class Program
    {
        string joy = "jahin";
        static void Main(string[] args)
        {
            Car obj2 = new Car();
            obj2.name = "volvo";
            Console.WriteLine(obj2.name);
            Program obje = new Program();
            Console.WriteLine("Hello World!");
            Console.WriteLine(obje.joy);

            GetSet obj = new GetSet();
            Console.WriteLine(obj.Name = "jhin");

        
        }
    }
}
