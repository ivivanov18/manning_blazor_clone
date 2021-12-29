using System.Text.Json.Serialization;

namespace Manning_Blazor_Clone.Models
{
    public class BestSeller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("meap")]
        public bool IsMeap { get; set; }
        public string Category { get; set; }
        [JsonPropertyName("link")]
        public string BookDetailUrlPage { get; set; }
    }
}
