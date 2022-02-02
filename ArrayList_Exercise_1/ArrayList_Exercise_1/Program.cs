using System;
using System.Collections.Generic;

namespace ArrayList_Exercise_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Order> orders = new List<Order>();

			List<String> items1 = new List<String>();
			items1.Add("FriedRice");
			items1.Add("Pasta");
			items1.Add("Tortilla");
			orders.Add(new Order(101, items1, true));

			List<String> items2 = new List<String>();
			items2.Add("Pizza");
			items2.Add("Pasta");
			orders.Add(new Order(102, items2, true));

			List<String> items3 = new List<String>();
			items3.Add("Burger");
			items3.Add("Sandwich");
			items3.Add("Pizza");
			orders.Add(new Order(103, items3, true));

			List<String> items = getItems(orders);
			Console.WriteLine("List of Items:");
			foreach (String item in items)
			{
				Console.WriteLine(item);
			}
		}

		public static List<String> getItems(List<Order> orders)
		{
            //Implement your logic here and change the return statement accordingly
			List<String> list = new List<String>();
            foreach (var item in orders)
            {
				list.AddRange(item.getItemNames());
            }
			return list;
		}
	}
}
