using System;

namespace HackerRank_in_a_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            string random = "hackerrank";

            string hackerrankInString = "hhaacckkekraraannk";

            string isHackerRank = string.Empty;

            for (int i = 0; i < hackerrankInString.Length; i++)
            {
                if (isHackerRank.Length < random.Length 
                 && hackerrankInString[i] == random[isHackerRank.Length])
                {
                    isHackerRank += hackerrankInString[i];
                }
            }

            string isSame = random == isHackerRank ? "YES" : "NO";
            Console.WriteLine(isSame);
        }
    }
}
