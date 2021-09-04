using System;
using System.Collections.Generic;

namespace Minimum_Distances
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 3, 2, 1, 2, 3 };

            int minDistance = int.MaxValue;

            for (int i = 0; i < a.Count; i++)
            {
                int currentElement = a[i];
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (currentElement == a[j])
                    {
                        int distance = j - i;
                        if (minDistance > distance)
                        {
                            minDistance = distance;
                        }
                    }
                }
            }

            if (minDistance == int.MaxValue)
            {
                minDistance = -1;
            }
            Console.WriteLine(minDistance);
            // return minDistance;
        }
    }
}
