using GhostbustersEchoServer.Web;
using System.IO.Compression;

namespace GhostbustersEchoServer;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello, World!");
        //DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
        MainWeb.Start();
        Console.ReadLine();
        MainWeb.Stop();
    }
}
