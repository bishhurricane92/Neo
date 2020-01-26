using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Lesson 3");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		Console.WriteLine("Task #1");

		int a, b, c, g, h, i, j = 1, N, p, q, r = 0;
		while (true)
		{
			N = int.Parse(Console.ReadLine());
			if (N <= 0 || N >= 100) { Console.WriteLine("Цифра должна быть в диапазоне от 0 до 100"); break; }
			else
			{
				j = 1; p = 0; q = 0;
				int[,] arr = new int[N, N];
				i = N;
				if (N % 2 == 0)
					r = N / 2;
				else if (N % 2 == 1)
					r = (N / 2) + 1;
				for (c = 1; c <= r; c++)
				{
					for (a = p; a < i; a++)
					{
						for (b = q; b < i; b++)
							arr[a, b] = j;
					}
					j++;
					p++;
					q++;
					i--;
				}
				for (g = 0; g < N; g++)
				{
					for (h = 0; h < N; h++)
					{
						if (h == 0)
							Console.Write($"   {arr[g, h]}");
						else
							Console.Write($"    {arr[g, h]}");
					}
					Console.WriteLine();
				}
				Console.WriteLine();


			}
		}



		Console.WriteLine();
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Выйти из программы? [y/n]:");
	}
}