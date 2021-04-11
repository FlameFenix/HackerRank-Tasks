using System;

namespace AppleandOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            // first line input s ==> t (house location)
            int s = 7;  // s
            int t = 11;   // t

            int a = 5;     // apple tree location
            int b = 15;   // orange tree location

            int[] apples = new int[] { -2, 2, 1 };
            int[] oranges = new int[] { 5, -6 };

            int countApples = 0;
            
            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = a + apples[i];
                if(apples[i] >= s && apples[i] <= t)
                {
                    countApples++;
                }
            }
            int countOranges = 0;
            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = b + oranges[i];
                if (oranges[i] >= s && oranges[i] <= t)
                {
                    countOranges++;
                }
            }

            Console.WriteLine(countApples);     // expected output: 1
            Console.WriteLine(countOranges);    // expected output: 1
        }
    }
}
