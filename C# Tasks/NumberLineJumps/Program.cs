using System;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int v1 = 2;

            int x2 = 5;
            int v2 = 3;
            bool isFound = false;
            while (x1 != x2)
            {
                x1 += v1;
                x2 += v2;
                if(x1 == x2)
                {
                    Console.WriteLine("YES");
                    isFound = true;
                    break;
                }
                if(x1 > x2 && v1 > v2)
                {
                    break;
                }
                else if (x2 > x1 && v2 > v1)
                {
                    break;
                }
            }

            if(!isFound)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
