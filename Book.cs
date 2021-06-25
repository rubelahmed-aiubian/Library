using System;
namespace Lib
{
    public class Book
    {
        static int bookCounter=0;

        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        //empty constructor
        public Book()
        {

        }

        //valued constructor
        public Book(string bn, string au, string bid, string bty, int cp)
        {
            Name = bn;
            Author = au;
            Id = bid;
            Type = bty;
            Copy = cp;
            bookCounter = cp;
        }

        //properties
        public string Name
        {
            get
            {
                return bookName;
            }
            set
            {
                bookName = value;
            }
        }

        public string Author
        {
            get
            {
                return bookAuthor;
            }
            set
            {
                bookAuthor = value;
            }
        }

        public string Id
        {
            get
            {
                return bookId;
            }
            set
            {
                bookId = value;
            }
        }

        public string Type
        {
            get
            {
                return bookType;
            }
            set
            {
                bookType = value;
            }
        }

        public int Copy
        {
            get
            {
                return bookCopy;
            }
            set
            {
                bookCopy = value;
            }
        }

        //showinfo
        public void ShowInfo()
        {
            Console.WriteLine("\n---------------- Book Information ----------------\n");
            Console.WriteLine("Book Name: "+Name+ "\nBook Author: "+Author+ "\nBook Id: "+Id+ "\nBook Type: "+Type+ "\nBook Copy: {0}",Copy);
            Console.WriteLine("\n================ Book Management=================\n");
        }

        public void AddBookCopy(int x)
        {
            Console.WriteLine("\n---------------Currently There Are {0} Books-------------\n",Copy);

            Copy = Copy + x;

            bookCounter = Copy;

            Console.WriteLine("\nAfter Adding Book Copy, => Total Book Copy: {0}\n",Copy);

            Console.WriteLine("\n---------------- Book Copy Added ----------------\n");

        }

        //total book info
        public static void showTotalBookInfo()
        {
            Console.WriteLine("\nTotal Book: {0}\n",bookCounter);
            Console.WriteLine("\n---------------- Program End ----------------\n");
        }
    }
}