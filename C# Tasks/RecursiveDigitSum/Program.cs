using System;
using System.Linq;
using System.Numerics;

namespace RecursiveDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            BigInteger currentNum = sum;

            for (int i = 1; i < k; i++)
            {
                sum += currentNum;
            }

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
