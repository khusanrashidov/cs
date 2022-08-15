using System;
namespace VariablesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //declaration
            x = 1; //initialization
            int y = 7; //whole integer
            int h = x + y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(h);
            int age = 20;
            Console.WriteLine("I am " + age + " years old.");
            double k = 8.1; //floating point number
            Console.WriteLine("Decimal number " + k);
            bool OnStatus = true; //1
            bool OffStatus = false; //0
            Console.WriteLine("Is status online: " + OnStatus);
            Console.WriteLine("Is status offline: " + OffStatus);
            char ch = '*';
            Console.WriteLine("Character: " + ch);
            String name = "Khusan Rashidov";
            Console.WriteLine("My name is " + name);
            char singleCharacter = 'K';
            String number = "8";
            string username = singleCharacter + number;
            Console.WriteLine("Username: " + username);
            Console.ReadKey();
        }
    }
}