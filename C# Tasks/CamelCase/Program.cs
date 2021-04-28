using System;
using System.Linq;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "saveChangesInTheEditor";
            int counter = 1;
            for (int i = 0; i < s.Length; i++)
            {
               if(char.IsUpper(s[i]))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
