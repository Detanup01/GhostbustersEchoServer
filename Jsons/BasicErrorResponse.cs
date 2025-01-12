using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class BasicErrorResponse
{
    [JsonPropertyName("Error")]
    public string Error { get; set; } = "too many requests";
}
