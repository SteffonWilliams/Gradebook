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

        public void AddLetterGrade(char letter)
        {
//            if (letter == 'A')
//            {
//                AddGrade((90));
//            }
//            else if(letter == 'B')
//            {
//                AddGrade(80);   
//            }
                
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                
                case 'B':
                    AddGrade(80);
                    break;
                
                case 'C':
                    AddGrade(70);
                    break; 
                
                default:
                    AddGrade(0);
                    break; 
            }
            
        }
        

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);  
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");  
            }
        }
        
        public Statistics ShowStatistics()
        {

            var result = new Statistics();
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            result.Average = 0.0; 


            //foreach (var number in grades)
//            var index = 0;
//            while (index < grades.Count)
            for(var  i = 0; i <= grades.Count-1; i++)
            {
//                if (grades[i] == 42.1)
//                {
//                    continue; 
//                }
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
               // index++; 

            } 
            
            
            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var d when d > 90.0:
                    result.Letter = 'A'; 
                    break; 
                
                case var d when d > 80.0:
                    result.Letter = 'B'; 
                    break; 
                
                case var d when d > 70.0:
                    result.Letter = 'C'; 
                    break; 
                
                case var d when d > 60.0:
                    result.Letter = 'D'; 
                    break; 
                
                default:
                    result.Letter = 'F';
                    break; 
                    
            }
          
            return result; 
        }

    
    }
}
