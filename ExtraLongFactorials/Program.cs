using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = new BigInteger();
            factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
