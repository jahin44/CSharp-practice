using System;

namespace Add_string_number
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = Console.ReadLine();

            string[] linePart = inputString.Split(' ', ',', '\n');  // split as , and " " and new line
           /* Console.WriteLine(linePart[1]);*/
            string num0 = linePart[0];
            
            string num1 = linePart[1];
            int val0 = num0.Length;
            int iv0 = val0;
            int val1 = num1.Length;
            int iv1 = val1;
          /*  Console.WriteLine(val0);
            Console.WriteLine(val1)*/;
            int arraySize;
            if (val0 > val1)
            {
                arraySize = val0;

            }
            else { arraySize = val1; }
            int[] arr0 = new int[arraySize];
            int[] arr1 = new int[arraySize];
            for (int i =0; i <iv0; i++)
            {
                arr0[i] = num0[val0-1]-48;
                val0--;
            }
            for (int i = 0; i < iv1; i++)
            {
                arr1[i] = num1[val1-1]-48;
                val1--;
            }
        /*    for (int i = 0; i < arraySize; i++)
            {
                Console.Write(arr0[i]);
                Console.Write(" ");
                Console.Write(arr1[i]);
                Console.WriteLine();
            }*/
            int tamp=0;
            int rem=0;
            int[] ans = new int[arraySize+1];
            int ansloop = arraySize;
            for(int i = 0; i <= arraySize; i++)
            {
                if (i != arraySize)
                {
                    tamp = arr0[i] + arr1[i];
                    tamp = tamp + rem;
                    if (tamp >= 10)
                    {
                        tamp = tamp % 10;
                        rem = 1;
                    }
                    else { rem = 0; }
                    ans[ansloop] = tamp;
                    ansloop--;
                }
                else {
                    ans[ansloop] = rem;
                }
                
            }
            for (int i = 0; i <= arraySize; i++)
            {
                Console.Write(ans[i]+" ");
             
            }


        }
    }
}
