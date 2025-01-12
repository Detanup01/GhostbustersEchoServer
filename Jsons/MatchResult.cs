using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class MatchResult
{
    [JsonPropertyName("MatchID")]
    public string MatchID { get; set; } = string.Empty;

    [JsonPropertyName("Results")]
    public Result Results { get; set; } = new();

    [JsonPropertyName("RunID")]
    public string RunID { get; set; } = string.Empty;

    [JsonPropertyName("Status")]
    public string Status { get; set; } = string.Empty;

    public class InventoryCE
    {
        [JsonPropertyName("Action")]
        public string Action { get; set; } = string.Empty;

        [JsonPropertyName("Experience")]
        public int Experience { get; set; }

        [JsonPropertyName("ItemID")]
        public string ItemID { get; set; } = string.Empty;

        [JsonPropertyName("ItemMetaID")]
        public string ItemMetaID { get; set; } = string.Empty;

        [JsonPropertyName("Level")]
        public int Level { get; set; }
    }

    public class Log
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("ActorID")]
        public string ActorID { get; set; } = string.Empty;

        [JsonPropertyName("BuildNumber")]
        public int BuildNumber { get; set; }

        [JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("EventType")]
        public string EventType { get; set; } = string.Empty;

        [JsonPropertyName("ExperienceCE")]
        public ExperienceCEClass ExperienceCE { get; set; } = new();

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("InventoryCE")]
        public List<InventoryCE> InventoryCE { get; set; } = [];

        [JsonPropertyName("Notes")]
        public object? Notes { get; set; } = null;
    }

    public class Result
    {
        [JsonPropertyName("Logs")]
        public List<Log> Logs { get; set; } = [];

        [JsonPropertyName("MatchID")]
        public string MatchID { get; set; } = string.Empty;
    }
}
