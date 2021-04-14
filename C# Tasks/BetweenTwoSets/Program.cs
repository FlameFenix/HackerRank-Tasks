using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 2, 4 };

            List<int> b = new List<int>() { 16, 32, 96 };

            int[] mixedArray = new int[a.Count + b.Count];


            int loading = 0;
            for (int x1 = 0; x1 < a.Count; x1++)
            {
                mixedArray[loading] = a[x1];
                loading++;
            }

            for (int x2 = 0; x2 < b.Count; x2++)
            {
                mixedArray[loading] = b[x2];
                loading++;
            }

            int aMaxValue = a.Max();
            int bMinValue = b.Min();

            int result = 0;

            for (int division = aMaxValue; division <= bMinValue; division++)
            {
                int countNumbers = 0;

                for (int numbers = 0; numbers < mixedArray.Length; numbers++)
                {
                    if(mixedArray[numbers] > division)
                    {
                        if (mixedArray[numbers] % division == 0)
                        {
                            countNumbers++;
                            if (countNumbers == mixedArray.Length)
                            {
                                result++;
                            }
                        }
                    }
                    else
                    {
                        if (division % mixedArray[numbers] == 0)
                        {
                            countNumbers++;
                            if (countNumbers == mixedArray.Length)
                            {
                                result++;
                            }
                        }
                    }
                    
                }
            }

            Console.WriteLine(result);
        }
    }
}
