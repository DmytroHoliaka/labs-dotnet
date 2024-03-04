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


            addresses.AddRange(new List<Address>
            {
                address1,
                address2,
                address3,
                address4,
                address5,
                address6,
            });
        }
    }
}
