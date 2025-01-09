using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class AssignmentRequest
    {
        //[JsonPropertyName("id")]
        //public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("statusId")]
        public int StatusId { get; set; }
    }
}
