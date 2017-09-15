using System.Collections.Generic;
using System.Text;

namespace Library_Domain_Model_Exercise
{
    public class Location
    {
        public string Name { get; }

        private int type { get; }

        private IList<string> deweyDecimalRange{ get; }

        private string locatedAt { get; }

        public Location(string name, LocationType type, List<string> deweyDecimalRange, string locatedAt)
        {
            Name = name;
            this.type = (int)type;
            this.deweyDecimalRange = deweyDecimalRange;
            this.locatedAt = locatedAt;
        }

        public string GetDeweyDecimalRange()
        {
            if (deweyDecimalRange != null && deweyDecimalRange.Count > 0)
            {
                StringBuilder returnValue = new StringBuilder();

                foreach (var deweyDecimal in deweyDecimalRange)
                {
                    returnValue.Append(deweyDecimal + ",");
                }

                return returnValue.ToString();
            }

            return "No Dewey Decimal Range,";
        }

        public bool IsStaging()
        {
            return type == (int)LocationType.Staging;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {(LocationType)type}, Dewey Decimal Range: {GetDeweyDecimalRange()} Located At: {locatedAt}";
        }
    }
}