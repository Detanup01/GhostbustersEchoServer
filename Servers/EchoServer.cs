using NetCoreServer;
using System.Net.Sockets;
using System.Net;

namespace GhostbustersEchoServer.Servers;

internal class EchoServer : UdpServer
{
    public EchoServer(string address, int port) : base(address, port)
    {
    }

    protected override void OnStarted()
    {
        ReceiveAsync();
    }

    protected override void OnReceived(EndPoint endpoint, byte[] buffer, long offset, long size)
    {
        Console.WriteLine($"Incoming from: {endpoint}\n buffer: {BitConverter.ToString(buffer.Take((int)size).ToArray()).Replace("-", "")}");
        SendAsync(endpoint, buffer, 0, size);
        ReceiveAsync();
    }


    protected override void OnError(SocketError error)
    {
        Console.WriteLine("TestUDP: " + error);
    }
}
