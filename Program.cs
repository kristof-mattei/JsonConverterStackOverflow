using System;
using System.Text.Json;
using System.Collections.Generic;

namespace JsonConverterStackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.Converters.Add(new ObjectConverter());

            Dictionary<string, object> input = new Dictionary<string, object> {
                { "monkey", "donkey" },
                { "ponkey", DateTime.Now },
                { "wonkey", 1337 }
            };

            string serial = JsonSerializer.Serialize(input, options);
            
            Dictionary<string, object> restore = JsonSerializer.Deserialize<Dictionary<string, object>>(serial, options);
        }
    }
}
