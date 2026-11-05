using System;
using System.Xml.Linq;
using Week_3;

namespace Week_3
{
	public class Meal : MenuItem
	{
		public Meal(string name, double price) : base(name, price)
		{
		}

		public override void Describe()
		{
			Console.WriteLine($"Meal: {Name} - £{Price:F2}");
		}
		public override double CalculateTotal(int quantity)
		{
			double total = Price * quantity * 1.10;   // 10% tax
			return Math.Round(total, 2, MidpointRounding.AwayFromZero);
		}
	}
}