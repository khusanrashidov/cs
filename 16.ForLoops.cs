using System;
namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop = repeats some code for finite amount of times
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine();
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(index);
            }
            Console.WriteLine();
            for (int k = 8; k <= 256; k += 8)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year");
            /*Infinite for loop*/
            for (int j = 0; j <= 0; --j)
            {
                Console.WriteLine("Infinite loop.");
            }
            Console.ReadKey();
        }
    }
}