using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
    public class ServerBuilder
    {
        private const string ipAddress = "127.0.0.1";
        private const int port = 8000;
        private TcpListener _listener;
        private Socket _socket;

        private void Build()
        {
            var ip = IPAddress.Parse(ipAddress);
            _listener = new TcpListener(ip, port);
        }

        // CallBack function is passed as a parameter in Run function
        // Using Action Delegate
        public void Run(Action<string> callBack)
        {
            Build();
            _listener.Start();
            Console.WriteLine($"App is listening on {ipAddress}:{port}.");

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected");

            while (true)
            {
                var buffer = new byte[1024];
                var dataLength = _socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                callBack(message);
            }
        }
        public void SendMessage(string message)
        {
            var data = Encoding.ASCII.GetBytes(message);
            _socket.Send(data);
        }

        public void ShutDown()
        {
            _socket.Close();
            _listener.Stop();

        }
    }

}
//    public class ServerBuilder
//    {
//        private const string ipAddress = "127.0.0.1";
//        private const int portNum = 8000;
//        private TcpListener _listener;
//        private Socket _socket;

//        private void Build()
//        {
//            var ip = IPAddress.Parse(ipAddress);
//            _listener = new TcpListener(ip, portNum);
//        }

//        /* Action Delegate : so that a function is called
//         inside another fucntion*/
//        public void Run(Action <string> callBack)
//        {
//            Build();
//            _listener.Start();
//            Console.WriteLine($"App is listsening on {ipAddress}:{portNum}");

//            _socket = _listener.AcceptSocket();
//            Console.WriteLine("Client connected");

//            while(true)
//            {
//                var buffer = new byte[1024];
//                var dataLength = _socket.Receive(buffer);
//                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
//                callBack(message);
//            }
//        }

//        public void SendMessage(string message)
//        {
//            var data = Encoding.ASCII.GetBytes(message);
//            _socket.Send(data);
//        }
//        public void ShutDown()
//        {
//            _socket.Close();
//            _listener.Stop();
//        }
//    }
//}

