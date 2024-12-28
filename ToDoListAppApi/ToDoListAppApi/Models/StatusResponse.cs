using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class StatusResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
