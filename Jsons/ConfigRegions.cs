using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

public class ConfigRegions
{
    [JsonPropertyName("Name")]
    public string Name { get; set; } = "production";

    [JsonPropertyName("Regions")]
    public List<Region> Regions { get; set; } = [];

    public class Region
    {
        [JsonPropertyName("AWSRegion")]
        public string AWSRegion { get; set; } = string.Empty;

        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Services")]
        public List<Service> Services { get; set; } = [];
    }

    public class Service
    {
        [JsonPropertyName("Host")]
        public string Host { get; set; } = string.Empty;

        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;
    }
}
