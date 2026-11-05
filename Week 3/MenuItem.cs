using System;
using System.Collections.Generic;
using System.Text;

namespace Week_3
{
	public abstract class MenuItem
	{
		public string Name{  get; set; }
		public double Price { get; set; }

		public MenuItem(string name , double price)
		{
			Name = name;
			Price = price;
		}
		public virtual void Describe()
		{
			Console.WriteLine($"{Name} - £{Price:F2}");
		}
		public abstract double CalculateTotal(int quality)

	}
}
