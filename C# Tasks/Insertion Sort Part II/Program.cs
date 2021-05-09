using System;

namespace Insertion_Sort_Part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 1, 4, 3, 5, 6, 2 };

            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    int firstElement = arr[j - 1];
                    int secondElement = arr[j];

                    if (secondElement < firstElement)
                    {
                        int backup = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = backup;
                    }

                    j--;
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
