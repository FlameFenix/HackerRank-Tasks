using System;
using System.Collections.Generic;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 6,4,1};

            int countSwaps = 0;

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int backup = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = backup;
                        countSwaps++;
                    }
                }           
            }
            Console.WriteLine($"Array is sorted in {countSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Count - 1]}");
        }
    }
}
