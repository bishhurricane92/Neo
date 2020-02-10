using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tovar
{
	int code;
	string name;
	int price;
	int amount;

	public Tovar() { }
	public Tovar(int code, string name, int price, int amount) { Code = code; Name = name; Price = price; Amount = amount; }


	public int Code
	{
		get { return code; }
		set { code = value; }
	}
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public int Price
	{
		get { return price; }
		set { price = value; }
	}
	public int Amount
	{
		get { return amount; }
		set { amount = value; }
	}
	 
}