#nullable disable

using System.Collections.Generic;

namespace AvaloniaTest.Models
{
    public class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

    }
}
