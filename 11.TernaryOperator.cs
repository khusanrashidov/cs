using System;
namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select program statement by entering proper word in quotes:");
            Console.WriteLine("\"ONE\".Find if number is even or odd.");
            Console.WriteLine("\"TWO\".Find properties of two numbers.");
            Console.WriteLine("\"THREE\".Find largest among three numbers.");
            Console.WriteLine("\"ZERO\".To exit.");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "ZERO": break;
                case "ONE":
                    {
                        Console.Write("Enter any whole number: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine((number % 2 == 0) ? "Even number." : "Odd number.");
                    }
                    break;
                case "TWO":
                    {
                        Console.WriteLine("Enter any two numbers:");
                        Console.Write("1st number: ");
                        double number1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("2nd number: ");
                        double number2 = Convert.ToDouble(Console.ReadLine());
                        string result = number1 > number2 ? "1st number is greater than 2nd number" : number1 < number2 ? "2nd number is greater than 1st number" : "1st number is equal to 2nd number";
                        Console.WriteLine(result);
                    }
                    break;
                case "THREE":
                    {
                        Console.WriteLine("Enter any two numbers:");
                        Console.Write("1st number: ");
                        double number1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("2nd number: ");
                        double number2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("3rd number: ");
                        double number3 = Convert.ToDouble(Console.ReadLine());
                        double result = (number1 > number2) ? (number1 > number3 ? number1 : number3) : (number2 > number3 ? number2 : number3);
                        Console.WriteLine("The largest number is {0}", result);
                    }
                    break;
                default: Console.WriteLine("Enter ONE, TWO or ZERO.");
                    break;
                    
            }
            Console.ReadKey();
        }
    }
}