using System;
using System.Collections.Generic;

namespace Circular_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3 };

            int k = 2;

            List<int> queries = new List<int>() { 0, 1, 2 };

            
            for (int i = 0; i < k; i++)
            {
                int lastElement = a[a.Count - 1];
                a.Insert(0, lastElement);
                a.RemoveAt(a.Count - 1);
            }

            List<int> result = new List<int>();

            for (int i = 0; i < queries.Count; i++)
            {
                result.Add(a[queries[i]]);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
