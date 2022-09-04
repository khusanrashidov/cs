using System;
namespace IfElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement = a basic form of decision making
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("You did not enter your name.");
            }
            else
            {
                Console.WriteLine("Hi " + name);
            }
            Console.Write("Enter your username: ");
            name = Console.ReadLine();
            if (name != "")
            {
                Console.WriteLine("Your username: " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your username.");
            }
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 128)
            {
                Console.WriteLine("You are immortal.");
            }
            else if (age > 17)
            {
                Console.WriteLine("You may proceed admission signing up.");
            }
            else if (age < 0)
            {
                Console.WriteLine("Age must be natural number.");
            }
            else
            {
                Console.WriteLine("You must at least 18 y.o. to sign up");
            }
            Console.ReadKey();
        }
    }
}
