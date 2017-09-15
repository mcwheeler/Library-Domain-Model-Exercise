using System;
using System.Collections.Generic;

namespace Library_Domain_Model_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library("Wheeler's Library");
            var librarian = new Librarian("Amy Wheeler");
            library.AddLibrarian(librarian);
            librarian.AddStagingLocation(library, "Downstairs");

            // Add five books to your library 
            var stagingLocation = library.GetLocation("Staging");
            library.AddNewBook(new Book("Book One", "Author One", "AAA", stagingLocation));
            library.AddNewBook(new Book("Book Two", "Author Two", "BBB", stagingLocation));
            library.AddNewBook(new Book("Book Three", "Author Three", "CCC", stagingLocation));
            library.AddNewBook(new Book("Book Four", "Author Four", "DDD", stagingLocation));
            library.AddNewBook(new Book("Book Five", "Author Five", "EEE", stagingLocation));

            OutputBooksInStaging(library.GetBooksInStaging());

            var stack1Range = new List<string>(new[] { "AAA", "BBB", "CCC" });
            var stack2Range = new List<string>(new[] { "DDD", "EEE", "FFF" });

            librarian.AddStack(library, "Stack 1", stack1Range, "Upstairs");
            librarian.AddStack(library, "Stack 2", stack2Range, "Downstairs");

            library.ShelveBooksInStaging();

            OutputBooksInStaging(library.GetBooksInStaging());

            OutputAllBooks(library.GetAllBooks());

            Console.ReadKey();
        }

        public static void OutputBooksInStaging(IList<Book> booksInStaging)
        {
            if (booksInStaging.Count > 0)
            {
                Console.WriteLine($"There are {booksInStaging.Count} books in staging. They are:");

                foreach (var book in booksInStaging)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are 0 books in staging.");
            }
        }

        public static void OutputAllBooks(IList<Book> books)
        {
            if (books.Count > 0)
            {
                Console.WriteLine($"There are {books.Count} books in library. They are:");

                foreach (var book in books)
                {
                    Console.WriteLine(book.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are 0 books in the library.");
            }
        }
    }
}
