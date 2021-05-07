using System;
using System.Text;

namespace Append_and_Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;

            string s = "ashley";

            string t = "ash";

            string output = string.Empty;

            while (s.Length + k != t.Length && k > 0)
            {
                if(s.Length > 0)
                {
                    s = s.Remove(s.Length - 1);
                }

                k--;
            }

            while (k > 0)
            {
                s += t[s.Length];
                k--;
            }

            if(s == t)
            {
                output = "Yes";  
            }
            else
            {
                output = "No";
            }

            Console.WriteLine(output); // expected string "ash" but is "ashl" 

        }
    }
}
