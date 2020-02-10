using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sklad
{
	Tovar tovar; 
	public Sklad() { }
	public Sklad(Tovar tovar) { }
	public void AddTovar(List<Tovar> list, int count)
	{
		count++;
		Console.WriteLine("Введите код товара");
		int code = int.Parse(Console.ReadLine());
		Console.WriteLine("Введите название товара");
		string name = Console.ReadLine();
		Console.WriteLine("Введите цену товара");
		int price = int.Parse(Console.ReadLine());
		Console.WriteLine("Введите количество");
		int amount = int.Parse(Console.ReadLine());
		list.Add(new Tovar() { Code = code, Name = name, Price = price, Amount = amount });
	}

}