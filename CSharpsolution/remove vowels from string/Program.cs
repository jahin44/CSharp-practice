using System;

namespace remove_vowels_from_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("abcdefghijklmnopqrstuvwxyz");
            
            string all = "abcdefghijklmnopqrstuvwxyz";
            
            Console.WriteLine("Remove: ");
            
            
            string remove= Console.ReadLine();
            //char aj;
            char[] charArr = all.ToCharArray();
            char[] charre = remove.ToCharArray();
            char[] newstr = new char[26];


            for (int i=0;i<charre.Length;i++)
            {
                for (int j = 0; j < charArr.Length; j++)
                {
                    if (charArr[j] == charre[i])
                        charArr[j] = ' ';

                }
         
            
            }
            




            for (int i = 0; i < charArr.Length; i++)
            {
               if (charArr[i]!=' ')
                {
                    Console.Write(charArr[i]);
                }
            }





        }
    }
}
