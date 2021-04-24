using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace RecursiveDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int[] arr = input.Select(x => Convert.ToInt32(x.ToString())).ToArray();
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = arr.Sum();

            sum = sum * k;

            int finalSum = SuperDigit(sum.ToString());

            Console.WriteLine(finalSum);
        }

        static int SuperDigit(string numberToString)
        {
            if(numberToString.Length == 1)
            {
                return int.Parse(numberToString);
            }
            else
            {
                BigInteger number = BigInteger.Parse(numberToString);
                BigInteger sum = 0;

                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                return SuperDigit(sum.ToString());
            }
        }

    }
}
