using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 34.1; // can initializa as var 
            double y = 10.3;
            double result = x + y;
            
            Console.WriteLine(result);
            
            if(args.Length > 0) 
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
