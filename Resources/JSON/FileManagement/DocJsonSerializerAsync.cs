using System.Text.Json;

namespace Json.FileManagement;

public class DocJsonSerializerAsync : ISerializerAsync
{
    public async Task SerializeAsync<T>(
        T? content, 
        string? path, 
        JsonSerializerOptions? options)
    {
        ArgumentNullException.ThrowIfNull(content, nameof(content));
        ArgumentException.ThrowIfNullOrWhiteSpace(path, nameof(path));
        ArgumentNullException.ThrowIfNull(options, nameof(options));

        string? dirPath = Path.GetDirectoryName(path);

        if (dirPath is null || Directory.Exists(dirPath) == false)
        {
            throw new ArgumentException("The directory doesn't exists");
        }

        using FileStream fileStream = new(path, FileMode.Create);
        await JsonSerializer.SerializeAsync(
            utf8Json: fileStream,
            value: content,
            options: options);
    }

    public async ValueTask<T?> DeserializeAsync<T>(string? path, JsonSerializerOptions? options)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path, nameof(path));
        ArgumentNullException.ThrowIfNull(options, nameof(options));

        if (File.Exists(path) == false)
        {
            throw new IOException("The file doesn't exists");
        }

        using FileStream fileStream = new(path, FileMode.Open);
        return await JsonSerializer.DeserializeAsync<T>(
                   utf8Json: fileStream,
                   options: options);
    }
}