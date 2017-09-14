using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Domain_Model_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add a stack to the library called Staging.
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

            var booksInStaging = library.GetBooksInStaging();

            foreach (var book in booksInStaging)
            {
                Console.WriteLine(book.ToString());
            }

            Console.ReadKey();
        }
    }
}
