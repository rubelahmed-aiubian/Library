using System;
using System.Linq;

namespace Lib
{
    public class Library : Book
    {
        private string libName { get; set; }

        private string libAddress { get; set; }

        private int totalBook { get; set; }

        private Book[] listOfBook { get; set; }

        public Library()
        {
        }

        public Library(string libName, string libAddress, int totalBook, Book[] books)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            this.listOfBook = books;
        }

        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: "+this.libName+"\nLibrary Address: "+this.libAddress+"\nTotal Book: {0}",this.totalBook);
            listOfBook[0].ShowInfo();
        }

        public void AddNewBook(Book book)
        {
            this.listOfBook?.ToList().Add(book);
        }

        public void DeleteBook(Book book)
        {
            this.listOfBook?.ToList().Remove(book);
        }

        public void AddNewBookCopy(Book book, int copy) 
        {
            
        }
    }
}