using System;
using System.Collections.Generic;
using System.Linq;

namespace _2D_Array___DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 6];

            FillMatrix(matrix);

            int biggestSum = int.MinValue;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int currentSum = 0;

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    try
                    {
                        int firstNum = matrix[rows, cols];
                        int secondNum = matrix[rows, cols + 1];
                        int thirdNum = matrix[rows, cols + 2];
                        int fourthNum = matrix[rows + 1, cols + 1];
                        int fifthNum = matrix[rows + 2, cols];
                        int sixthNum = matrix[rows + 2, cols + 1];
                        int seventhNum = matrix[rows + 2, cols + 2];

                        currentSum = firstNum + secondNum + thirdNum + fourthNum + fifthNum + sixthNum + seventhNum;

                        if(currentSum > biggestSum)
                        {
                            biggestSum = currentSum;
                        }

                    }
                    catch (Exception)
                    {

                    }

                }
            }

            Console.WriteLine(biggestSum);
        }

        public static int[,] FillMatrix(int[,] matrix)
        {

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = numbers[cols];
                }
            }

            return matrix;
        }
    }
}
