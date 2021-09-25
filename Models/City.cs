using System.Collections.Generic;

namespace AvaloniaTest.Models
{
    public class City
    {
        public City()
        {
            Streets = new HashSet<Street>();
        }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<Street> Streets { get; set; }
    }
}
