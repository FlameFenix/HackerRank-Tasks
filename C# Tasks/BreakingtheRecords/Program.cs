using System;

namespace BreakingtheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int maxScore = scores[0];
            int countMaxScores = 0;

            int minScore = scores[0];
            int countMinScores = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    countMaxScores++;
                }
                else if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    countMinScores++;
                }
            }

            int[] countScore = new int[] { countMaxScores, countMinScores };

            Console.WriteLine(string.Join(" ", countScore));
        }
    }
}
