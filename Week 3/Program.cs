using System;

namespace Week_3
{
	internal class Program
	{
		// The restaurant decides the menu, not the customer
		static MenuItem[] menu =
		{
			new Meal("Burger", 5.99),
			new Meal("Pizza", 7.49),
			new Meal("Chicken Wrap", 6.25),
			new Meal("Pasta", 8.50),
			new Meal("Fish and Chips", 9.20),
			new Drink("Cola", 500, 1.50),
			new Drink("Orange Juice", 330, 2.10),
			new Drink("Water", 500, 0.99),
			new Drink("Milkshake", 400, 3.25)
		};

		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Console.WriteLine("Welcome to the Food Delivery Platform!");

			bool ordering = true;
			while (ordering)
			{
				Console.WriteLine();
				Console.WriteLine("=== Full Menu ===");
				for (int i = 0; i < menu.Length; i++)
				{
					Console.Write($"{i + 1}. ");
					menu[i].Describe();   // same call, different result (polymorphism)
				}
				Console.WriteLine("0. Exit");

				int choice = ReadChoice("Choose an item: ", 0, menu.Length);
				if (choice == 0)
				{
					ordering = false;
					continue;
				}

				MenuItem selected = menu[choice - 1];
				Console.WriteLine();
				Console.Write("You selected: ");
				selected.Describe();

				int quantity = ReadQuantity("How many would you like? ");
				double total = selected.CalculateTotal(quantity);

				Console.WriteLine();
				Console.WriteLine("=== Order Total ===");
				Console.WriteLine($"{quantity} x {selected.Name}: £{total:F2}");
			}

			Console.WriteLine("Goodbye!");
		}

		static int ReadChoice(string prompt, int min, int max)
		{
			while (true)
			{
				Console.Write(prompt);
				if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
					return value;
				Console.WriteLine($"  Please enter a number between {min} and {max}.");
			}
		}

		static int ReadQuantity(string prompt)
		{
			while (true)
			{
				Console.Write(prompt);
				if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
					return value;
				Console.WriteLine("  Please enter a whole number greater than 0.");
			}
		}
	}
}