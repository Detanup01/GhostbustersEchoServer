using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class MatchReport
{
    [JsonPropertyName("GameMode")]
    public string GameMode { get; set; } = string.Empty;

    [JsonPropertyName("LengthInSeconds")]
    public int LengthInSeconds { get; set; }

    [JsonPropertyName("MapID")]
    public string MapID { get; set; } = string.Empty;

    [JsonPropertyName("MatchID")]
    public string MatchID { get; set; } = string.Empty;

    [JsonPropertyName("Players")]
    public List<Player> Players { get; set; } = [];

    [JsonPropertyName("RunID")]
    public string RunID { get; set; } = string.Empty;

    [JsonPropertyName("WinCondition")]
    public string WinCondition { get; set; } = string.Empty;

    [JsonPropertyName("WinningTeam")]
    public string WinningTeam { get; set; } = string.Empty;

    public class Item
    {
        [JsonPropertyName("Experience")]
        public int Experience { get; set; }

        [JsonPropertyName("ItemId")]
        public string ItemId { get; set; } = string.Empty;

        [JsonPropertyName("MatchEvents")]
        public List<MatchEvent> MatchEvents { get; set; } = [];
    }

    public class MatchEvent
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;
    }

    public class Player
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("Experience")]
        public int Experience { get; set; }

        [JsonPropertyName("Items")]
        public List<Item> Items { get; set; } = [];

        [JsonPropertyName("MVPScore")]
        public int MVPScore { get; set; }

        [JsonPropertyName("MatchEvents")]
        public List<MatchEvent> MatchEvents { get; set; } = [];

        [JsonPropertyName("Score")]
        public int Score { get; set; }

        [JsonPropertyName("Team")]
        public string Team { get; set; } = string.Empty;
    }
}
