using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ReportingSurveysResponse
{
    [JsonPropertyName("MatchID")]
    public string MatchID { get; set; } = string.Empty;

    [JsonPropertyName("OptionalTags")]
    public List<string> OptionalTags { get; set; } = [];

    [JsonPropertyName("RequiredTags")]
    public List<string> RequiredTags { get; set; } = [];

    [JsonPropertyName("Response")]
    public int Response { get; set; }

    [JsonPropertyName("SurveyID")]
    public string SurveyID { get; set; } = string.Empty;
}
