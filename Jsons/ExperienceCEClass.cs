using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

// File
public class ExperienceCEClass
{
     [JsonPropertyName("Experience")]
     public int Experience { get; set; }

     [JsonPropertyName("Levels")]
     public int Levels { get; set; }

     [JsonPropertyName("Prestige")]
     public int Prestige { get; set; }
}