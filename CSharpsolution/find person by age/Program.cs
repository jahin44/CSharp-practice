using System;

namespace find_person_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name=new string[10];
            int[] age = new int[10];

            for (int i = 0; i < 4; i++)
            {
                    name[i] = Console.ReadLine();
                    age[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            for (int i = 0; i < 10; i++)
            {
                if (age[i] > 50)
                {
                    Console.WriteLine(name[i]);
                }
            }

             
        
        
        }
    }
}
