using System;
using System.Collections.Generic;
using System.Linq;

namespace Picking_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 1, 2, 2, 4, 4, 5, 5, 5 };

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                List<int> current = a.Where(x => x == a[i] + 1 || x == a[i]).ToList();

                if (current.Count > longestSequence.Count)
                {
                    longestSequence = current;
                }

                current = a.Where(x => x == a[i] - 1 || x == a[i]).ToList();

                if (current.Count > longestSequence.Count)
                {
                    longestSequence = current;
                }
            }

            Console.WriteLine(string.Join(" ", longestSequence.Count));
        }
    }
}
