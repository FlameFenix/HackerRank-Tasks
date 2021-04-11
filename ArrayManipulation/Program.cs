using System;
using System.Linq;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 10;

            long[,] matrix = new long[n,m];

            long maxValue = 0;
            int[][] queries = new int[3][];
            queries[0] = new int[] { 1, 5, 3 };
            queries[1] = new int[] { 4, 8, 7 };
            queries[2] = new int[] { 6, 9, 1 };

            for (int i = 0; i < queries.Length; i++)
            {
                int[] currentCommand = queries[i];
                int startIndex = currentCommand[0];
                int endIndex = currentCommand[1];
                long value = currentCommand[2];

                for (int rows = i + 1; rows < matrix.GetLength(0); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(1); cols++)
                    {
                        if (cols >= startIndex - 1 && cols < endIndex)
                        {
                            matrix[rows, cols] += value;
                            if (matrix[rows, cols] > maxValue)
                            {
                                maxValue = matrix[rows, cols];
                            }
                        }
                        else
                        {
                            matrix[rows, cols] += 0;
                        }

                    }
                }
            }

            printMatrix(matrix);
            Console.WriteLine(maxValue);

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
