using LINQ_to_Objects.Execution;

namespace LINQ_to_XML.Execution
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                string path = "data.xml";
                Facade.Execute(path);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
