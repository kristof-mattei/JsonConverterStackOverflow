using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverterStackOverflow
{
    public class ObjectConverter : JsonConverter<object>
    {
        public override object Read(ref Utf8JsonReader reader,
                                    Type typeToConvert,
                                    JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32();
            }

            return reader.GetString();
        }

        public override void Write(Utf8JsonWriter writer,
                                   object value,
                                   JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }

}