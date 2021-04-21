using System;
using System.Collections.Generic;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            List<int> list = new List<int>(ar);

            int counter = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int firstElement = list[i];
                for (int j = i + 1; j < list.Count; j++)
                {
                    int secondElement = list[j];
                    if (firstElement == secondElement)
                    {
                        list.RemoveAt(i);
                        list.RemoveAt(j - 1);
                        i = -1;
                        j = -1;
                        counter++;
                        break;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
