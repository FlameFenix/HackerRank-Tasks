using System;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 13;
            int j = 45;
            int k = 3;
            int counter = 0;
            for (int index = i; index <= j; index++)
            {
                int currentNum = index;
                int reminder = 0;
                int reversed = 0;
                while(currentNum != 0)
                {
                    reminder = currentNum % 10;
                    reversed = reversed * 10 + reminder;
                    currentNum /= 10;
                }
                if(Math.Abs(index - reversed) % k == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
