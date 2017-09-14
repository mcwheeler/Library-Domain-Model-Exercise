using System.Data.Common;

namespace Library_Domain_Model_Exercise
{
    public class Book
    {
        private string title { get; }

        private string author { get; }

        private string code { get; }

        private Location location { get; }

        public Book(string title, string author, string code, Location location)
        {
            this.title = title;
            this.author = author;
            this.code = code;
            this.location = location;
        }

        public override string ToString()
        {
            return $"Title: {title}, Author: {author}, Code: {code}, Location: {location}";
        }
    }
}