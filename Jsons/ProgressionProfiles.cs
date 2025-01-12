using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ProgressionProfiles
{
    [JsonPropertyName("Profiles")]
    public List<Progression> Profiles { get; set; } = [];
}
