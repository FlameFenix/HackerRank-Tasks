using System;
using System.Linq;

namespace Counting_Valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 12;
            string path = "DDUUDDUDUUUD";

            char[] stepsToCharacters = path.ToCharArray();

            bool isDeep = false;

            int counter = 0;
            int countValleys = 0;

            for (int i = 0; i < steps; i++)
            {
                char currentElement = stepsToCharacters[i];
                if (currentElement == 'U')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }

                if(counter < 0)
                {
                    isDeep = true;
                }

                if(isDeep && counter >= 0)
                {
                    countValleys++;
                    isDeep = false;
                }
            }

            Console.WriteLine(countValleys);
        }
    }
}
