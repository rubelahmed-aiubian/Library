using System;

namespace Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n================ Library Management=================\n");

            string l_Name;
            string l_Add;
            int Q;

            Console.WriteLine("Enter Library Name: ");
            l_Name = Console.ReadLine();
            Console.WriteLine("Enter Library Address: ");
            l_Add = Console.ReadLine();
            Console.WriteLine("Enter Library's Total Book: ");
            Q = Convert.ToInt16(Console.ReadLine());

            Book []listOfBook = new Book[Q];

            string bn,au,id,ty;
            int cp;

            for(int i= 1; i<=Q; ++i)
            {
                Console.WriteLine("Enter Book Name For Book No {0}:",i);
                bn= Console.ReadLine();

                Console.WriteLine("Enter Book Author For Book No {0}:",i);
                au = Console.ReadLine();

                Console.WriteLine("Enter Book ID For Book No {0}:",i);
                id = Console.ReadLine();

                Console.WriteLine("Enter Book Type For Book No {0}:",i);
                ty = Console.ReadLine();

                Console.WriteLine("Enter How Many Book For Book No {0}:",i);
                cp = Convert.ToInt16(Console.ReadLine());
                

                //object call
                listOfBook[i] = new Book(bn,au,id,ty,cp);


            }



            Library myLibrary = new Library(l_Name, l_Add, Q, listOfBook);
            myLibrary.ShowLibInfo();
            myLibrary.AddBookCopy();
            myLibrary.DeleteBook();

        }
    }
}
