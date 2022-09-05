using System;
namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operators = can be used to check if more than one condition is true/false
            /*
             * && (AND)
             * || (OR)
             */
            Console.Write("What's the temperature outside in Celsius: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature >= 10 && temperature <= 25)
            {
                Console.WriteLine("It's warm outside.");
            }
            else if (temperature <= -80 || temperature >= +80)
            {
                Console.WriteLine("Extreme temperature, lethal for humans.");
            }
            Console.ReadKey();
        }
    }
}