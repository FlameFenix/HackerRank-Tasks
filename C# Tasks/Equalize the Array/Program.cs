using System;
using System.Collections.Generic;

namespace Equalize_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>()
            {
                3,3,2,1,3
            };

            int biggestCount = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                int currentNum = arr[i];
                int counter = arr.FindAll(x => x == currentNum).Count;

                if(counter > biggestCount)
                {
                    biggestCount = counter;
                }
            }
            Console.WriteLine(arr.Count - biggestCount);
           // return arr.Count - biggestCount;
        }
    }
}
