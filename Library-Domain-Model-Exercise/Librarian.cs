using System;
using System.Collections;
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
    }
}