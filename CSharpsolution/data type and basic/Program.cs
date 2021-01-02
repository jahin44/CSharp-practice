using System;

namespace data_type_and_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random() ;
            int[,] arr = new int[10,10];
            for(int i = 0; i < 10; i++)
            {  for(int j = 0; j <10; j++)
                {
                    arr[i,j] = ran.Next(1,100);
                } 

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write( ran.Next(1,11)+"\t");

                }
                Console.WriteLine();
            }




        }
    }
}
