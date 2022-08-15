using System;
namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your full name: ");
            string fullname = Console.ReadLine();
            Console.WriteLine("Your full name: " + fullname);
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);
            Console.Write("Enter your favourite number: ");
            double K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your favourite number is {0}", K);
            Console.ReadKey();
        }
    }
}