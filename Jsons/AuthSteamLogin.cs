using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class AuthSteamLogin
{
    [JsonPropertyName("AccountID")]
    public string AccountID { get; set; } = string.Empty;

    [JsonPropertyName("AuthToken")]
    public AuthToken Token { get; set; } = new();

    [JsonPropertyName("IllfonicID")]
    public string IllfonicID { get; set; } = string.Empty;

    [JsonPropertyName("PlayerEntitlements")]
    public List<PlayerEntitlement> PlayerEntitlements { get; set; } = [];

    [JsonPropertyName("SessionToken")]
    public string SessionToken { get; set; } = string.Empty;

    public class AuthToken
    {
        [JsonPropertyName("ExpiresAt")]
        public DateTime ExpiresAt { get; set; }

        [JsonPropertyName("IssuedAt")]
        public DateTime IssuedAt { get; set; }

        [JsonPropertyName("TimeToLiveSeconds")]
        public int TimeToLiveSeconds { get; set; }

        [JsonPropertyName("Token")]
        public string Token { get; set; } = string.Empty;
    }

    public class PlayerEntitlement
    {
        [JsonPropertyName("Count")]
        public int Count { get; set; }

        [JsonPropertyName("Platform")]
        public string Platform { get; set; } = string.Empty;

        [JsonPropertyName("PlatformEntitlementID")]
        public string PlatformEntitlementID { get; set; } = string.Empty;
    }
}
