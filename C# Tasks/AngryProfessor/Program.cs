using System;
using System.Text;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3;
            int[] a = new int[] { -2, -1, 0, 1, 2 };
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(AngryProfessor(k, counter));
        }

        private static string AngryProfessor(int k, int counter)
        {
            StringBuilder sb = new StringBuilder();

            if (counter >= k)
            {
              sb.AppendLine("NO");  // Class is not cancelled;
            }
            else
            {
                sb.AppendLine("Yes"); // Class is cancelled;
            }
            return sb.ToString().Trim();
        }
    }
}
