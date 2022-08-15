using System;
namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * type casting - converting a value to a different data type,
             * it is useful when we accept user input (string). As different
             * data types can do different things.
             */
            double a = 3.14159265;
            int b = Convert.ToInt32(a); //or 16 instead 32 but not 64
            Console.WriteLine(a.GetType());
            Console.WriteLine(a);
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            int K = 8;
            Console.WriteLine();
            double H = Convert.ToDouble(K) + 0.8; //typecasting to double
            Console.WriteLine(K.GetType());
            Console.WriteLine(K);
            Console.WriteLine(H.GetType());
            Console.WriteLine(H);
            Console.WriteLine();
            double X = 8.1;
            string S = Convert.ToString(X);
            Console.WriteLine(X.GetType());
            Console.WriteLine(X);
            Console.WriteLine(S.GetType());
            Console.WriteLine(S);
            Console.WriteLine();
            string s = "*";
            char c = Convert.ToChar(s);
            Console.WriteLine(s.GetType());
            Console.WriteLine(s);
            Console.WriteLine(c.GetType());
            Console.WriteLine(c);
            Console.WriteLine();
            string str = "true";
            bool boolean = Convert.ToBoolean(str);
            Console.WriteLine(str.GetType());
            Console.WriteLine(str);
            Console.WriteLine(boolean.GetType());
            Console.WriteLine(boolean);
            Console.ReadKey();
        }
    }
}