using System;
using System.Collections.Generic;
using System.Linq;

namespace Mark_and_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> prices = new List<int>() { 1, 12 ,5, 111 ,200 ,1000, 10 };

            prices = prices.OrderBy(x => x).ToList();

            List<int> maxLength = new List<int>();

            int k = 50;

            int sum = 0;
            int index = 0;

            while (sum <= k)
            {
                sum += prices[index];
                if (sum <= k)
                {
                    maxLength.Add(prices[index]);
                }
                index++;
            }

            Console.WriteLine(string.Join(" ", maxLength));
        }
    }
}
