using System;

namespace Designer_PDF_Viewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = new int[26] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            string word = "aba";

            int tallestInteger = int.MinValue;

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];
                int currentTall = h[(int)currentChar - 97];

                if (currentTall > tallestInteger)
                {
                    tallestInteger = h[(int)currentChar - 97];
                }

            }

            Console.WriteLine((tallestInteger * word.Length));
        }
    }
}
