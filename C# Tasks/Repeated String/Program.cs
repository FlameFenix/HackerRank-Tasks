using System.Text;
using System;
using System.Linq;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cfimaakj";
            
            long n = 554045874191;

            int countA = s.Where(x => x == 'a').Count();

            int countLeft = s.Length - countA;

            var test = n / s.Length;
            Console.WriteLine($"{test} {test / countA} - n / countLeft");
            Console.WriteLine($"{n / countLeft} - n / countLeft");
        }
    }
}
