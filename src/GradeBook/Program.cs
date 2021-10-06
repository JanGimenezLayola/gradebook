using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Book
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            Console.WriteLine($"The sum grades is {result}");
        
            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N3}"); // :N3 -> round to three decimal places
        }
    }
}
