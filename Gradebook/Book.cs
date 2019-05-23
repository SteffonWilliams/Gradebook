using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
   public class Book
    {

        private List<double> grades = new List<double>();
        public string Name; 
        public Book(string name)
        {
            grades = new List<double>();
            Name = name; 
        }

        public Statistics ShowStatistics()
        {

            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            result.Average = 0.0; 


            foreach (var number in grades)
            {
                result.High = Math.Max(number, result.High);
                result.Low = Math.Min(number, result.Low);
                result.Average += number;

            }
            result.Average /= grades.Count;
          
            return result; 
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade); 
            
        }
    }
}
