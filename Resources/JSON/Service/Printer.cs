namespace Json.Service;

public static class Printer
{
    public static void PrintMenu()
    {
        Console.WriteLine(
            """
            ---------- Application menu ----------
            1. Serialize the data context;
            2. Deserialize the data context;
            3. Find the maximum speed on the race (JsonDocument);
            4. Find the sum of all the salaries of the caretakers (JsonNode).
            """);
    }
}