using System.Text.Json;
using System.Text.Json.Serialization;

namespace exam_blazor_wasm.Models;


    public class ApiName
    {
        public string Title { get; set; } = string.Empty;
        public string First { get; set; } = string.Empty;
        public string Last { get; set; } = string.Empty;
    }

    public class ApiLocation
    {
        public ApiStreet Street { get; set; } = new();
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        [JsonConverter(typeof(StringConverter))]
        public string Postcode { get; set; } = string.Empty;
    }

    public class ApiStreet
    {
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class ApiDob
    {
        public int Age { get; set; }
    }

    public class ApiRegistered
    {
        public DateTime Date { get; set; }
    }

    public class ApiPicture
    {
        public string Large { get; set; } = string.Empty;
        public string Medium { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
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
