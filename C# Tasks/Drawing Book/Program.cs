using System;

namespace Drawing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int p = 4;

            int lowestPage = int.MaxValue;
            int countPage = 0;
            int[] arr = new int[n];

            for (int i = 1; i < arr.Length; i++)
            {
                if(i % 2 == 0)
                {
                    countPage++;
                }

                if(i == p)
                {
                    break;
                }
            }

            if(countPage < lowestPage)
            {
                lowestPage = countPage;
            }

            countPage = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if(i % 2 != 0)
                {
                    countPage++;
                }

                if (i == p)
                {
                    break;
                }
            }

            if (countPage < lowestPage)
            {
                lowestPage = countPage;
            }

            if(arr.Length == p)
            {
                lowestPage = 0;
            }

            Console.WriteLine(lowestPage);
        }
    }
}
