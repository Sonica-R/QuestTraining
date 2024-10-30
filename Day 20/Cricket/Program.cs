using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Player
    {
        public string Name { get; set; }
        public int Runs { get; set; }
        public int BallsFaced { get; set; }
        public bool IsOut { get; set; }

        public Player(string name)
        {
            Name = name;
            Runs = 0;
            BallsFaced = 0;
            IsOut = false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the player name");
            string name = Console.ReadLine();
            var player = new Player(name);

            while (player.IsOut == false)
            {
                Console.WriteLine("Enter the runs");
                int runs = int.Parse(Console.ReadLine());

                if (runs <= 6)
                {
                    var rand = new Random();
                    var computer = rand.Next(0, 7);
                    Console.WriteLine($"{computer}");

                    if (computer == runs)
                    {
                        Console.WriteLine("You are out");
                        Console.WriteLine($"Your score : {player.Runs}");
                        Console.WriteLine($"Number of balls faced : {player.BallsFaced}");
                        player.BallsFaced++;
                        player.IsOut = true;
                    }
                    else if (computer == 0)
                    {
                        Console.WriteLine("No ball");
                        player.Runs += runs + 1;
                        Console.WriteLine($"Score: {player.Runs}");

                    }
                    else
                    {
                        player.Runs += runs;
                        player.BallsFaced++;
                        Console.WriteLine($"Score: {player.Runs}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
