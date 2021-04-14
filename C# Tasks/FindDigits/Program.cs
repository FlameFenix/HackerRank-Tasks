using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1012;

            string number = n.ToString();
            char[] nums = number.ToCharArray();
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = int.Parse(nums[i].ToString());
                
                if(currentNumber != 0  && n % currentNumber == 0) 
                {
                    counter++;
                }
            }

            Console.WriteLine(counter); // 3
        }
    }
}
