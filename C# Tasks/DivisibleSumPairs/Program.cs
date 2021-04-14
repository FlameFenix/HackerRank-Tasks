using System;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };
            int k = 3;
            int counter = 0;

            for (int x = 0; x < ar.Length; x++)
            {
                for (int i = x + 1; i < ar.Length; i++)
                {
                    if((ar[x] + ar[i]) % k == 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
