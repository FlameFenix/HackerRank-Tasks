using System;
using System.IO;
using System.Linq;

namespace Chocolate_Feast
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6; // $$
            int c = 2; // $$ for piece
            int m = 2; // wrapper

            int countOfBars = n / c;
            int wrappers = 0;
            int eaten = 0;

            while (countOfBars > 0)
            {
                eaten += countOfBars;
                wrappers += countOfBars;
                countOfBars = wrappers / m;
                wrappers = wrappers % m;
            }

            Console.WriteLine(eaten);
        }
    }
}

