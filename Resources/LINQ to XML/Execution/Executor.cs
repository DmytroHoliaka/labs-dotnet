using LINQ_to_XML.DataCollector;
using LINQ_to_XML.FileManagement;
using LINQ_to_XML.Inserters;
using LINQ_to_XML.Service;
using System.Xml.Linq;

namespace LINQ_to_XML.Execution
{
    internal class Executor
    {
        public static void InsertData(DataContext? dataContext)
        {
            if (dataContext is null)
            {
                throw new ArgumentNullException(nameof(dataContext), "DataContext instance cannot be null");
            }

            AddressesInserter.InsertAddresses(dataContext.Addresses);
            CaretakersInserter.InsertCaretakers(dataContext.Caretakers);
            DetailResultsInserter.InsertDetailResults(dataContext.DetailResults);
            HorsesInserter.InsertHorses(dataContext.Horses);
            JockeysInserter.InsertJockeys(dataContext.Jockeys);
            ParticipantsInserter.InsertParticipants(dataContext.Participants);
            RacesInserter.InsertRaces(dataContext.Races);
            StadiumsInserter.InsertStadiums(dataContext.Stadiums);
        }

        public static void SerealizeData(DataContext? dataContext, string? path)
        {
            ISerializer serializer = new DocXmlSerializer();
            serializer.Serialize(dataContext, path);
        }

        public static void RunCycle(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path), "Path cannot be null");
            }

            if (File.Exists(path) == false)
            {
                throw new ArgumentException("File doesn't exists", nameof(path));
            }

            bool isOngoing = true;

            while (isOngoing == true)
            {
                Printer.PrintMenu(Console.WriteLine);
                Console.Write("\nMake your choice [1;5]: ");
                string? menuChoiceLine = Console.ReadLine();

                if (Validator.IsInt32(menuChoiceLine) == true)
                {
                    int menuChoice = Convert.ToInt32(menuChoiceLine);

                    switch (menuChoice)
                    {
                        case 1:
                            Printer.PrintXmlFile(path, MessageHandlers.WriteResult);
                            break;

                        case 2:
                            ISerializer serializer = new DocXmlSerializer();
                            DataContext deserializedContext = serializer.Deserialize(path);
                            MessageHandlers.WriteResult(deserializedContext.ToString());
                            break;

                        case 3:
                            Printer.PrintXmlSummary(path, MessageHandlers.WriteResult);
                            break;

                        case 4:
                            ProcessQuerySelection(path);
                            break;

                        case 5:
                            isOngoing = false;
                            break;

                        default:
                            MessageHandlers.WriteError("Incorrect input. Try again.");
                            MessageHandlers.WriteError("\n");
                            break;
                    }
                }
                else
                {
                    MessageHandlers.WriteError("Entered incorrect value. Menu choice must be an integer number.");
                    MessageHandlers.WriteError("\n");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Program was ended");
        }

        private static void ProcessQuerySelection(string path)
        {
            Console.WriteLine();
            Printer.PrintQueryNames(Console.WriteLine);

            Console.Write($"\nEnter query number [1; 23]: ");
            string? queryChoiceLine = Console.ReadLine();

            if (Validator.IsInt32(queryChoiceLine) == true)
            {
                int queryChoice = Convert.ToInt32(queryChoiceLine);
                XDocument xDoc = XDocument.Load(path);
                QueryManager queryManager = new(xDoc);

                QueryExecutor queryExecutor = new(queryManager);
                queryExecutor.InfoNotify += MessageHandlers.WriteInfo;
                queryExecutor.ResultNotify += MessageHandlers.WriteResult;
                queryExecutor.ErrorNotify += MessageHandlers.WriteError;

                queryExecutor.Execute(queryChoice);
            }
            else
            {
                MessageHandlers.WriteError("Entered incorrect value. Query choice must be an integer number.");
                MessageHandlers.WriteError("\n");
            }
        }
    }
}
