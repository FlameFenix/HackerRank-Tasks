using System;
using System.Collections.Generic;
using System.Linq;

namespace Funny_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "lmnop";

            int[] originalAscii = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                int currentNum = s[i];
                originalAscii[i] = currentNum;
            }

            int[] reversedAscii = originalAscii.Reverse().ToArray();

            bool isFunny = true;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int firstOriginalNum = originalAscii[i];
                int secondOriginalNum = originalAscii[i + 1];

                int originalDiffrence = Math.Abs(firstOriginalNum - secondOriginalNum);

                int firstReversedNum = reversedAscii[i];
                int secondReversedNum = reversedAscii[i + 1];

                int reversedDiffrence = Math.Abs(firstReversedNum - secondReversedNum);

                if(originalDiffrence != reversedDiffrence)
                {
                    isFunny = false;
                    break;
                }
            }
            
            if(isFunny)
            {
                Console.WriteLine("Funny");
            }
            else
            {
                Console.WriteLine("Not Funny");
            }
        }
    }
}
