using System;
namespace CSharpNestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * nested loops = loops inside of other loops
             * uses vary, used a lot in sorting algorithms
             */
            Console.Write("How many rows?: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many columns?: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any character symbol: ");
            char @char = (char)Console.Read();
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(" " + @char);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}