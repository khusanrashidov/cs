using System;
namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -2;
            double y = Math.Pow(x, 8);
            Console.WriteLine("{0}^8={1}", x, y);
            double k = Math.Sqrt(y);
            Console.WriteLine("{0}^1/2={1}", y, k);
            double h = Math.Abs(x);
            Console.WriteLine("{0}'s absolute value is {1}", x, h);
            double j = Math.Round(9.81);
            Console.WriteLine(9.81 + " rounded to {0}", j);
            double e = Math.Round(9.81, 1);
            Console.WriteLine(9.81 + " rounded to {0}", e);
            double r = Math.Ceiling(8.5);
            Console.WriteLine(8.5 + " rounded UP to {0}", r);
            double l = Math.Floor(8.5);
            Console.WriteLine(8.5 + " rounded DOWN to {0}", l);
            double d = Math.Floor(8.8);
            Console.WriteLine(8.8 + " rounded DOWN to {0}", d);
            double p = Math.Ceiling(8.2);
            Console.WriteLine(8.2 + " rounded UP to {0}", p);
            double a = Math.Max(3, 5);
            Console.WriteLine("Maximum between " + 3 + " and " + 5 + " is {0}", a);
            double z = Math.Min(3, 5);
            Console.WriteLine("Minimum between " + 3 + " and " + 5 + " is {0}", z);
            Console.ReadKey();
        }
    }
}