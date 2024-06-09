using System.Text.Json;
using Json.Service;

namespace Json.FileManagement;

public static class ObjectSerializer
{
    public static string Serialize(object? data)
    {
        ArgumentNullException.ThrowIfNull(data, nameof(data));

        return JsonSerializer.Serialize(
            value: data, 
            options: JsonSerializerOptionsWrapper.GetPreserveOptions());
    }
}