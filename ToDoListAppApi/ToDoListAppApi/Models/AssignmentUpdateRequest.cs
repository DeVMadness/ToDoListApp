using System.Text.Json.Serialization;

namespace WebApi.Models
{
    public class AssignmentUpdateRequest : AssignmentRequest
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
