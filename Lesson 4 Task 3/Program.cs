using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("==========================================================================");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		int j, sum = 0;
		Console.WriteLine("Введите количество тестовых примеров. Число должно быть в диапазоне от 1 до 2000:");
		int T = int.Parse(Console.ReadLine());
		if (T >= 1 || T <= 2000) { Console.WriteLine("Число должно быть в диапазоне от 1 до 2000."); }
		for (int i = 0; i < T; i++)
		{
			Console.WriteLine("Введите цифру соответствующий значению , что Джон хочет установить светодиоды.");
			string count = Console.ReadLine();
			if (string.IsNullOrEmpty(count)) { Console.WriteLine("Вы не ввели цифру. Введите цифру соответствующий значению , что Джон хочет установить светодиоды."); };
			//считываем число как строку на каждую цифру
			for (j = 0; j < count.Length; j++)
			{
				if (count[j] == '1')
				{
					sum += 2;
				}
				else if (count[j] == '2')
				{
					sum += 5;
				}
				else if (count[j] == '3')
				{
					sum += 5;
				}
				else if (count[j] == '4')
				{
					sum += 4;
				}
				else if (count[j] == '5')
				{
					sum += 5;
				}
				else if (count[j] == '6')
				{
					sum += 6;
				}
				else if (count[j] == '7')
				{
					sum += 3;
				}
				else if (count[j] == '8')
				{
					sum += 7;
				}
				else if (count[j] == '9')
				{
					sum += 6;
				}
				else if (count[j] == '0')
				{
					sum += 6;
				}
			}
			Console.Write($"{sum} светодиодов\n");
			sum = 0;
		}


		Console.WriteLine();
		Console.WriteLine("==========================================================================");
	}
}