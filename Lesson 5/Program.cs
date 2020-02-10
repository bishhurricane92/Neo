using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
	
	static void AddTovar(List<Tovar> list, int count)
	{
		count++;
		Console.WriteLine("Введите названия продукта №" + a);
		string name = Console.ReadLine();
		Console.WriteLine("Введите цену");
		int price = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Введите количество");
		int amount = Convert.ToInt32(Console.ReadLine());
		list.Add(new Tovar() { Code = count, Name = name, Price = price, Amount = amount });
	}

	static void ShowTovarList(List<Tovar> list)
	{
		if (list.Count == 0) { Console.WriteLine("Склад пуст"); }
		else
		{
			foreach (Tovar tovar in list)
			{
				Console.WriteLine("Код" + tovar.Code + "Название" + tovar.Name + "Цена" + tovar.Price);
			}
		}
	}

	static void BuyTovar(List<Tovar> list)
	{
		if (list.Count == 0) { Console.WriteLine("Склад пуст"); }
		else
		{
			inputname:
			Console.WriteLine("Введите название продукта:");
			string name = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(name)) { Console.WriteLine("Вы не ввели название товара. Попробуйте снова: "); goto inputname; }

			foreach (Tovar tovar in list)
			{
				if (tovar.Name == tovar.Name)
				{
					Console.WriteLine("Введите количество товара:");
					int amount = int.Parse(Console.ReadLine());
					if (amount <= tovar.Amount)
					{
						int result = amount * tovar.Price;
						Console.WriteLine("Итого: " + result + " сом");
						list.Remove(tovar);
					}
					else { Console.WriteLine("Такого количества товара нет."); }
				}
				else { Console.WriteLine("Ошибка! Продукта с данным названием нет!"); }
			}
		}
	}

	static void DeleteTovar(List<Tovar> list)
	{
		int ind = 0;
		Console.Write("Введите индекс товара, которую хотите удалить ");
		foreach (Tovar tovar in list)
		{
			ind++;
			Console.WriteLine(ind + "Код" + tovar.Code + "Название" + tovar.Name + "Цена" + tovar.Price);
		}
		int index = int.Parse(Console.ReadLine());
		list.RemoveAt(index - 1);
		Console.WriteLine();
	}

	static void SortTovar(List<Tovar> list)
	{
		if (list.Count == 0) { Console.WriteLine("Склад пуст"); }
		else
		{
			var byCost = from u in list
						 orderby u.Price
						 select u;
			Console.WriteLine("Сортировка списка по цене(возрастающей): ");
			foreach (var a in byCost)
				Console.WriteLine("Код продукта: " + a.Code + " Название " + a.Name + " цена: " + a.Price);
		}
	}
	 
	static void Main(string[] args)
	{
		Console.WriteLine("Добро пожаловать в МАГАЗИН.");
		Console.WriteLine("Пожалуйста выберите следующее действие:");
		Console.WriteLine("1)Добавить товар:");
		Console.WriteLine("2) Вывести весь список товаров:");
		Console.WriteLine("3) Покупка товара:");
		Console.WriteLine("4) Подсчет прибыли:");
		Console.WriteLine("5) Сортировка товаров по цене");
		Console.WriteLine("6) Удаление товара");
		int choice = int.Parse(Console.ReadLine());

		List<Tovar> list = new List<Tovar> { };

		switch (choice)
		{
			case 1:
				{
					AddTovar(list, 1);
					break;
				}
			case 2:
				{
					ShowTovarList(list);
					break;
				}
			case 3:
				{
					BuyTovar(list);
					break;
				}
			case 4:
				{
					BuyTovar(list);
					break;
				}
			case 5:
				{
					BuyTovar(list);
					break;
				}
			case 6:
				{
					DeleteTovar(list);
					break;
				} 
		}
	}
}