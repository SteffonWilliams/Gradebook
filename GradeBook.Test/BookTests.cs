using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gradebook;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GradeBook.Test
{
    [TestFixture]
    public class BookTests
    {
        [Test]
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
            Assert.AreEqual('B', result.Letter);
        }
    }
}
