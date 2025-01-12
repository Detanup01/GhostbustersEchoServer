using GhostbustersEchoServer.Servers;
using ModdableWebServer.Servers;
using NetCoreServer;
using System.Net.Sockets;
using System.Reflection;

namespace GhostbustersEchoServer.Web;

public class MainWeb
{
    public static HTTPS_Server? Server;
    static EchoServer? EchoServer;

    public static void Start()
    {
        ModdableWebServer.Helper.DebugPrinter.EnableLogs = true;
        var ssl = ModdableWebServer.Helper.CertHelper.GetContextNoValidate(System.Security.Authentication.SslProtocols.Tls12, "cert.pfx", string.Empty);
        Server = new(ssl, "0.0.0.0", 443);
        Server.MergeAttributes(Assembly.GetExecutingAssembly());
        Server.Start();
        Server.OnSocketError += Error;
        Server.ReceivedRequestError += ReceiveError;;
        EchoServer = new("0.0.0.0", 4101);
        EchoServer.Start();
        Console.WriteLine("Server started!");
    }

    private static void ReceiveError(object? sender, (HttpRequest request, string error) e)
    {
        Console.WriteLine("ReceiveError!");
        Console.WriteLine(e.error);
        Console.WriteLine(e.request.Url);
    }

    private static void Error(object? sender, SocketError e)
    {
        Console.WriteLine("Error!");
        Console.WriteLine(e);
    }

    public static void Stop()
    {
        EchoServer?.Stop();
        Server?.Stop();
    }
}
