using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "aba";
            
            long n = 100;

            int containsA = s.Where(x => x == 'a').Count();

            double result = Math.Ceiling((Convert.ToDouble(n) / s.Length) * containsA);

            Console.WriteLine(result);

        }
    }
}
