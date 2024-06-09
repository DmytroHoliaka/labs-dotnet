using System.Text.Json;

namespace Json.Execution
{
    internal class Program
    {
        public static async Task Main()
        {
            try
            {
                const string jsonDataContextFilePath 
                    = @"D:\KPI\Course #2.2\Labs .NET\Resources\JSON\bin\Debug\net8.0\DataContext.json";

                const string jsonDetailsResultsFilePath 
                    = @"D:\KPI\Course #2.2\Labs .NET\Resources\JSON\bin\Debug\net8.0\DetailResultsMinimized.json";

                const string jsonCaretakersFilePath 
                    = @"D:\KPI\Course #2.2\Labs .NET\Resources\JSON\bin\Debug\net8.0\CaretakersMinimized.json";
                
                await Facade.Execute(
                    jsonDataContextFilePath: jsonDataContextFilePath, 
                    jsonDetailsResultsFilePath: jsonDetailsResultsFilePath, 
                    jsonCaretakersFilePath: jsonCaretakersFilePath);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"[ArgumentNullException] {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"[ArgumentException] {e.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"[IOException] {e.Message}");
            }
            catch (JsonException e)
            {
                Console.WriteLine($"[JsonException] {e.Message}");
            }
        }
    }
}
