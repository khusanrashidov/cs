using System;
namespace AnyNameForNamespace
{
    class AnyNameForClass
    {
        public static void Main(string[] args)
        {
            char operation;
            double first, second, result;
            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            operation = (char)Console.Read(); //another method to typecast: operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;
                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;
                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;
                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.ReadKey();
        }
    }
}