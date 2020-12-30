using System;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YOUR TEXT");
            string line = Console.ReadLine();
            string[] linepart = line.Split(' ',',') ;//split as , and " " 
            foreach(string a in linepart)
            {
                Console.WriteLine(a);
            }

        }
    }
}
