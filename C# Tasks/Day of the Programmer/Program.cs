using System;

namespace Day_of_the_Programmer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = 9;
            int sumDays = 0;

            for (int i = 1; i <= 8; i++)
            {
                sumDays += DateTime.DaysInMonth(year, i);
            }

            DateTime date = new DateTime(year, month, 1);

            int day = 0;

            day = 256 - sumDays;

            date = new DateTime(year, month, day);

            if(year == 1918)
            {
                date = new DateTime(year, 1, 1);
                date = date.AddDays(255 + 13);
            }
            // Console.WriteLine(sumDays);
            
             Console.WriteLine(date.ToString("dd.MM.yyyy"));
        }
    }
}
