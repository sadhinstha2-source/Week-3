using System;
using System.Xml.Linq;
using Week_3;

namespace Week_3
{
	public class Drink : MenuItem
	{
		public int SizeMl { get; set; }

		public Drink(string name, int sizeMl, double price) : base(name, price)
		{
			SizeMl = sizeMl;
		}

		public override void Describe()
		{
			Console.WriteLine($"Drink: {Name} ({SizeMl}ml) - £{Price:F2}");
		}
	}
}