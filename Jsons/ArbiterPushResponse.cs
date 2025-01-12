using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ArbiterPushResponse
{
    [JsonPropertyName("TimeToLiveSeconds")]
    public int TimeToLiveSeconds { get; set; }
}
