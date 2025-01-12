using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class ProgressionHolidays
{
    [JsonPropertyName("ActiveHolidayEvents")]
    public object? ActiveHolidayEvents { get; set; } = null;
}
