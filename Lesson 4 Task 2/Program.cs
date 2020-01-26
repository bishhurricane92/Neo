using System;

class Program
{
	static void Main()
	{
		Console.WriteLine("==========================================================================");
		Console.WriteLine("==========================================================================");
		Console.WriteLine();

		Console.WriteLine("Введите число N в диапазоне от 0 до 100:");
		int T = int.Parse(Console.ReadLine());
		if (T <= 0 || T >= 100) { Console.WriteLine("Число должно быть в диапазоне от 0 до 100."); }
		//создаем массив из трец компонентов
		int[] arr = new int[3]; int min = 0;
		for (int j = 0; j < T; j++)
		{
			//выбор режима определения 
			Console.WriteLine("Введите название операции: 1)min 2)mean 3)eye");
			int oper = int.Parse(Console.ReadLine());
			switch (oper)
			{
				case 1: 
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine("Введите цифры от 0 до 255. Это будут значения пикселя цветного изображения:");
						arr[i] = int.Parse(Console.ReadLine());
					}
					//миннимальное
					if (arr[0] < arr[1] && arr[0] < arr[2])
						min = arr[0];
					else if (arr[1] < arr[0] && arr[1] < arr[2])
						min = arr[1];
					else if (arr[2] < arr[0] && arr[2] < arr[1])
						min = arr[2];
					Console.WriteLine(min);
					break;
				case 2:
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine("Введите цифры от 0 до 255. Это будут значения пикселя цветного изображения:");
						arr[i] = Convert.ToInt32(Console.ReadLine());
					}
					//среднее арифметическое
					int mean = (arr[0] + arr[1] + arr[2]) / 3;
					Console.WriteLine(mean);
					break;
				case 3:
					for (int i = 0; i < 3; i++)
					{
						Console.WriteLine("Введите цифры от 0 до 255. Это будут значения пикселя цветного изображения:");
						arr[i] = Convert.ToInt32(Console.ReadLine());
					}
					//формула P = 0, 30R + 0, 59G + 0, 11B
					double p = 0.30 * arr[0] + arr[1] * 0.59 + arr[2] * 0.11;
					int eye = Convert.ToInt32(p);
					Console.WriteLine(eye);
					break;
			}
		} 
		Console.WriteLine();
		Console.WriteLine("==========================================================================");
	}
}