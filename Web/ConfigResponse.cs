using ModdableWebServer.Attributes;
using ModdableWebServer.Helper;
using ModdableWebServer;
using NetCoreServer;
using GhostbustersEchoServer.Jsons;
using System.Text.Json;

namespace GhostbustersEchoServer.Web;

internal class ConfigResponse
{
    [HTTP("GET", "/config/v1/regions")]
    public static bool ConfigV1Regions(HttpRequest request, ServerStruct serverStruct)
    {
        Console.WriteLine("ConfigV1Regions");
        ConfigRegions regions = new()
        { 
            Name = "production",
            Regions =
            { 
                new ConfigRegions.Region()
                {
                    AWSRegion = "eu-central-1",
                    Name = "eu-central-1",
                    Services =
                    {
                        new ConfigRegions.Service()
                        {
                            Host = "swayze.illfonic.com:4101",
                            Name = "echo"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/arbiter/",
                            Name = "arbiter"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/auth/",
                            Name = "auth"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/config/",
                            Name = "config"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/instance/",
                            Name = "instance"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/key/",
                            Name = "key"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/matchmaking/",
                            Name = "matchmaking"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/news/",
                            Name = "news"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/playerstats/",
                            Name = "playerstats"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/progression/",
                            Name = "progression"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/reporting/",
                            Name = "reporting"
                        },
                        new ConfigRegions.Service()
                        {
                            Host = "https://prod.swayze.illfonic.com/telemetry/",
                            Name = "telemetry"
                        },
                    }
                }
            }
        };
        var resp = JsonSerializer.Serialize(regions, new JsonSerializerOptions() { WriteIndented = true } );
        serverStruct.Response.MakeGetResponse(resp);
        serverStruct.SendResponse();
        Console.WriteLine("ConfigV1Regions Done!");
        return true;
    }

    [HTTP("POST", "/config/v0/metadata")]
    public static bool ConfigMetadata(HttpRequest request, ServerStruct serverStruct)
    {
        Console.WriteLine("ConfigMetadata");
        var build_number = int.Parse(serverStruct.Headers["Build-Number".ToLower()]);
        var metadataReq = JsonSerializer.Deserialize<ConfigMetadatasRequest>(request.Body);
        ConfigMetadatasResponse response = new();
        foreach (var item in metadataReq!.Metadatas)
        {
            response.Metadatas.Add(new ConfigMetadatasResponse.Metadata()
            { 
                Build = build_number,
                MetaType = item.MetaType,
                Version = (int)DateTimeOffset.UtcNow.AddDays(-10).ToUnixTimeMilliseconds(),
                MetaObjects = JsonSerializer.Deserialize<List<object>>(File.ReadAllText(Path.Combine("Meta", $"{item.MetaType}.json")))!
            });
        }
        var resp = JsonSerializer.Serialize(response, new JsonSerializerOptions() { WriteIndented = true });
        serverStruct.Response.MakeGetResponse(resp);
        serverStruct.SendResponse();
        return true;
    }
}
