using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {
        private List<double> grades = new List<double>();
        private string name;
        public Book(string name){
            grades = new List<double>();
            this.name = name; 
        }

      

        public void ShowStatistics()
        {

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {

                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
                // Console.WriteLine(result);
            }

            result = result / grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");

        }

        public void AddGrade(double grade)
        {
            this.grades.Add(grade);
        }


    }
}
