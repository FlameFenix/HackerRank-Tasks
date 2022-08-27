using System;
using System.Linq;

namespace Forming_a_Magic_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            FillMatrix(matrix);
            int biggestSum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int sum = 0;
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int currentElement = matrix[rows, cols];
                    sum += currentElement;
                }

                if(sum > biggestSum)
                {
                    biggestSum = sum;
                }
            }


            PrintMatrix(matrix);


        }

        private static void PrintMatrix(int[,] matrix)
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

        private static void FillMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] nums = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = nums[cols];
                }
            }
        }
    }
}
