using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };

            List<int> highestValue = new List<int>() { 0, 0, 0, 0, 0 };

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 1)
                {
                    highestValue[0]++;
                }
                else if (arr[i] == 2)
                {
                    highestValue[1]++;
                }
                else if (arr[i] == 3)
                {
                    highestValue[2]++;
                }
                else if (arr[i] == 4)
                {
                    highestValue[3]++;
                }
                else if (arr[i] == 5)
                {
                    highestValue[4]++;
                }
            }

            int firstIndex = highestValue.IndexOf(highestValue.Max()) + 1;
            int secondIndex = highestValue.IndexOf(highestValue.Max()) + 1;

            Console.WriteLine($"{(firstIndex == secondIndex ? secondIndex : firstIndex)}");
        }
    }
}
