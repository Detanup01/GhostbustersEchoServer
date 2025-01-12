using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStatsEvents
{
    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("Events")]
    public List<Event> Events { get; set; } = [];

    public class Event
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("Completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("CompletedAt")]
        public DateTime CompletedAt { get; set; }

        [JsonPropertyName("EndsAt")]
        public DateTime EndsAt { get; set; }

        [JsonPropertyName("EventID")]
        public int EventID { get; set; }

        [JsonPropertyName("Goal")]
        public int Goal { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Interval")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Interval Interval { get; set; } = Interval.daily;

        [JsonPropertyName("IntervalID")]
        public int IntervalID { get; set; }

        [JsonPropertyName("Progress")]
        public int Progress { get; set; }

        [JsonPropertyName("Reward")]
        public Reward Reward { get; set; } = new();

        [JsonPropertyName("RotationID")]
        public int RotationID { get; set; }

        [JsonPropertyName("RotationName")]
        public string RotationName { get; set; } = string.Empty;

        [JsonPropertyName("RunID")]
        public string RunID { get; set; } = string.Empty;

        [JsonPropertyName("SingleRun")]
        public bool SingleRun { get; set; }

        [JsonPropertyName("StartsAt")]
        public DateTime StartsAt { get; set; }

        [JsonPropertyName("StatID")]
        public string StatID { get; set; } = string.Empty;
    }
    public class Reward
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Items")]
        public List<Item> Items { get; set; } = [];

        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;
    }

    public class Item
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("ItemID")]
        public string ItemID { get; set; } = string.Empty;

        [JsonPropertyName("ItemType")]
        public string ItemType { get; set; } = string.Empty;
    }

    public enum Interval
    {
        daily,
        weekly
    }
}
