using System;
using System.Net.Sockets;
using System.Text;


namespace EchoClient
{
    public class ClientBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpClient _client;

        public void Connect()
        {
            _client = new TcpClient();
            _client.Connect(ipAddress, port);
            Console.WriteLine("Client :");
            Console.WriteLine("Connected to server");
        }

        // CallBack "function" is passed "as a parameter" in Run function
        // Using Action Delegate
        public void Run(Action<String> callBack)
        {
            Connect();
            while (true)
            {
                Console.Write("Enter message: ");
                string message = Console.ReadLine();
                SendMessage(message);

                var buffer = new byte[1024];
                int dataLength = _client.GetStream().Read(buffer, 0, buffer.Length);
                string msg = Encoding.ASCII.GetString(buffer, 0, dataLength);
                callBack(msg);
            }
        }

        public void SendMessage(string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            _client.GetStream().Write(data, 0, data.Length);
        }
        public void Shutdown()
        {
            _client.Close();
        }
    }
}