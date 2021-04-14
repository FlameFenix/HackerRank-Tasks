using System;
using System.Linq;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "12:01:00AM";

            DateTime convert = DateTime.Parse(s);

            Console.WriteLine(convert.ToString("HH:mm:ss"));
        }
    }
}
