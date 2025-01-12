using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

public class ConfigMetadatasResponse
{
    [JsonPropertyName("Metadata")]
    public List<Metadata> Metadatas { get; set; } = [];
    public class Metadata
    {
        [JsonPropertyName("Build")]
        public int Build { get; set; }

        [JsonPropertyName("MetaType")]
        public string MetaType { get; set; } = string.Empty;

        [JsonPropertyName("Version")]
        public int Version { get; set; }

        [JsonPropertyName("MetaObjects")]
        public List<object> MetaObjects { get; set; } = [];
    }
}
