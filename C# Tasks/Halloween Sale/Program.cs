using System;
using System.Collections.Generic;
using System.Linq;

namespace Halloween_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 16; // price
            int d = 2; // decrease price 
            int m = 1; // minimum price
            int s = 9981; // budget

            List<int> games = new List<int>();

            while (s - p >= 0)
            {
                s -= p;
                games.Add(p);
                if(p - d > m)
                {
                    p -= d;
                }
                else
                {
                    p = m;
                }
            }

            Console.WriteLine(games.Count);
        }
    }
}
