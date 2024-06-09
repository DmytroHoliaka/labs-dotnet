using System.Text.Json;

namespace Json.FileManagement
{
    internal interface ISerializerAsync
    {
        Task SerializeAsync<T>(T? content, string? path, JsonSerializerOptions? options);
        ValueTask<T?> DeserializeAsync<T>(string? path, JsonSerializerOptions? options);
    }
}
