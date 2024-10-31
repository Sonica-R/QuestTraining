using System;
namespace EchoServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ServerBuilder();

            server.Run(res =>
            {
                server.SendMessage(res);
                Console.WriteLine("Echoed...");
            });

            server.ShutDown();         
        }
    }
}




// In main method - Without class seperation
/*var ip = IPAddress.Parse("127.0.0.1");
var portNum = 8000;

var listener = new TcpListener(ip, portNum);
listener.Start();
Console.WriteLine($"App is listeningcto {ip}:{portNum}");



Socket socket = listener.AcceptSocket();
Console.WriteLine("Client connected");

while (true)
{
    var buffer = new byte[1024];
    var dataLength = socket.Receive(buffer);
    string msg = Encoding.ASCII.GetString(buffer, 0, dataLength);

    byte[] responseData = Encoding.ASCII.GetBytes(msg);
    socket.Send(responseData);

}
socket.Close();
listener.Stop();*/

