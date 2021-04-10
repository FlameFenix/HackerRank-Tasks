using System;
using System.Collections.Generic;

namespace SubarrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> s = new List<int>() { 1 ,1 ,1 ,1 ,1 ,1 };

            int d = 3;
            int m = 2;

            int counter = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                int sum = 0;
                for (int y = 0; y < m; y++)
                {
                    sum += s[i + y];
                }
                if(sum == d)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
