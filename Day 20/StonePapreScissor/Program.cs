using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StonePaperScissor
{
    class Game
    {
        public Random rand = new Random();
        public int UserScore;
        public int CompScore;
        public int Input;
        public void startGame()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number between 1 - 3 : ");
                Input = int.Parse(Console.ReadLine());
                int predict = rand.Next(1, 4);
                Console.WriteLine($"Computer's choice : {predict}");
                if ((Input == 1) && (predict == 2) ||
                  (Input == 2) && (predict == 3) ||
                  (Input == 3) && (predict == 1))
                {
                    UserScore++;
                    //Console.WriteLine("You won");
                }
                else if (Input == predict)
                {
                    //Console.WriteLine("It's a tie");
                }
                else
                {
                    CompScore++;
                    //Console.WriteLine("Computer won");
                }
            }
                Console.WriteLine($" User Score :{UserScore}");
                Console.WriteLine($"Computer Score : {CompScore}");          
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.startGame();
        }
    }
}
