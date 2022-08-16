using System;
namespace HypotenuseCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the value of the leg 1: ");
			double leg1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter the value of the leg 2: ");
			double leg2 = Convert.ToDouble(Console.ReadLine());
			double hypothenuse = Math.Round(Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2)), 2);
			Console.Write("The hypotenuse of the right triangle: {0}", hypothenuse);
			Console.ReadKey();
		}
	}
}