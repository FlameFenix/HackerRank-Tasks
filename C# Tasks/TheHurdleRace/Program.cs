using System;

namespace TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 4;
            int[] height = new int[] { 1, 6, 3, 5, 2 };
            int biggestValue = int.MinValue;

            for (int i = 0; i < height.Length; i++)
            {
                int element = height[i];
                if (element - k > biggestValue)
                {
                    biggestValue = element - k;
                }
            }

            Console.WriteLine(biggestValue);
        }
    }
}
