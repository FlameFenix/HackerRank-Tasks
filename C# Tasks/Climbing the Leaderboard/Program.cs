using System;
using System.Collections.Generic;
using System.Linq;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ranked = new List<int>() { 100, 100, 100, 50, 40, 40, 20, 10 };

            Dictionary<int, int> ranks = new Dictionary<int, int>();

            List<int> player = new List<int>() { 5, 25, 50, 120 };

            int index = 1;

            for (int i = 0; i < ranked.Count; i++)
            {
                if (i > 0 && ranked[i - 1] == ranked[i])
                {
                    continue;
                }

                ranks.Add(index++, ranked[i]);
            }

            for (int i = 0; i < ranks.Count; i++)
            {

            }

            Console.WriteLine(String.Join("", ranks));
        }
    }
}
