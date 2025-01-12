using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class VivoxToken
{
    [JsonPropertyName("Token")]
    public string Token { get; set; } = string.Empty;
}
