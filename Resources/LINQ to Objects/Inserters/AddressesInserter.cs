using LINQ_to_Objects.Entities;
using System.ComponentModel;

namespace LINQ_to_Objects.Inserters
{
    internal class AddressesInserter
    {
        public static void InsertAddresses(List<Address>? addresses)
        {
            if (addresses is null)
            {
                throw new ArgumentNullException(nameof(addresses), "Input list of addresses cannot be null");
            }

            Address address1 = new()
            {
                Id = 1,
                Country = "USA",
                City = "New York",
                Area = "Manhattan",
                District = "Financial District",
                PostalCode = "10005",
                Street = "Wall Street",
                BuildingNumber = 5
            };

            Address address2 = new()
            {
                Id = 2,
                Country = "France",
                City = "Paris",
                Area = "Île-de-France",
                District = "7th arrondissement",
                PostalCode = "75007",
                Street = "Rue de Grenelle",
                BuildingNumber = 57
            };

            Address address3 = new()
            {
                Id = 3,
                Country = "Japan",
                City = "Tokyo",
                Area = "Kanto",
                District = "Shibuya",
                PostalCode = "150-0002",
                Street = "Meiji-jingumae",
                BuildingNumber = 1
            };

            Address address4 = new()
            {
                Id = 4,
                Country = "United Kingdom",
                City = "London",
                Area = "Greater London",
                District = "Westminster",
                PostalCode = "SW1A 1AA",
                Street = "Downing Street",
                BuildingNumber = 10
            };

            Address address5 = new()
            {
                Id = 5,
                Country = "Australia",
                City = "Sydney",
                Area = "New South Wales",
                District = "Central Business District",
                PostalCode = "2000",
                Street = "George Street",
                BuildingNumber = 100
            };

            Address address6 = new()
            {
                Id = 6,
                Country = "Germany",
                City = "Berlin",
                Area = "Brandenburg",
                District = "Mitte",
                PostalCode = "10117",
                Street = "Unter den Linden",
                BuildingNumber = 76
            };

            Address address7 = new()
            {
                Id = 7,
                Country = "USA",
                City = "New York",
                Area = "New York State",
                District = "Manhattan",
                PostalCode = "10001",
                Street = "8th Avenue",
                BuildingNumber = 300
            };

            Address address8 = new()
            {
                Id = 8,
                Country = "Italy",
                City = "Rome",
                Area = "Lazio",
                District = "Trastevere",
                PostalCode = "00153",
                Street = "Via della Scala",
                BuildingNumber = 45
            };

            Address address9 = new()
            {
                Id = 9,
                Country = "Canada",
                City = "Toronto",
                Area = "Ontario",
                District = "Downtown",
                PostalCode = "M5H 2N2",
                Street = "Bay Street",
                BuildingNumber = 200
            };

            Address address10 = new()
            {
                Id = 10,
                Country = "Spain",
                City = "Barcelona",
                Area = "Catalonia",
                District = "Eixample",
                PostalCode = "08007",
                Street = "Passeig de Gràcia",
                BuildingNumber = 92
            };

            Address address11 = new()
            {
                Id = 11,
                Country = "Italy",
                City = "Rome",
                Area = "Lazio",
                District = "Trastevere",
                PostalCode = "22070-010",
                Street = "Avenida Atlântica",
                BuildingNumber = 1702
            };

            addresses.AddRange(new List<Address>
            {
                address1,
                address2,
                address3,
                address4,
                address5,
                address6,
                address7,
                address8,
                address9,
                address10,
                address11,
            });
        }
    }
}
