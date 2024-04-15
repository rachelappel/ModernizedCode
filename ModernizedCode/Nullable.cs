#nullable enable

namespace ModernizedCode
{
    public class LocationInfo
    {
        public string Country { get; set; }
        public string Location { get; set; }

        public LocationInfo(string country, string location)
        {
            Country = country;
            Location = location;
            var s = "";
            if (s == null) throw new ArgumentNullException(nameof(s));
        }
    }

    class Student
    {
        public string? Name { get; set; }

        void register(string name)
        {
            var x = name.Length;
        }
    }
}