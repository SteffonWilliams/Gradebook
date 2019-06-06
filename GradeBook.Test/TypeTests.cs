using System;
using Gradebook;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GradeBook.Test
{
    [TestFixture]
    public class TypeTests
    {

        [Test]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x); 
            Assert.AreEqual(42,x);
        }

        private void SetInt(ref int x)
        {
            x = 42; 
        }

        private int GetInt()
        {
            return 3; 
        }
        
        [Test]
        public void CSharpCanPassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "Book 1");

            Assert.AreEqual("Book 1", book1.Name);


        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            
        }

        [Test]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name");

            Assert.AreEqual("New Name", book1.Name);
           

        }

        private void SetName(Book book1, string name)
        {
            book1.Name = name; 
        }

        [Test]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1"); 
            var book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
            Assert.AreNotSame(book1, book2); 

        }

        [Test]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;  ;

            Assert.AreSame(book1, book2);
            Assert.IsTrue(Object.ReferenceEquals(book1, book1));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
