using System;
using System.Collections.Generic;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int res = 0;
            int final = 0;
            while (res != n + 1)
            {
                int result = 0;
                for (int i = 0; i <= res; i++)
                {
                    if (i % 2 == 0)
                    {
                        result += 1;
                    }
                    else
                    {
                        result *= 2;
                    }
                }

                if(final < result)
                {
                    final = result;
                }
                res++;
            }

            Console.WriteLine(final);
        }
    }
}
