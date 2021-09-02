using System;
using System.Collections.Generic;
using System.Linq;

namespace Beautiful_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 1;

            List<int> arr = new List<int>() { 2,2,3,4,5 };

            List<List<int>> triplets = new List<List<int>>();

            for (int i = 0; i < arr.Count; i++)
            {
                int firstNumber = arr[i];

                int secondNumber = arr.Find(x => x - firstNumber == d && x > firstNumber);

                int thirdNumber = arr.Find(x => x - secondNumber == d && x > secondNumber);

                if(secondNumber - firstNumber == d && thirdNumber - secondNumber == d)
                {
                    triplets.Add(new List<int>() { firstNumber, secondNumber, thirdNumber });
                }
                
            }

            // return triplets.Count;

            Console.WriteLine(triplets.Count);
        }
    }
}
