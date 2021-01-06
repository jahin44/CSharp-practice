using System;

namespace prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num, i, ctr, stno, enno;

         
  

            Console.Write("Input starting number of range: ");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The prime numbers between {stno} and {enno} are : ");

            for (num = stno; num <= enno; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");



        }
    }
}
