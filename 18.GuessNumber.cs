using System;
namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 0;
            int max = 100;
            int guess, number, guesses;
            string response;
            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";
                while (guess != number)
                {
                    Console.Write("Guess a number between " + min + " - " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is high.");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is low.");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win.");
                Console.WriteLine("Guesses: " + guesses);
                Console.Write("Would you like to play again(Y/N): ");
                response = Console.ReadLine();
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