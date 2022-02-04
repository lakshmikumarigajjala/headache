using System;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
			int Choice = 0;
			OrderProcessing Order = new OrderProcessing();
			Order.CreateInventory();

			// Display a short menu to the user before taking an action
			try
			{
				Console.WriteLine(" =-= College Park Auto Parts =-=");
				Console.WriteLine("How may I help you?");
				Console.WriteLine("1. I want to process a customer's order");
				Console.WriteLine("2. I want to see the current inventory");
				Console.WriteLine("3. I want to add a new item to the inventory");
				Console.Write("Your choice (1, 2, or 3)? ");
				Choice = int.Parse(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("\nInvalid Choice - The program will terminate\n");
			}

			// Take an action based on the user's choice
			switch (Choice)
			{
				case 1:
					Order.ProcessOrder();
					break;
				case 2:
					Order.showInventory();
					break;
				case 3:
					Order.AddNewItem();
					break;
			}

		}
	}
}
