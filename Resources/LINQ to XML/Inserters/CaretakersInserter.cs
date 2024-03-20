using LINQ_to_XML.Entities;

namespace LINQ_to_XML.Inserters
{
    internal class CaretakersInserter
    {
        public static void InsertCaretakers(List<Caretaker>? caretakers)
        {
            if (caretakers is null)
            {
                throw new ArgumentNullException(nameof(caretakers), "Input list of caretakers cannot be null");
            }

            Caretaker caretaker1 = new()
            {
                Id = 1,
                FirstName = "John",
                SecondName = "Doe",
                MiddleName = "A.",
                EmploymentDate = new DateTime(2018, 5, 21),
                Salary = 5000,
                Responsibility = "Horse Training",

                AddressId = 8,
                HorseIds = [2, 3, 4]
            };

            Caretaker caretaker2 = new()
            {
                Id = 2,
                FirstName = "Alice",
                SecondName = "Johnson",
                MiddleName = "B.",
                EmploymentDate = new DateTime(2019, 8, 15),
                Salary = 3200,
                Responsibility = "Veterinary Care",

                AddressId = 9,
                HorseIds = [3, 4]
            };

            Caretaker caretaker3 = new()
            {
                Id = 3,
                FirstName = "Mark",
                SecondName = "Smith",
                MiddleName = "C.",
                EmploymentDate = new DateTime(2020, 1, 10),
                Salary = 1600,
                Responsibility = "Nutrition Planning",

                AddressId = 10,
                HorseIds = [2]
            };

            Caretaker caretaker4 = new()
            {
                Id = 4,
                FirstName = "Emily",
                SecondName = "White",
                MiddleName = "D.",
                EmploymentDate = new DateTime(2021, 11, 29),
                Salary = 3400,
                Responsibility = "General Maintenance",

                AddressId = 11,
                HorseIds = [1, 3]
            };

            caretakers.AddRange(new List<Caretaker>()
            {
                caretaker1,
                caretaker2,
                caretaker3,
                caretaker4,
            });
        }
    }
}
