using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gradebook;

namespace GradeBook.Test
{
    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void TestStatistics()
        {
            //Given 
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.3);

            //When
            var result = book.ShowStatistics(); 


            //Then
            Assert.AreEqual(85.5,result.Average);
            Assert.AreEqual(90.1, result.High);
            Assert.AreEqual(77.3, result.Low); 
        }
    }
}
