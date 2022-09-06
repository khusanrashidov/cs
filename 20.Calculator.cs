﻿using System;
namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0, num2 = 0, result = 0;
                Console.WriteLine("________Calculator Program In C#________");
                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            statement:
                Console.WriteLine("Enter an option:");
                Console.WriteLine("+ for addition.");
                Console.WriteLine("- for subtraction.");
                Console.WriteLine("* for multiplication.");
                Console.WriteLine("/ for division.");
                Console.Write("Your option: ");
                switch (Console.ReadLine())
                {
                    case "menu": goto statement;
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.");
                        Console.ReadKey();
                        Console.Clear();
                        goto case "menu";
                }
                Console.WriteLine("Would you like to continue? (Y = yes, N = no.)");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.Clear();
            Console.Beep();
            Console.WriteLine("So long.");
            Console.ReadKey();
        }
    }
}