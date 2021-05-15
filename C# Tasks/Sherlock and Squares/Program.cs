using System;
using System.Collections.Generic;
using System.Linq;

namespace Sherlock_and_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 24;
            int b = 49;
            int x = 1;
            int numOfSquares = 0;
            while (x * x < a) x++;
            while (x * x <= b)
            {
                numOfSquares++;
                x++;
            }
            Console.WriteLine(numOfSquares);
        }

    }
}
