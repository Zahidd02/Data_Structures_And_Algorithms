using System;

namespace Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
			Queue queue = new Queue(5);
			Console.WriteLine("Queue created.\n");

			if (queue.enqueue("Joe"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			if (queue.enqueue("Jack"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			if (queue.enqueue("Eva"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			if (queue.enqueue("Mia"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			if (queue.enqueue("Luke"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			queue.display();

			if (queue.enqueue("Emma"))
				Console.WriteLine("The element is enqueued to the queue!\n");
			else
				Console.WriteLine("Queue is full!\n");

			String dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");

			dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");

			dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");

			dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");

			dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");

			dequeuedElement = queue.dequeue();
			if (dequeuedElement == "empty")
				Console.WriteLine("Queue is empty\n");
			else
				Console.WriteLine("The element dequeued is : " + dequeuedElement + "\n");
		}
	}
}
