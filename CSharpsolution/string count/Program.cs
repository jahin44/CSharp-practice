using System;

namespace string_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int size =text.Length;
            int count = 0;
            char[] charArr = text.ToCharArray();
            char[] chartmp = text.ToCharArray();
            for (int i=0; i < charArr.Length; i++)

            {
                count = 0;
                if (chartmp[i] != '0' && chartmp[i] !=' ')
                {

                    for (int j = 0; j < charArr.Length; j++)
                    {

                        if (charArr[i] == charArr[j])
                        {
                            count++;
                            chartmp[j] = '0';
                        }


                    }
                    Console.WriteLine(charArr[i] + ":" + count);
                }


            }




        }
    }
}
