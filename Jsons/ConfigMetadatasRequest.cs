using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

public class ConfigMetadatasRequest
{
    [JsonPropertyName("Metadata")]
    public List<Metadata> Metadatas { get; set; } = [];
    public class Metadata
    {

        [JsonPropertyName("MetaType")]
        public string MetaType { get; set; } = string.Empty;

        [JsonPropertyName("Version")]
        public int Version { get; set; }
    }
}
