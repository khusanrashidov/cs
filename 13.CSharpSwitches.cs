using System;
namespace CSharpSwitches
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch = an efficient alternative to many else if statements
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":Console.WriteLine("Today is " + day);
                    break;
                case "Tuesday":Console.WriteLine("Today is " + day);
                    break;
                case "Wednesday":Console.WriteLine("Today is " + day);
                    break;
                case "Thursday":Console.WriteLine("Today is " + day);
                    break;
                case "Friday":Console.WriteLine("Today is " + day);
                    break;
                case "Saturday":Console.WriteLine("Today is " + day);
                    break;
                case "Sunday":Console.WriteLine("Today is " + day);
                    break;
                default: Console.WriteLine(day + " is not a day.");
                    break;
            }
            Console.ReadKey();
        }
    }
}