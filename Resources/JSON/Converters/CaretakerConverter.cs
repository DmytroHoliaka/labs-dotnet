using Json.Entities;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace JSON.Converters;

public class CaretakerConverter : JsonConverter<Caretaker>
{
    public override Caretaker Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        Caretaker caretaker = new();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return caretaker;
            }

            if (reader.TokenType == JsonTokenType.PropertyName)
            {
                string? propertyName = reader.GetString();
                reader.Read();

                switch (propertyName)
                {
                    case nameof(Caretaker.Id):
                        caretaker.Id = reader.GetInt32();
                        break;
                    case nameof(Caretaker.FirstName):
                        caretaker.FirstName = reader.GetString();
                        break;
                    case nameof(Caretaker.SecondName):
                        caretaker.SecondName = reader.GetString();
                        break;
                    case nameof(Caretaker.MiddleName):
                        caretaker.MiddleName = reader.GetString();
                        break;
                    case nameof(Caretaker.EmploymentDate):
                        caretaker.EmploymentDate = reader.GetDateTime();
                        break;
                    case nameof(Caretaker.Salary):
                        caretaker.Salary = reader.GetInt32();
                        break;
                    case nameof(Caretaker.Responsibility):
                        caretaker.Responsibility = reader.GetString();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, Caretaker value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteNumber(nameof(Caretaker.Id), value.Id);
        writer.WriteString(nameof(Caretaker.FirstName), value.FirstName);
        writer.WriteString(nameof(Caretaker.SecondName), value.SecondName);
        writer.WriteString(nameof(Caretaker.MiddleName), value.MiddleName);
        writer.WriteString(nameof(Caretaker.EmploymentDate), value.EmploymentDate);
        writer.WriteNumber(nameof(Caretaker.Salary), value.Salary);
        writer.WriteString(nameof(Caretaker.Responsibility), value.Responsibility);

        writer.WriteEndObject();
    }
}