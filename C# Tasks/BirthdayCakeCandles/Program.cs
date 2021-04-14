using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> candles = new List<int>() { 82, 49, 82, 82, 41, 82 ,15, 63 ,38 ,25 };

            int maxValue = candles.Max();
            int counter = 0;

            foreach (var item in candles.OrderBy(x => x))
            {
                if(item == maxValue)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
