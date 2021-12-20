using System.Text.Json;
using System.Text.Json.Serialization;

namespace One.Core.Json
{
    public class JsonHelper
    {
        public static T Deserialize<T>(string value)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            options.Converters.Add(new JsonStringEnumConverter());

            return JsonSerializer.Deserialize<T>(value, options);
        }
    }
}
