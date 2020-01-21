using System;

class Program
{
	static void Main()
	{
	appBegin:
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Что будет делать программа?");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		Console.WriteLine("Fuck the world\n");

		string neobis = "Fuck the world";

		Console.WriteLine($"{neobis}");


		Console.WriteLine();
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Выйти из программы? [y/n]:");
		if (Console.ReadLine().Trim().ToLower() == "n") { goto appBegin; }
	}
}