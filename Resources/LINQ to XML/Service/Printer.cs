using System.Xml;
using System.Xml.Linq;

namespace LINQ_to_XML.Service
{
    internal class Printer
    {
        public static void PrintXmlFile(string? path, Action<string>? source, string? separator = "\n")
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "Path cannot be null");
            }

            if (File.Exists(path) == false)
            {
                throw new ArgumentException("File doesn't exists", nameof(path));
            }

            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "Source delegate cannot be null");
            }

            if (separator is null)
            {
                source("*Invalid separator. Replaced with \"\\n\"*\n");
                separator = "\n";
            }

            XmlDocument doc = new();
            doc.Load(path);

            using StringWriter sw = new();
            doc.Save(sw);
            source(sw.ToString());
            source(separator);
        }

        public static void PrintXmlSummary(string? path, Action<string>? source, string? separator = "\n")
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "Path cannot be null");
            }

            if (File.Exists(path) == false)
            {
                throw new ArgumentException("File doesn't exists", nameof(path));
            }

            if (source is null)
            {
                Console.WriteLine("Handler is not specified in PrintXmlSummary method");
                return;
            }

            if (separator is null)
            {
                source("*Invalid separator. Replaced with \"\\n\"*\n");
                separator = "\n";
            }

            XDocument xDoc = XDocument.Load(path);
            XElement? xElem = xDoc.Root;

            if (xElem is not null)
            {
                foreach (XElement element in xElem.Elements())
                {
                    element.Value = "...";
                }
            }

            source(xDoc.ToString());
            source(separator);
        }

        public static void PrintSequence<T>(IEnumerable<T>? sequence, Action<string?>? source, string? separator = "\n")
        {
            if (source is null)
            {
                Console.WriteLine("Handler is not specified in PrintSequence method");
                return;
            }

            if (separator is null)
            {
                source("*Invalid separator. Replaced with \"\\n\"*\n");
                separator = "\n";
            }

            if (sequence is null || sequence.Any() == false)
            {
                source("<No data>");
                source(separator);
                return;
            }

            foreach (T item in sequence)
            {
                source(item?.ToString());
                source(separator);
            }
        }

        public static void PrintSingle<T>(T? obj, Action<string?>? source, string? separator = "\n")
        {
            if (source is null)
            {
                Console.WriteLine("Handler is not specified in PrintSingle method");
                return;
            }

            if (separator is null)
            {
                source("*Invalid separator. Replaced with \"\\n\"*\n");
                separator = "\n";
            }

            if (obj is null)
            {
                source("<No data>");
                source(separator);
                return;
            }

            source(obj.ToString());
            source(separator);

        }

        public static void PrintQueryNames(Action<string>? source)
        {
            if (source is null)
            {
                Console.WriteLine("Handler is not specified in PrintQueryNames method");
                return;
            }

            string queries =
                """
                ----------------------------- Query menu -----------------------------
                Query 1. Gets all horses of the specified breed;
                Query 2. Gets all jockeys from the specified country;
                Query 3. Gets the stadium with the longest track;
                Query 4. Gets the jockey who won the most times;
                Query 5. Gets the races that were held in the specified year;
                Query 6. Gets the jockeys who participated in the race more than once;
                Query 7. Gets caretakers who live in the specified city;
                Query 8. Gets caretakers who care for the specified horse breed;
                Query 9. Gets the horse that has the maximum speed ;
                Query 10. Gets Jockeys older than the specified number of years;
                Query 11. Gets Jockeys who have participated in a race on a horse with the specified nickname;
                Query 12. Gets the races where horses older than the specified age participated;
                Query 13. Receives caretakers who earn more than the specified amount of money;
                Query 14. Receives horses that have a vet;
                Query 15. Gets the stadium where the absolute speed record was set;
                Query 16. Gets all participants;
                Query 17. Gets all detail results;
                Query 18. Gets all jockeys;
                Query 19. Gets all addresses;
                Query 20. Gets all caretakers;
                Query 21. Gets all horses;
                Query 22. Gets all races;
                Query 23. Gets all stadiums.
                """;

            source(queries);
        }

        public static void PrintMenu(Action<string>? source)
        {
            if (source is null)
            {
                Console.WriteLine("Handler is not specified in PrintQueryNames method");
                return;
            }

            string menu =
                """
                ------------- Program menu -------------
                1. Print XML file using XmlDocument;
                2. Print XML file using XmlSerializer;
                3. Print summary XML file;
                4. Print query menu;
                5. End the program.
                """;

            source(menu);
        }
    }
}
