using System.Text.Json;
using System.Text.Json.Serialization;

namespace exam_blazor_wasm.Models;

public class ApiName
{
    public string Title { get; init; } = string.Empty;
    public string First { get; init; } = string.Empty;
    public string Last { get; init; } = string.Empty;
}

public class ApiLocation
{
    public ApiStreet Street { get; init; } = new();
    public string City { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
    public string Country { get; init; } = string.Empty;
    
}

public class ApiStreet
{
    public int Number { get; init; }
    public string Name { get; init; } = string.Empty;
}

public class ApiDob
{
    public int Age { get; init; }
}

public class ApiRegistered
{
    public DateTime Date { get; init; }
}

public class ApiLogin
{
    public string Uuid { get; init; } = string.Empty;
}

public class ApiPicture
{
    public string Large { get; init; } = string.Empty;
    public string Thumbnail { get; init; } = string.Empty;
}

public class StringConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader,
        Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Number
            ? reader.GetInt64().ToString()
            : reader.GetString() ?? string.Empty;
    }

    public override void Write(Utf8JsonWriter writer, string value,
        JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}
