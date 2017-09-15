using System;
using System.Collections.Generic;
using System.Linq;

namespace Library_Domain_Model_Exercise
{
    public class Library
    {
        public string Name { get; set; }

        private IList<Book> books { get; }

        private IList<Location> locations { get; }

        private IList<Librarian> librarians { get; }

        private IList<Patron> patrons { get; }

        public Library(string name)
        {
            Name = name;
            librarians = new List<Librarian>();
            patrons = new List<Patron>();
            locations = new List<Location>();
            books = new List<Book>();
        }

        public void AddLibrarian(Librarian librarian)
        {
            librarians.Add(librarian);
        }
        public void AddLocation(Location location)
        {
            locations.Add(location);
        }

        public Location GetLocation(string name)
        {
            var location = locations.FirstOrDefault(x => x.Name == name);

            if (location == null)
            {
                throw new Exception("Location Not Found");
            }

            return location;
        }

        public void AddNewBook(Book book)
        {
            books.Add(book);
        }

        public IList<Book> GetBooksInStaging()
        {
            var returnValue = new List<Book>();

            foreach (var book in books)
            {
                if (book.Location.IsStaging())
                {
                    returnValue.Add(book);
                }
            }

            return returnValue;
        }

        public void ShelveBooksInStaging()
        {
            foreach (var book in GetBooksInStaging())
            {
                foreach (var location in locations)
                {
                    var deweyDecimalRange = location.GetDeweyDecimalRange();
                    if (deweyDecimalRange.Contains(book.Code))
                    {
                        book.Location = location;
                        break;
                    }
                }
            }
        }

        public IList<Book> GetAllBooks()
        {
            return books;
        }
    }
}