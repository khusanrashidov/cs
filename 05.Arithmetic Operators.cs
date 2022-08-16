using System;
namespace Arithmetic_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 8.0;
            number = number + number;
            number += number;
            number++;
            number--;
            number *= 2;
            number %= 56;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}