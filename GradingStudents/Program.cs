using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 73, 67, 38, 33};

            for (int grade = 0; grade < grades.Count; grade++)
            {
                int currentGrade = grades[grade];

                for (int round = 1; round < 3; round++)
                {
                    currentGrade = currentGrade + 1;
                    if (currentGrade % 5 == 0 && currentGrade >= 40)
                    {
                        int position = grades.IndexOf(grades[grade]);
                        grades.RemoveAt(position);
                        grades.Insert(position, currentGrade);

                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, grades));
            
        }
    }
}
