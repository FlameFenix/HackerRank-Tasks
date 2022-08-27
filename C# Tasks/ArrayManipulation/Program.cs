using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 4;

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                List<int> current = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                queries.Add(current);
            }

            long[] arr = new long[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            for (int i = 0; i < queries.Count; i++)
            {
                List<int> currentCommand = queries[i];
                int startIndex = currentCommand[0];
                int endIndex = currentCommand[1];
                long value = currentCommand[2];

                for (int j = startIndex; j < endIndex; j++)
                {
                    arr[j] += value;
                }
            }

            //      printMatrix(matrix);
            Console.WriteLine(arr.Max());

            // (6 / 13) // Fault: Terminated due to timeout (Need optimizing) //
        }

        private static void printMatrix(long[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write($"{matrix[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
