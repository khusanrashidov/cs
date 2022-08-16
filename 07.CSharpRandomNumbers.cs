using System;
namespace CSharpRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //instantiating random object of Random class
            //Next method is for integer values
            Console.WriteLine(random.Next(1, 9)); //random number between 1 and 8
            Console.WriteLine(random.Next(1, 9) + 80); //random number between 81 and 88
            int num = random.Next(1, 7); //storing number in int data type, range is from 1 inclusive and to 7 exclusive
            Console.WriteLine("{0}", num);
            double dec = random.NextDouble();
            double imal = random.NextDouble();
            Console.WriteLine(dec);
            Console.WriteLine(dec);
            Console.WriteLine(imal);
            Console.ReadKey();
        }
    }
}