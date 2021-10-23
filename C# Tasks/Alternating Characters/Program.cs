using System;

namespace Alternating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "AABAAB";
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                char prevChar = s[i];
                char currentChar = s[i + 1];

                if(prevChar == currentChar)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
