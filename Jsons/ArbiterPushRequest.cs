using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ArbiterPushRequest
{
    [JsonPropertyName("AccountId")]
    public string AccountId { get; set; } = string.Empty;

    [JsonPropertyName("MapName")]
    public string? MapName { get; set; }

    [JsonPropertyName("MatchmakingStatus")]
    public string? MatchmakingStatus { get; set; }

    [JsonPropertyName("SessionToken")]
    public string SessionToken { get; set; } = string.Empty;
}
