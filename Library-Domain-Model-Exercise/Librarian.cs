using System.Collections.Generic;

namespace Library_Domain_Model_Exercise
{
    public class Librarian
    {
        public string Name { get; set; }

        public Librarian(string name)
        {
            Name = name;
        }

        public void AddStagingLocation(Library library, string locatedAt)
        {
            library.AddLocation(new Location("Staging", LocationType.Staging, null, locatedAt));
        }

        public void AddStack(Library library, string name, List<string> deweyDecimalRange, string locatedAt)
        {
            library.AddLocation(new Location(name, LocationType.Stack, deweyDecimalRange, locatedAt));
        }
    }
}