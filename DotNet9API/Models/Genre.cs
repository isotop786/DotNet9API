using System.Text.Json.Serialization;

namespace DotNet9API.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        [JsonIgnore]
        public List<VideoGame>? VideoGames { get; set; }
    }
}
