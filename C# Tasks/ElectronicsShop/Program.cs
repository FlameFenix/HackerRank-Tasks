using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 10;
            int[] keyboards = new int[] { 3, 1 };

            List<int> inputKeyboards = new List<int>(keyboards);

            int[] drives = new int[] { 5, 2, 8 };

            int expensiveThings = -1;

            while (inputKeyboards.Count != 0)
            {
                int keyBoardMaxValue = inputKeyboards.Max();
                for (int i = 0; i < drives.Length; i++)
                {
                    if (keyBoardMaxValue + drives[i] <= b)
                    {
                        if (keyBoardMaxValue + drives[i] >= expensiveThings)
                        {
                            expensiveThings = keyBoardMaxValue + drives[i];
                        }
                    }
                }

                inputKeyboards.Remove(keyBoardMaxValue);
            }

            Console.WriteLine(expensiveThings);  // expected 9;
        }
    }
}
