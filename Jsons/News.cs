using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class News
{
    [JsonPropertyName("Articles")]
    public List<Article> Articles { get; set; } = [];

    [JsonPropertyName("Count")]
    public int Count { get; set; }

    public class Article
    {
        [JsonPropertyName("ArticleLink")]
        public string ArticleLink { get; set; } = string.Empty;

        [JsonPropertyName("Content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("EndsAt")]
        public DateTime EndsAt { get; set; }

        [JsonPropertyName("Headline")]
        public string Headline { get; set; } = string.Empty;

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("ImgLink")]
        public string ImgLink { get; set; } = string.Empty;

        [JsonPropertyName("Published")]
        public bool Published { get; set; }

        [JsonPropertyName("StartsAt")]
        public DateTime StartsAt { get; set; }

        [JsonPropertyName("Tags")]
        public object? Tags { get; set; } = null;

        [JsonPropertyName("ThumbLink")]
        public string ThumbLink { get; set; } = string.Empty;

        [JsonPropertyName("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
