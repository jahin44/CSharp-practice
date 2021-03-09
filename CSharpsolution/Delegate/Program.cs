using System;

namespace Delegate
{
    public class Program
    {
        public delegate void num(string a);

        static void sum (num a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
       
              sum(1);



        }
    }
}
