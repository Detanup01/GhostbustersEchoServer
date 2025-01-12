using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStatsEventsComplete
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
    public List<InventoryCEClass> InventoryCE { get; set; } = [];

    [JsonPropertyName("Notes")]
    public object? Notes { get; set; } = null;

    public class InventoryCEClass
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
}
