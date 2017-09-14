using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            this.librarians = new List<Librarian>();
            this.patrons = new List<Patron>();
            this.locations = new List<Location>();
            this.books = new List<Book>();
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
            return books;
        }
    }
}