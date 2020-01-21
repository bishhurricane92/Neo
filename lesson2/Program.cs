using System;

class Program
{
	static void Main()
	{
	appBegin:
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Lesson 2");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		int number1 = 25;
		int workhour1 = 100;
		Decimal salaryperhour1 = 5.50M;
		Console.WriteLine($"NUMBER = {number1}");
		Console.WriteLine($"SALARY = U $ {workhour1 * salaryperhour1}\n");
		int number2 = 1;
		int workhour2 = 200;
		Decimal salaryperhour2 = 20.50M;

		Console.WriteLine($"NUMBER = {number2}");
		Console.WriteLine($"SALARY = U $ {workhour2 * salaryperhour2}\n");
		int number3 = 6;
		int workhour3 = 145;
		Decimal salaryperhour3 = 15.55M;

		Console.WriteLine($"NUMBER = {number3}");
		Console.WriteLine($"SALARY = U $ {workhour3 * salaryperhour3}\n");


		Console.WriteLine("==========================================================================");

		Console.WriteLine("Введите три числа от 1 до 1000:");
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());

		int maior = (num1 + num2 + Math.Abs(num1 - num2)) / 2;
		int maior2 = (num2 + num3 + Math.Abs(num2 - num3)) / 2;

		Console.WriteLine((maior > maior2 ? maior : maior2) + " oh e maior");

		Console.WriteLine("==========================================================================");

		Console.WriteLine("Code             Specification              Price");
		Console.WriteLine("1                Cachorro Quente            R$ 4.00");
		Console.WriteLine("2                X-Salada                   R$ 4.50");
		Console.WriteLine("3                X-Bacon                    R$ 5.00");
		Console.WriteLine("4                Torrada Simples            R$ 2.00");
		Console.WriteLine("5                Refrigerante               R$ 1.50");

		decimal pos1 = 4.00M;
		decimal pos2 = 4.50M;
		decimal pos3 = 5.00M;
		decimal pos4 = 2.00M;
		decimal pos5 = 1.50M;

		Console.WriteLine("Введите два целых числа Х и У. Х - это код товара, У - это количество товара по таблице выше.");
		decimal X = decimal.Parse(Console.ReadLine());
		decimal Y = decimal.Parse(Console.ReadLine());
		if (X < 1 || X > 5) { Console.WriteLine("Позиций товара всего 5. Введите заново:"); }

		if (X == 1) { X = pos1; }
		else if (X == 2) { X = pos2; }
		else if (X == 3) { X = pos3; }
		else if (X == 4) { X = pos4; }
		else if (X == 5) { X = pos5; }

		Console.WriteLine($"Итого: R $ {X * Y}");


		Console.WriteLine();
		Console.WriteLine("==========================================================================");
		Console.WriteLine("Выйти из программы? [y/n]:");
		if (Console.ReadLine().Trim().ToLower() == "n") { goto appBegin; }
	}
}