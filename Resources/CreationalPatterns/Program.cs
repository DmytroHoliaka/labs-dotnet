namespace CreationalPatterns
{
    public abstract class Program
    {
        public static void Main()
        {
            const string jsonName = "filters.json";
            const string basePath = "";

            Facade.Execute(jsonName, basePath);
        }
    }
}