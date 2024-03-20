using LINQ_to_Objects.Entities;

namespace LINQ_to_Objects.Inserters
{
    internal class JockeysInserter
    {
        public static void InsertJockeys(List<Jockey>? jockeys)
        {
            if (jockeys is null)
            {
                throw new ArgumentNullException(nameof(jockeys), "Input list of jockeys cannot be null");
            }

            Jockey jockey1 = new()
            {
                Id = 1,
                FirstName = "John",
                SecondName = "Doe",
                MiddleName = "A.",
                Pseudonym = "Lightning",
                BirthDate = new DateTime(1985, 3, 15),
                AddressId = 1
            };

            Jockey jockey2 = new()
            {
                Id = 2,
                FirstName = "Emily",
                SecondName = "Clark",
                MiddleName = "B.",
                Pseudonym = "Thunder",
                BirthDate = new DateTime(1990, 7, 22),
                AddressId = 2
            };

            Jockey jockey3 = new()
            {
                Id = 3,
                FirstName = "Michael",
                SecondName = "Brown",
                MiddleName = "C.",
                Pseudonym = "Storm",
                BirthDate = new DateTime(1988, 11, 9),
                AddressId = 3
            };

            Jockey jockey4 = new()
            {
                Id = 4,
                FirstName = "Sophia",
                SecondName = "Johnson",
                MiddleName = "D.",
                Pseudonym = "Blaze",
                BirthDate = new DateTime(1992, 5, 16),
                AddressId = 4
            };

            Jockey jockey5 = new()
            {
                Id = 5,
                FirstName = "Alex",
                SecondName = "Johnson",
                MiddleName = "M.",
                Pseudonym = "Lightning Rider",
                BirthDate = new DateTime(1985, 6, 15), 
                AddressId = 5
            };


            jockeys.AddRange(new List<Jockey>()
            {
                jockey1,
                jockey2,
                jockey3,
                jockey4,
                jockey5,
            });
        }
    }
}
