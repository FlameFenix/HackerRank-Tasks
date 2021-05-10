using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            int d = 4;

            for (int i = 0; i < d; i++)
            {
                int firstElement = a[0];
                a.Remove(a[0]);
                a.Insert(a.Count, firstElement);
            }

            Console.WriteLine(string.Join(" ", a));
        }

    }
}
