using System;

namespace CatsAndAMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPosition = new int[] {1,2,3};  //{ 1, 3, 2 };  => Mouse C
            Console.WriteLine(CatAndMouse(firstPosition)); // Cat B
        }

        private static string CatAndMouse(int[] firstPosition)
        {
            int x = firstPosition[0];
            int y = firstPosition[1];
            int z = firstPosition[2];
            int countX = 0;
            int countY = 0;
            if (x > z || y > z)
            {
                if (x > z)
                {
                    countX = x - z;
                }
                if (y > z)
                {
                    countY = y - z;
                }
            }
            if (x < z || y < z)
            {
                if (x < z)
                {
                    countX = z - x;
                }
                if (y < z)
                {
                    countY = z - y;
                }
            }

            if (countX > countY)
            {
                return "Cat B";
            }
            else if (countX < countY)
            {
                return "Cat A";
            }
            else
            {
                return "Mouse C";
            }
        }
    }
}
