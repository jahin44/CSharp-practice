using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var name = "jahin";
            var person = (fullName: name, 2, married: true, 35.4, time);
            Console.WriteLine($"Name= {person.fullName}");
            Console.WriteLine($"Age = {person.Item2}");
            Console.WriteLine($"Married= {person.married}");
            Console.WriteLine($"Hight= {person.Item4}");
            Console.WriteLine($"Time= {person.Item5}");





        }
    }
}
