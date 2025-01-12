using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Jsons;

internal class AttributesMetadata
{
    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("MaxValue")]
    public int MaxValue { get; set; }

    [JsonPropertyName("MinValue")]
    public double MinValue { get; set; }

    [JsonPropertyName("BaseValue")]
    public int BaseValue { get; set; }

    [JsonPropertyName("bCanStack")]
    public bool BCanStack { get; set; }

    [JsonPropertyName("DerivedAttributeInfo")]
    public string DerivedAttributeInfo { get; set; } = string.Empty;
}

internal class ChallengesMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("ParentId")]
    public string ParentId { get; set; } = string.Empty;

    [JsonPropertyName("ManualClaim")]
    public bool ManualClaim { get; set; }

    [JsonPropertyName("RewardItemIDs")]
    public List<string> RewardItemIDs { get; set; } = [];

    [JsonPropertyName("RewardExperience")]
    public int RewardExperience { get; set; }

    [JsonPropertyName("RequiredChallenges")]
    public object? RequiredChallenges { get; set; } = null;

    [JsonPropertyName("RequiredItemLevels")]
    public Dictionary<string, int> RequiredItemLevels { get; set; } = [];

    [JsonPropertyName("RequiredPlayerLevel")]
    public int RequiredPlayerLevel { get; set; }
}

internal class CollectionsMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Limit")]
    public int Limit { get; set; }

    [JsonPropertyName("MapID")]
    public string MapID { get; set; } = string.Empty;

    [JsonPropertyName("StatID")]
    public string StatID { get; set; } = string.Empty;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("StatValue")]
    public int StatValue { get; set; }

    [JsonPropertyName("DropWeight")]
    public int DropWeight { get; set; }
}

internal class FeatsMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Goal")]
    public int Goal { get; set; }

    [JsonPropertyName("StatID")]
    public string StatID { get; set; } = string.Empty;

    [JsonPropertyName("Category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("RewardExp")]
    public int RewardExp { get; set; }

    [JsonPropertyName("CanBeUnseen")]
    public bool CanBeUnseen { get; set; }

    [JsonPropertyName("Description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("ManualClaim")]
    public bool ManualClaim { get; set; }

    [JsonPropertyName("RewardItems")]
    public List<string> RewardItems { get; set; } = [];

    [JsonPropertyName("RemoveOnPrestige")]
    public bool RemoveOnPrestige { get; set; }

    [JsonPropertyName("RewardCurrencies")]
    public object? RewardCurrencies { get; set; } = null;

    [JsonPropertyName("RequiredAchievements")]
    public List<string> RequiredAchievements { get; set; } = [];
}

internal class GameConfigMetaData
{
    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Value")]
    public string Value { get; set; } = string.Empty;
}

internal class HolidayEventsMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("EndDate")]
    public string EndDate { get; set; } = string.Empty;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("StartDate")]
    public string StartDate { get; set; } = string.Empty;
}

internal class InventoryItemsMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Slots")]
    public object? Slots { get; set; } = null;

    [JsonPropertyName("Hidden")]
    public bool Hidden { get; set; }

    [JsonPropertyName("Rarity")]
    public string Rarity { get; set; } = string.Empty;

    [JsonPropertyName("Unique")]
    public bool Unique { get; set; }

    [JsonPropertyName("Category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("AssetName")]
    public string AssetName { get; set; } = string.Empty;

    [JsonPropertyName("DefaultTags")]
    public List<string> DefaultTags { get; set; } = [];

    [JsonPropertyName("UnlockLevel")]
    public int UnlockLevel { get; set; }

    [JsonPropertyName("ParentItemID")]
    public string ParentItemID { get; set; } = string.Empty;

    [JsonPropertyName("UnlockMethod")]
    public List<string> UnlockMethod { get; set; } = [];

    [JsonPropertyName("RemoveOnPrestige")]
    public bool RemoveOnPrestige { get; set; }

    [JsonPropertyName("ParentUnlockLevel")]
    public int ParentUnlockLevel { get; set; }

    [JsonPropertyName("PrestigeUnlockLevel")]
    public int PrestigeUnlockLevel { get; set; }

    [JsonPropertyName("Levelable")]
    public bool? Levelable { get; set; }
}

internal class ItemLevelMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Level")]
    public int Level { get; set; }

    [JsonPropertyName("ToNext")]
    public int ToNext { get; set; }

    [JsonPropertyName("ItemType")]
    public string ItemType { get; set; } = string.Empty;

    [JsonPropertyName("LevelType")]
    public string LevelType { get; set; } = string.Empty;

    [JsonPropertyName("Currencies")]
    public object? Currencies { get; set; } = null;

    [JsonPropertyName("Experience")]
    public int Experience { get; set; }
}

internal class LevelMetaData
{
    [JsonPropertyName("Level")]
    public int Level { get; set; }

    [JsonPropertyName("ToNext")]
    public int ToNext { get; set; }

    [JsonPropertyName("Currencies")]
    public object? Currencies { get; set; } = null;

    [JsonPropertyName("Experience")]
    public int Experience { get; set; }
}

internal class MapMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Path")]
    public string Path { get; set; } = string.Empty;

    [JsonPropertyName("Bounds")]
    public List<int> Bounds { get; set; } = [];

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("Matchmaking")]
    public bool Matchmaking { get; set; }
}

internal class MatchEventMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("Team")]
    public string Team { get; set; } = string.Empty;

    [JsonPropertyName("Type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("Limit")]
    public int Limit { get; set; }

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("P2PLimit")]
    public int P2PLimit { get; set; }

    [JsonPropertyName("Experience")]
    public int Experience { get; set; }

    [JsonPropertyName("Description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("ItemExperience")]
    public int ItemExperience { get; set; }
}

internal class MatchmakingPlatformMetaData
{
    [JsonPropertyName("Platform")]
    public string Platform { get; set; } = string.Empty;

    [JsonPropertyName("CompatibleP2P")]
    public string CompatibleP2P { get; set; } = string.Empty;

    [JsonPropertyName("CompatibleDedicated")]
    public string CompatibleDedicated { get; set; } = string.Empty;
}

internal class MilestoneMetaData
{
    [JsonPropertyName("Tiers")]
    public Dictionary<string, int> Tiers { get; set; } = [];

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("Redirector")]
    public string Redirector { get; set; } = string.Empty;

    [JsonPropertyName("FriendlyName")]
    public string FriendlyName { get; set; } = string.Empty;

    [JsonPropertyName("MatchEventId")]
    public string MatchEventId { get; set; } = string.Empty;

    [JsonPropertyName("AdditionalEvents")]
    public List<string> AdditionalEvents { get; set; } = [];
}

internal class PurchasablesMetaData
{
    [JsonPropertyName("ID")]
    public string ID { get; set; } = string.Empty;

    [JsonPropertyName("Cost")]
    public object? Cost { get; set; } = null;

    [JsonPropertyName("Disabled")]
    public bool Disabled { get; set; }

    [JsonPropertyName("PurchaseType")]
    public string PurchaseType { get; set; } = string.Empty;

    [JsonPropertyName("PackagedItems")]
    public List<string> PackagedItems { get; set; } = [];

    [JsonPropertyName("RequiredItems")]
    public List<string> RequiredItems { get; set; } = [];

    [JsonPropertyName("RequiredLevel")]
    public int RequiredLevel { get; set; }

    [JsonPropertyName("DiscountPercent")]
    public int DiscountPercent { get; set; }

    [JsonPropertyName("RequiredParentLevel")]
    public int RequiredParentLevel { get; set; }
}
