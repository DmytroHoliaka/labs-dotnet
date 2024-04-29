using System.Text.Json;
using System.Text.Json.Serialization;
using JSON.Converters;

namespace Json.Service;

public static class JsonSerializerOptionsWrapper
{
    public static JsonSerializerOptions GetPreserveOptions()
    {
        return new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.Preserve,
            WriteIndented = true,
        };
    }

    public static JsonSerializerOptions GetMinimizedDetailResultsOptions()
    {
        return new JsonSerializerOptions()
        {
            Converters = { new DetailResultConverter() },
            WriteIndented = true,
        };
    }
    
    public static JsonSerializerOptions GetMinimizedCaretakersOptions()
    {
        return new JsonSerializerOptions()
        {
            Converters = { new CaretakerConverter() },
            WriteIndented = true,
        };
    }
}