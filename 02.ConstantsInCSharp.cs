using System;
namespace ConstantsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * constants - immutable values which are known at compile
             * time and do not change for the life of the program.
             */
            const double pi = 3.14159265;
            Console.WriteLine(pi);
            Console.ReadLine();
        }
    }
}