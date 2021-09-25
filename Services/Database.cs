using AvaloniaTest.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AvaloniaTest.Services
{
    public class Database
    {
        public static IEnumerable<Country> GetCountries() => new[]
        {
            new Country { CountryId = 1, Name = "Belgium" },
            new Country { CountryId = 2, Name = "France" },
            new Country { CountryId = 3, Name = "The Netherlands" },
            new Country { CountryId = 4, Name = "United Kingdom" },
            new Country { CountryId = 5, Name = "United States" }
        };

        public static IEnumerable<City> GetCities() => new[]
        {
            new City { CityId = 1, Name = "Antwerp", CountryId = 1 },
            new City { CityId = 2, Name = "Brussels", CountryId = 1 },
            new City { CityId = 3, Name = "Paris" , CountryId = 2 },
            new City { CityId = 4, Name = "Amsterdam", CountryId = 3},
            new City { CityId = 5, Name = "Utrecht", CountryId = 3},
            new City { CityId = 6, Name = "London", CountryId = 4 }
        };

        public static ObservableCollection<Country> GetCountryList()
        {
            var collection = new ObservableCollection<Country>
            {
                new Country { Name = "Austria" },
                new Country { Name = "Belgium",
                    Cities = new[]
                    {
                        new City { Name = "Antwerp" },
                        new City { Name = "Brussels" }
                    }
                },
                new Country { Name = "Denmark" },
                new Country { Name = "Finland",
                    Cities = new[]
                    {
                        new City { Name = "Helsinki" }
                    }
                },
                new Country { Name = "France" },
                new Country { Name = "Germany" },
                new Country { Name = "Italy",
                    Cities = new[]
                    {
                        new City { Name = "Rome" }
                    }
                },
                new Country { Name = "The Netherlands",
                    Cities = new []
                    {
                        new City { Name = "Amsterdam",
                            Streets = new []
                            {
                                new Street { Name = "Herengracht" },
                                new Street { Name = "Kalverstraat" },
                                new Street { Name = "Keizersgracht" },
                                new Street { Name = "Nieuwedijk" },
                                new Street { Name = "Prinsengracht" },
                                new Street { Name = "Singel" }
                            }
                        },
                        new City { Name = "Utrecht"}
                    }
                },
                new Country { Name = "Norway" },
                new Country { Name = "Portugal" },
                new Country { Name = "Spain" },
                new Country { Name = "Sweden" },
                new Country { Name = "Switzerland" },
                new Country { Name = "United Kingdom",
                    Cities = new[]
                    {
                        new City { Name = "London",
                            Streets = new[]
                            {
                                new Street { Name = "Millbank" },
                                new Street { Name = "Parliament Street" },
                                new Street { Name = "Trafalgar Square" }
                            }
                        }
                    }
                },
                new Country { Name = "United States", 
                    Cities = new []
                    { 
                        new City { Name = "New York",
                            Streets = new []
                            { 
                                new Street { Name = "1st Avenue" },
                                new Street { Name = "2nd Avenue" },
                                new Street { Name = "Wallstreet" }
                            }
                        }
                    }
                }
            };

            return collection;
        }
    }
}
