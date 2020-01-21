using System;

class Program
{
	static void Main()
	{
	appBegin:
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Lesson 3");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		Console.WriteLine("Task #1");

	inputnumber1:
		Console.WriteLine("Введите целое числа от 1 до 1000:");
		int num1 = int.Parse(Console.ReadLine());
		if (num1 < 1 || num1 > 1000) { Console.WriteLine("Число должно быть не меньше 1 и не больше 1000"); goto inputnumber1; }

		for (int i = 1; i <= num1; i++)
		{
			if (i % 2 != 0)
			{
				Console.WriteLine(i);
			}
		}

		Console.WriteLine("Task #2");

		Console.WriteLine("Введите любые 10 чисел. Числа могут быть как положительными так и отрицательными:");

		int[] X = new int[10];

		for (int i = 0; i < X.Length; i++) { X[i] = int.Parse(Console.ReadLine()); };

		Console.WriteLine("Вывод 10 чисел в массиве с измененными цифрами :");

		for (int n = 0; n < X.Length; n++)
		{
			if (X[n] <= 0) { X[n] = 1; }
			Console.WriteLine(($"X[{n}]=" + X[n]));
		}


		Console.WriteLine("Task #3");

		Console.WriteLine("Введите целое число . Это количество тестовых случаев:");
		int size = int.Parse(Console.ReadLine());

		int Fibonacci(int n)
		{
			if (n == 0 || n == 1) { return n; }
			else { return Fibonacci(n - 1) + Fibonacci(n - 2); }
		}

		int num;
		for (int i = 0; i < size; i++)
		{
			num = int.Parse(Console.ReadLine());
			if (num > 0 && num <= 60) { Console.WriteLine($"Fibonacci[{num}]={Fibonacci(num)}"); }
			else { Console.WriteLine("Не соответствует условию"); }
		}


		Console.WriteLine();
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Выйти из программы? [y/n]:");
		if (Console.ReadLine().Trim().ToLower() == "n") { goto appBegin; }
	}
}