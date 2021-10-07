using System;
using System.Collections.Generic;
namespace GradeBook

{
    class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;

            foreach(double number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }

            Console.WriteLine($"The sum grades is {result}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The higher grade is {highGrade}");
        
            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N1}"); // :N3 -> round to three decimal places
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        private List<double> grades;
        private string name;
    
    }
}