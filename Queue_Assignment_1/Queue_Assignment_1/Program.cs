using System;

namespace Queue_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(7);
            queue.enqueue(13983);
            queue.enqueue(10080);
            queue.enqueue(7113);
            queue.enqueue(2520);
            queue.enqueue(2500);

            Queue outputQueue = findEvenlyDivisibleNumbers(queue);

            Console.WriteLine("Evenly divisible numbers");
            outputQueue.display();
        }

        public static Queue findEvenlyDivisibleNumbers(Queue queue)
        {
            //Implement your code here and change the return value accordingly
            int temp;
            Queue result = new Queue(queue.getMaxSize());
            while (queue.isEmpty() == false)
            {
                temp = queue.dequeue();
                if(temp % 2 == 0 && temp % 3 == 0 && temp % 4 == 0 && temp % 5 == 0 && temp % 6 == 0 && temp % 7 == 0 && temp % 8 == 0 && temp % 9 == 0 && temp % 10 == 0)
                {
                    result.enqueue(temp);
                }
            }
            return result;
        }
    }
}
