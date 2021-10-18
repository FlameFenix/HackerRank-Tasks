using System;
using System.Linq;

namespace Beautiful_Binary_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "0101010";

            int originalStringLength = b.Length;

            string a = b.Replace("010", "");

            int stringAfterReplacement = a.Length;

            int result = (originalStringLength - stringAfterReplacement) / 3;

            Console.WriteLine(result);
        }
    }
}
