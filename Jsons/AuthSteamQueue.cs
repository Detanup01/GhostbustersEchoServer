using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class AuthSteamQueue
{
    [JsonPropertyName("DelayMS")]
    public int DelayMS { get; set; }

    [JsonPropertyName("Position")]
    public int Position { get; set; }

    [JsonPropertyName("QueuedAt")]
    public string QueuedAt { get; set; } = string.Empty;

    [JsonPropertyName("Ready")]
    public bool Ready { get; set; }

    [JsonPropertyName("Token")]
    public string Token { get; set; } = string.Empty;
}
