using SteamClientApp;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GhostbustersEchoServer.Control;

internal class UserController
{
    public static bool IsUserExistsFromSteamId(ulong steamId)
    {
        return GetUsers().Any(x=>x.SteamId == steamId);
    }

    public static User? GetUser(string accountId)
    {
        return GetUser(x=>x.AccountID == accountId);
    }
    public static User? GetUser(Func<User, bool> pred)
    {
        return GetUsers().Where(pred).FirstOrDefault();
    }

    public static List<User> GetUsers()
    {
        List<User> users = new List<User>();
        Directory.CreateDirectory("Users");
        foreach (var file in Directory.GetFiles("Users", "*.json"))
        {
            try
            {
                var json = JsonSerializer.Deserialize<User>(File.ReadAllText(file));
                if (json == null)
                    continue;
                users.Add(json);
            } catch { }
        }

        return users;
    }

    public static User CreateUserFromSteam(AppTickets.TicketStruct ticketStruct)
    {
        if (!IsUserExistsFromSteamId(ticketStruct.SteamID))
        {
            User user = new()
            {
                AccountID = Guid.NewGuid().ToString(),
                IllfonicID = Random.Shared.NextInt64().ToString(),
                SteamId = ticketStruct.SteamID,
            };
            CreateUser(user);
            return user;
        }
        return GetUser(x=>x.SteamId == ticketStruct.SteamID)!;
    }

    public static void CreateUser(User user)
    {
        Directory.CreateDirectory("Users");
        File.WriteAllText(Path.Combine("Users", $"{user.AccountID}.json"), JsonSerializer.Serialize(user, new JsonSerializerOptions() { WriteIndented = true }));
    }
}

internal class User
{
    [JsonPropertyName("AccountID")]
    public string AccountID { get; set; } = string.Empty;

    [JsonPropertyName("IllfonicID")]
    public string IllfonicID { get; set; } = string.Empty;

    [JsonPropertyName("SteamId")]
    public ulong SteamId { get; set; } = 0;
}
