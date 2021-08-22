using System;
using System.Collections.Generic;
using System.Linq;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ranked = new List<int>() { 100, 100, 50, 40, 40, 20, 10 };

            ranked = ranked.OrderByDescending(x => x).ToList();

            List<int> player = new List<int>() { 5, 25, 50, 120 };

            Dictionary<int, Dictionary<int, int>> positions = new Dictionary<int, Dictionary<int, int>>();
            int index = 1;
            int count = 1;
            int lowestIndex = int.MinValue;

            foreach (var item in ranked)
            {
                if (positions.ContainsKey(item))
                {
                    positions[item][index - 1] += 1;
                }
                else
                {
                    positions.Add(item, new Dictionary<int, int>());
                    positions[item].Add(index++, count);
                }

                if (lowestIndex < index)
                {
                    lowestIndex = index;
                }
            }

            foreach (var currentPlayer in player)
            {
                int currentPosition = positions.FirstOrDefault(x => x.Key <= currentPlayer).Key;

                if (currentPosition <= 0)
                {
                    Console.WriteLine(lowestIndex);
                }
                else
                {
                    var currentTarget = positions.FirstOrDefault(x => x.Key <= currentPlayer).Value;
                    foreach (var item in currentTarget)
                    {
                        Console.WriteLine(item.Key);
                    }
                }
            }
        }
    }
}
