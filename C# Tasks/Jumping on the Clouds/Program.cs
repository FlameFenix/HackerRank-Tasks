using System;
using System.Collections.Generic;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> c = new List<int>() { 0 ,0, 0, 1, 0 ,0 };

            int result = 0;

            for (int i = 0; i < c.Count; i++)
            {
                int nextPosition = -1;
                int doublePosition = -1;

                if(i + 1 < c.Count && i + 2 < c.Count)
                {
                    nextPosition = c[i + 1];
                    doublePosition = c[i + 2];
                }
                else
                {
                    if(i + 1 < c.Count)
                    {
                        nextPosition = c[i + 1];
                    }
                    
                }

                if (nextPosition == 0 && (doublePosition == 1 || doublePosition == -1))
                {
                    result += 1;
                }
                else if (nextPosition == 0 && doublePosition == 0)
                {
                    result += 1;
                    i++;
                }
                else if (nextPosition == 1 && doublePosition == 0)
                {
                    result += 1;
                    i++;
                }

            }

            Console.WriteLine(result);
        }
    }
}
