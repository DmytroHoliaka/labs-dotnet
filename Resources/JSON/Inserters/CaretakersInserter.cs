using Json.Entities;

namespace Json.Inserters
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
