namespace Library_Domain_Model_Exercise
{
    public class Book
    {
        private string title { get; }

        private string author { get; }

        public string Code { get; }

        public Location Location { get; set; }

        public Book(string title, string author, string code, Location location)
        {
            this.title = title;
            this.author = author;
            Code = code;
            Location = location;
        }

        public override string ToString()
        {
            return $"Title: {title}, Author: {author}, Code: {Code}, Location: {Location}";
        }
    }
}