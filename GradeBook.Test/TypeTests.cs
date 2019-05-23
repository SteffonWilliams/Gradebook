using System;
using Gradebook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradeBook.Test
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void CSharpCanPassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.AreEqual("Book 1", book1.Name);


        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            
        }

        [TestMethod]
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

        [TestMethod]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1"); 
            var book2 = GetBook("Book 2");

            Assert.AreEqual("Book 1", book1.Name);
            Assert.AreEqual("Book 2", book2.Name);
            Assert.AreNotSame(book1, book2); 

        }

        [TestMethod]
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
