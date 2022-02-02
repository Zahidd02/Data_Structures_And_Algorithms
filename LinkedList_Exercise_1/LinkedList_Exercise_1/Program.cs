using System;
using System.Collections.Generic;

namespace LinkedList_Exercise_1
{
    internal class Program
    {
		public static LinkedList<Object> concatenateLists(LinkedList<Object> listOne, LinkedList<Object> listTwo)
		{
			//Implement your logic here and change the return statement accordingly
			LinkedList<Object> newListTwo = new LinkedList<Object>();
            foreach (var item in listTwo)
            {
				newListTwo.AddFirst(item);
            }
            foreach (var item in newListTwo)
            {
				listOne.AddLast(item);
            }
			return listOne;
		}


		public static void Main(String[] args)
		{
			LinkedList<Object> listOne = new LinkedList<Object>();
			listOne.AddLast("Hello");
			listOne.AddLast(102);
			listOne.AddLast(25);
			listOne.AddLast(38.5);

			LinkedList<Object> listTwo = new LinkedList<Object>();
			listTwo.AddLast(150);
			listTwo.AddLast(200);
			listTwo.AddLast('A');
			listTwo.AddLast("Welcome");

			LinkedList<Object> concatenatedList = concatenateLists(listOne, listTwo);

			Console.WriteLine("Concatenated linked list:");
			foreach (Object value in concatenatedList)
			{
				Console.WriteLine(value + " ");
			}
		}
	}
}
