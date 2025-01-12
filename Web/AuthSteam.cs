using ModdableWebServer.Attributes;
using ModdableWebServer;
using NetCoreServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using GhostbustersEchoServer.Jsons;
using ModdableWebServer.Helper;
using GhostbustersEchoServer.Utils;
using GhostbustersEchoServer.Control;
using SteamClientApp;

namespace GhostbustersEchoServer.Web;

internal class AuthSteam
{
    [HTTP("POST", "/auth/v2/steam/queue")]
    public static bool SteamQueue(HttpRequest request, ServerStruct serverStruct)
    {
        Console.WriteLine("SteamQueue");
        AuthSteamQueue queue = new()
        { 
            QueuedAt = TimeUtils.GetZTime(),
            DelayMS = 1000,
            Position = 0,
            Ready = true,
            Token = Guid.NewGuid().ToString(),
        };
        var resp = JsonSerializer.Serialize(queue, new JsonSerializerOptions() { WriteIndented = true });
        serverStruct.Response.MakeGetResponse(resp);
        serverStruct.SendResponse();
        return true;
    }

    [HTTP("POST", "/auth/v2/steam/login?{args}")]
    public static bool SteamLogin(HttpRequest request, ServerStruct serverStruct)
    {
        Console.WriteLine("SteamLogin");
        var token = serverStruct.Parameters["PlatformToken"];
        var user = UserController.CreateUserFromSteam(AppTickets.GetTicket(Convert.FromHexString(token)));
        AuthSteamLogin login = new()
        {
            AccountID = user.AccountID,
            IllfonicID = user.IllfonicID,
            SessionToken = Guid.NewGuid().ToString(),
            PlayerEntitlements =
            { 
                new AuthSteamLogin.PlayerEntitlement()
                {
                    Count = 1,
                    Platform = "steam",
                    PlatformEntitlementID = "2383990"
                }
            },
            Token = new()
            {
                ExpiresAt = DateTime.UtcNow.AddDays(1),
                IssuedAt = DateTime.UtcNow,
                TimeToLiveSeconds = 86399,
                Token = "randomToken"
            }
        };
        var resp = JsonSerializer.Serialize(login, new JsonSerializerOptions() { WriteIndented = true });
        serverStruct.Response.MakeGetResponse(resp);
        serverStruct.SendResponse();
        return true;
    }
}
