using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStats_StatsPostRequest
{
    [JsonPropertyName("MatchID")]
    public string MatchID { get; set; } = string.Empty;

    [JsonPropertyName("Players")]
    public List<Player> Players { get; set; } = [];

    [JsonPropertyName("RunID")]
    public string RunID { get; set; } = string.Empty;

    public class Player
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("Platform")]
        public string Platform { get; set; } = string.Empty;

        [JsonPropertyName("Result")]
        public int Result { get; set; }

        [JsonPropertyName("Stats")]
        public Dictionary<string, double> Stats { get; set; } = [];

        [JsonPropertyName("Team")]
        public string Team { get; set; } = string.Empty;
    }
 
}
