using System;
namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            while (playAgain)
            {
                string computer = "";
                string player = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                Console.WriteLine("Player chose: " + player);
                switch (random.Next(1, 3 + 1))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                    default: break;
                }
                Console.WriteLine("Computer chose: " + computer);
                if (player == computer)
                {
                    Console.WriteLine(player + " against " + computer + " is draw.");
                }
                else if ((player == "ROCK" && computer == "SCISSORS") || (player == "PAPER" && computer == "ROCK") || (player == "SCISSORS" && computer == "PAPER"))
                {
                    Console.WriteLine(player + " against " + computer + ", player wins.");
                }
                else
                {
                    Console.WriteLine(player + " against " + computer + ", computer wins.");
                }
                Console.Write("Would you like to play another round(Y/N): ");
                string response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (response == "N")
                {
                    playAgain = false;
                    Console.Beep();
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing.");
            Console.ReadKey();
        }
    }
}