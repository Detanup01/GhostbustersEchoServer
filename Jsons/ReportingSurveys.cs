using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ReportingSurveys
{
    [JsonPropertyName("Surveys")]
    public List<SurveyClass> Surveys { get; set; } = [];

    public class ScaleClass
    {
        [JsonPropertyName("Build")]
        public int Build { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("Label")]
        public string Label { get; set; } = string.Empty;

        [JsonPropertyName("Order")]
        public int Order { get; set; }

        [JsonPropertyName("Scale")]
        public string Scale { get; set; } = string.Empty;

        [JsonPropertyName("Value")]
        public int Value { get; set; }
    }

    public class SurveyClass
    {
        [JsonPropertyName("Disabled")]
        public bool Disabled { get; set; }

        [JsonPropertyName("ID")]
        public string ID { get; set; } = string.Empty;

        [JsonPropertyName("MapID")]
        public string MapID { get; set; } = string.Empty;

        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Scale")]
        public List<ScaleClass> Scale { get; set; } = [];

        [JsonPropertyName("ScaleID")]
        public string ScaleID { get; set; } = string.Empty;

        [JsonPropertyName("Survey")]
        public string Survey { get; set; } = string.Empty;

        [JsonPropertyName("Tags")]
        public List<string> Tags { get; set; } = [];

        [JsonPropertyName("Weight")]
        public int Weight { get; set; }
    }
}
