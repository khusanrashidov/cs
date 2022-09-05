using System;
namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop = repeats some code while some condition remains true
            string name = "";
            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hi " + name);
            while (8 == 8) //can be replaced with true keyword
            {
                Console.WriteLine("Infinite loop.");
            }
            //below infinite loop cannot be reached as above infinite loop will never stop execution
            //however two infinite loops can be executed if multi threading is used
            while (true)
            {
                Console.WriteLine("Unreachable code.");
            }
            Console.ReadKey();
        }
    }
}