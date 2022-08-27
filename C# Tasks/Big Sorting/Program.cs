using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Big_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> unsorted = new List<string>()
            {
                "8",
"1",
"2",
"100",
"12303479849857341718340192371",
"3084193741082937",
 "3084193741082938",
"111",
"200"
            };


            for (int i = 0; i < unsorted.Count; i++)
            {
                for (int j = i + 1; j < unsorted.Count; j++)
                {
                    BigInteger currentNum = BigInteger.Parse(unsorted[i]);
                    BigInteger sortNum = BigInteger.Parse(unsorted[j]);

                    if(currentNum > sortNum)
                    {
                        string prevNum = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = prevNum;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', unsorted));
        }
    }
}
