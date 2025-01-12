using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ReportingReasons
{
    [JsonPropertyName("Reasons")]
    public List<Reason> Reasons { get; set; } = [];

    public class Reason
    {
        [JsonPropertyName("CommentRequired")]
        public bool CommentRequired { get; set; }

        [JsonPropertyName("Disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Value")]
        public string Value { get; set; } = string.Empty;
    }
}
