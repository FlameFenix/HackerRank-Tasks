using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 793810624, 895642170 ,685903712 ,623789054, 468592370 };

            List<int> minSumList = new List<int>(arr.OrderBy(x => x));
            List<int> maxSumList = new List<int>(arr.OrderBy(x => x));

            BigInteger maxSum = 0;
            BigInteger minSum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minSum += minSumList[i];
            }

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                maxSum += maxSumList[i];
            }

            Console.WriteLine($"{minSum} {maxSum}");

        }
    }
}
