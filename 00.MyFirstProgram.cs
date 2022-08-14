using System;
namespace MyFirstProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("I like C#");
			Console.WriteLine(" or JS?");
			Console.WriteLine("Hello World!");
			Console.Beep(); //for beep
			//press cw and press tab twice for Console.WriteLine() shortcut
			/*
			 * \t for tab escape sequence
			 * \b for backspace
			 * \n for newline
			*/
			Console.ReadKey(); //pause till any key is pressed
		}
	}
}