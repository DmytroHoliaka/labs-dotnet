namespace LINQ_to_XML.Service
{
    internal class MessageHandlers
    {
        public static void WriteInfo(string? line)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (line is null)
            {
                Console.Write("<No data>");
            }
            else
            {
                Console.Write(line);
            }

            Console.ResetColor();
        }

        public static void WriteResult(string? line)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (line is null)
            {
                Console.Write("<No data>");
            }
            else
            {
                Console.Write(line);
            }

            Console.ResetColor();
        }

        public static void WriteError(string? line)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            if (line is null)
            {
                Console.Write("<No data>");
            }
            else
            {
                Console.Write(line);
            }

            Console.ResetColor();
        }
    }
}
