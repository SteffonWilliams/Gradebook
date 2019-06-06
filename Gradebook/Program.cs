using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 5 + 3;
            var book = new Book("Steffon's Gradebook");
            var done = false;

            while (true)
            {
                Console.WriteLine("Enter a grade or enter 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break; 
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }

           // var inputGrade = double.Parse(Console.ReadLine()); 
            
            

            var stats = book.ShowStatistics();
            Console.WriteLine(book.Name);
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            

        }
    }
}
