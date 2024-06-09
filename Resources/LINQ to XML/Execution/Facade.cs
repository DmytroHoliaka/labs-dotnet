using LINQ_to_XML.DataCollector;
using LINQ_to_XML.Execution;

namespace LINQ_to_Objects.Execution
{
    internal class Facade
    {
        public static void Execute(string? path)
        {
            DataContext data = new();
            Executor.InsertData(data);
            Executor.SerealizeData(data, path);
            Executor.RunCycle(path);
        }
    }
}
