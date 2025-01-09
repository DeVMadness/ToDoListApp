using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class StatusRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
