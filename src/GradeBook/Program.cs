using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
    
            var book = new Book("Jan's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The higher grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}"); // :N3 -> round to three decimal places

        }
    }
}
