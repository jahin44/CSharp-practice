using System;

namespace print_all_odd_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int remin;
           int number= Convert.ToInt32(Console.ReadLine());
           while (number != 0)
            {
                remin = number % 10;
                number = number / 10;
                if (remin%2!=0)
                {
                    Console.Write(remin);
                }


            }
        }
    }
}
