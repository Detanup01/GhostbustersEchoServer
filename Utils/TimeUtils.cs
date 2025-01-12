namespace GhostbustersEchoServer.Utils;

public static class TimeUtils
{
    public static string GetZTime() => DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
}
