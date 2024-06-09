using Json.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace JSON.Converters;

public class DetailResultConverter : JsonConverter<DetailResult>
{
    public override DetailResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        DetailResult detailResult = new ();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return detailResult;
            }

            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                string? propertyName = reader.GetString();
                reader.Read();

                switch (propertyName)
                {
                    case nameof(DetailResult.Id):
                        detailResult.Id = reader.GetInt32();
                        break;
                    case nameof(DetailResult.Place):
                        detailResult.Place = reader.GetInt32();
                        break;
                    case nameof(DetailResult.Duration):
                        detailResult.Duration = reader.GetInt32();
                        break;
                    case nameof(DetailResult.MaxSpeed):
                        detailResult.MaxSpeed = reader.GetDouble();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, DetailResult value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber(nameof(DetailResult.Id), value.Id);
        writer.WriteNumber(nameof(DetailResult.Place), value.Place);
        writer.WriteNumber(nameof(DetailResult.Duration), value.Duration);
        writer.WriteNumber(nameof(DetailResult.MaxSpeed), value.MaxSpeed);

        writer.WriteEndObject();
    }
}