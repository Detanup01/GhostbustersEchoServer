using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class MatchRegisterSuccess
{
    [JsonPropertyName("Collectibles")]
    public Dictionary<string, int> Collectibles { get; set; } = [];

    [JsonPropertyName("MatchID")]
    public string MatchID { get; set; } = string.Empty;

    [JsonPropertyName("RunID")]
    public string RunID { get; set; } = string.Empty;
}
