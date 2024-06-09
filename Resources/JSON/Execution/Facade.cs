using Json.DataCollector;
using Json.FileManagement;
using Json.Service;

namespace Json.Execution
{
    internal class Facade
    {
        public static async Task Execute(
            string? jsonDataContextFilePath,
            string? jsonDetailsResultsFilePath,
            string? jsonCaretakersFilePath)
        {
            DataContext dataContext = GetInitializedDataContext();

            ConsoleKeyInfo keyInfo = GetUserInput();
            await HandleUserInput(
                jsonDataContextFilePath: jsonDataContextFilePath,
                jsonDetailsResultsFilePath: jsonDetailsResultsFilePath,
                jsonCaretakersFilePath: jsonCaretakersFilePath,
                keyInfo: keyInfo,
                dataContext: dataContext
            );
        }

        private static DataContext GetInitializedDataContext()
        {
            DataContext dataContext = new();
            InsertManager.InsertData(dataContext);
            RelationshipManager.Configure(dataContext);

            return dataContext;
        }

        private static ConsoleKeyInfo GetUserInput()
        {
            Printer.PrintMenu();
            Console.Write("\nEnter your choice: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            return keyInfo;
        }

        private static async Task HandleUserInput(
            string? jsonDataContextFilePath,
            string? jsonDetailsResultsFilePath,
            string? jsonCaretakersFilePath,
            ConsoleKeyInfo keyInfo,
            DataContext dataContext)
        {
            ISerializerAsync serializer = new DocJsonSerializerAsync();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    await serializer.SerializeAsync(
                        content: dataContext,
                        path: jsonDataContextFilePath,
                        options: JsonSerializerOptionsWrapper.GetPreserveOptions());

                    Console.WriteLine("File successfully created");
                    break;

                case ConsoleKey.D2:
                    DataContext? context = await serializer.DeserializeAsync<DataContext>(
                        path: jsonDataContextFilePath,
                        options: JsonSerializerOptionsWrapper.GetPreserveOptions());

                    Console.WriteLine(context);
                    break;

                case ConsoleKey.D3:
                    await serializer.SerializeAsync(
                        content: dataContext.DetailResults,
                        path: jsonDetailsResultsFilePath,
                        options: JsonSerializerOptionsWrapper.GetMinimizedDetailResultsOptions());

                    double maxSpeed = await JsonDataManager.GetMaxSpeed(jsonDetailsResultsFilePath);
                    Console.WriteLine($"Max speed: {maxSpeed}");
                    break;

                case ConsoleKey.D4:
                    await serializer.SerializeAsync(
                        content: dataContext.Caretakers,
                        path: jsonCaretakersFilePath,
                        options: JsonSerializerOptionsWrapper.GetMinimizedCaretakersOptions());

                    int salarySum = await JsonDataManager.GetTotalCaretakerSalaries(jsonCaretakersFilePath);
                    Console.WriteLine($"Sum: {salarySum}");
                    break;

                default:
                    Console.WriteLine("Entered incorrect key. Restart program and try again.");
                    break;
            }
        }
    }
}