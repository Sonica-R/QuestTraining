using System;


namespace EchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new ClientBuilder();

            client.Run(echo =>
            {
                Console.WriteLine($"Echo:{echo}");
            });

            client.Shutdown();

        }
    }
}

