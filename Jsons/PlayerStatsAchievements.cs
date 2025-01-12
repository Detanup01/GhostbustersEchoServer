using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class PlayerStatsAchievements
{
    [JsonPropertyName("Achievements")]
    public List<Achievement> Achievements { get; set; } = [];
    public class Achievement
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty; 

        [JsonPropertyName("Completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("CompletedAt")]
        public DateTime CompletedAt { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("Progress")]
        public int Progress { get; set; }
    }
}
