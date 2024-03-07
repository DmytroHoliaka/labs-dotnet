using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_Objects.Service
{
    internal class Printer
    {
        public static void PrintList<T>(List<T>? values)
        {
            Console.WriteLine();

            if (values is null)
            {
                Console.WriteLine("Input list is null");
                return;
            }

            if (values.Count == 0)
            {
                Console.WriteLine("<no data>");
            }
            else
            {
                foreach (T value in values)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public static void PrintMenu()
        {
            string menu =
                """
                1. A summary of all horses in descending order of age;
                2. Addresses from the United States with an odd house number;
                3. Jockeys who live in the specified country;
                4. All caretakers who care for more than one horse;
                5. Horses that have won more than once;
                6. Horses that have participated in races;
                7. Horses that have not participated in a race;
                8. Jockeys older than the number of years specified by the user;
                9. A horse with a record top speed;
                10. All jockeys and horses by combining the corresponding pairs;
                11. The stadium with the longest track;
                12. The caretaker who lives in the specified country and earns more than the specified amount of money;
                13. Races that took place at a stadium in the specified country;
                14. Horses that have a trainer;
                15. Jockeys whose name ends in a vowel in descending order of age;
                16. Caretakers who look after the specified breed of horse;
                17. The races in which the specified horses participated by nickname;
                18. The horses in which the jockey with the specified ID participated;
                19. The jockey who took the first place the most times;
                20. Jockeys who participated in the stadium of the specified country.
                """;

            Console.WriteLine(menu);
        }
    }
}
