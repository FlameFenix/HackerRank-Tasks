using System;
using System.Collections.Generic;

namespace BillDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bill = new List<int>() { 3, 10, 2, 9 };

            int k = 1; 
            int b = 12;
            int sum = 0;

            for (int i = 0; i < bill.Count; i++)
            {
                if (i != k)
                {
                    sum += bill[i];
                }
            }

            sum /= 2;
            Console.WriteLine($"{(sum == b ? "Bon Appetit" : $"{Math.Abs(sum - b)}")}");
        }
    }
}
