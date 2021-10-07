using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // var program = new Program();
            // can't call program.Main()
            // Program.Main(args);
            // this causes a infinit loop

            var book = new Book("Jan's Grade Book");
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);
            
            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            Console.WriteLine($"The sum grades is {result}");
        
            var average = result / grades.Count;
            Console.WriteLine($"The average grade is {average:N1}"); // :N3 -> round to three decimal places
        }
    }
}
