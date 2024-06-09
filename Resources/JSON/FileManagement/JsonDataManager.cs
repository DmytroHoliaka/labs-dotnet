using System.Text.Json;
using System.Text.Json.Nodes;
using Json.Service;

namespace Json.FileManagement;

public static class JsonDataManager
{
    public static async Task<double> GetMaxSpeed(string? jsonResultsFilePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonResultsFilePath, nameof(jsonResultsFilePath));

        if (File.Exists(jsonResultsFilePath) == false)
        {
            throw new IOException("The file doesn't exists");
        }

        if (Validator.IsExtensionCorrect(path: jsonResultsFilePath, extension: ".json") == false)
        {
            throw new IOException("The file have incorrect extension");
        }

        double maxSpeed = double.MinValue;
        ISerializerAsync serializer = new DocJsonSerializerAsync();

        using (JsonDocument? doc = await serializer.DeserializeAsync<JsonDocument>(
                   path: jsonResultsFilePath,
                   options: JsonSerializerOptionsWrapper.GetMinimizedDetailResultsOptions()))
        {
            if (doc is null)
            {
                throw new JsonException("Incorrect json structure");
            }

            JsonElement root = doc.RootElement;

            if (root.ValueKind != JsonValueKind.Array)
            {
                throw new JsonException("Incorrect json structure");
            }

            foreach (JsonElement element in doc.RootElement.EnumerateArray())
            {
                if (element.TryGetProperty("MaxSpeed", out JsonElement speedElement) == false)
                {
                    throw new JsonException("Incorrect json structure");
                }

                if (speedElement.TryGetDouble(out double currSpeed) == false)
                {
                    throw new JsonException("Incorrect json structure");
                }
                
                if (currSpeed > maxSpeed)
                {
                    maxSpeed = currSpeed;
                }
            }
        }

        return maxSpeed;
    }

    public static async Task<int> GetTotalCaretakerSalaries(string? jsonCaretakersFilePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(jsonCaretakersFilePath, nameof(jsonCaretakersFilePath));

        if (File.Exists(jsonCaretakersFilePath) == false)
        {
            throw new IOException("The file doesn't exists");
        }

        if (Validator.IsExtensionCorrect(path: jsonCaretakersFilePath, extension: ".json") == false)
        {
            throw new IOException("The file have incorrect extension");
        }

        int totalSum = 0;
        ISerializerAsync serializer = new DocJsonSerializerAsync();

        JsonNode? root = await serializer.DeserializeAsync<JsonNode>(
                path: jsonCaretakersFilePath,
                options: JsonSerializerOptionsWrapper.GetMinimizedCaretakersOptions()) 
            ?? throw new JsonException("Incorrect json structure");

        if (root.GetValueKind() != JsonValueKind.Array)
        {
            throw new JsonException("Incorrect json structure");
        }

        foreach (JsonNode? jsonNode in root.AsArray())
        {
            if (jsonNode?["Salary"] is not { } node)
            {
                throw new JsonException("Incorrect json structure");
            }

            totalSum += (int)node;
        }

        return totalSum;
    }
}