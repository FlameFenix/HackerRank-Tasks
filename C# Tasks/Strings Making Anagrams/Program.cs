using System;
using System.Linq;

namespace Strings_Making_Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "cde";
            string b = "abc";

            int countDeletions = 0;
            while (true)
            {
                string first = string.Empty;

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    first += a[i];
                }

                if(first != b)
                {
                    a = a.Remove(a.Length - 1);
                    b = b.Remove(b.Length - 1);
                    countDeletions += 2;
                }
                else
                { break; }

            }

            Console.WriteLine(countDeletions);
        }
    }
}
