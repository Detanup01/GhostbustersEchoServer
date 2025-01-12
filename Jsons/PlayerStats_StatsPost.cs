using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStats_StatsPost
{
    [JsonPropertyName("LeaderboardEntries")]
    public object? LeaderboardEntries { get; set; } = null;

    [JsonPropertyName("Players")]
    public List<PlayerStats> Players { get; set; } = [];
}
