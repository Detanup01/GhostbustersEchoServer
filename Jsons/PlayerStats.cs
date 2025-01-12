using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStats
{
    [JsonPropertyName("Gamertag")]
    public string Gamertag { get; set; } = string.Empty;

    [JsonPropertyName("Achievements")]
    public object? Achievements { get; set; } = null;

    [JsonPropertyName("AchievementsRewardResult")]
    public object? AchievementsRewardResult { get; set; } = null;

    [JsonPropertyName("LastBuild")]
    public int LastBuild { get; set; }

    [JsonPropertyName("LeaderboardEntries")]
    public object? LeaderboardEntries { get; set; } = null;

    [JsonPropertyName("OmitFromLeaderboards")]
    public bool OmitFromLeaderboards { get; set; }

    [JsonPropertyName("Platform")]
    public string Platform { get; set; } = string.Empty;

    [JsonPropertyName("Stats")]
    public List<Stat> Stats { get; set; } = [];

    [JsonPropertyName("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }

    public class Stat
    {
        [JsonPropertyName("StatID")]
        public string StatID { get; set; } = string.Empty;

        [JsonPropertyName("Value")]
        public double Value { get; set; }
    }
}
