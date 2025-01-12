using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

public class Progression
{
    [JsonPropertyName("AccountID")]
    public string AccountID { get; set; } = string.Empty;

    [JsonPropertyName("ChallengeProfile")]
    public ChallengeProfileClass ChallengeProfile { get; set; } = new();

    [JsonPropertyName("ExperienceProfile")]
    public ExperienceProfileClass ExperienceProfile { get; set; } = new();

    [JsonPropertyName("Wallet")]
    public WalletClass Wallet { get; set; } = new();

    public class ChallengeProfileClass
    {
        [JsonPropertyName("Challenges")]
        public List<Challenge> Challenges { get; set; } = [];
    }

    public class Challenge
    {
        [JsonPropertyName("AccountID")]
        public string AccountID { get; set; } = string.Empty;

        [JsonPropertyName("ChallengeID")]
        public string ChallengeID { get; set; } = string.Empty;

        [JsonPropertyName("Claimed")]
        public bool Claimed { get; set; }

        [JsonPropertyName("ClaimedAt")]
        public DateTime ClaimedAt { get; set; }

        [JsonPropertyName("CompletedAt")]
        public DateTime CompletedAt { get; set; }
    }

    public class ExperienceProfileClass
    {
        [JsonPropertyName("Country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("ExpOverCap")]
        public int ExpOverCap { get; set; }

        [JsonPropertyName("Experience")]
        public int Experience { get; set; }

        [JsonPropertyName("LastBuild")]
        public int LastBuild { get; set; }

        [JsonPropertyName("Level")]
        public int Level { get; set; }

        [JsonPropertyName("Prestige")]
        public int Prestige { get; set; }

        [JsonPropertyName("ToNext")]
        public int ToNext { get; set; }

        [JsonPropertyName("UpdatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public class WalletClass
    {
        [JsonPropertyName("Currencies")]
        public object? Currencies { get; set; } = null;
    }
}
