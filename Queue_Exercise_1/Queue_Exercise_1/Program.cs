using System;

namespace Queue_Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(7);
            queue.enqueue(2);
            queue.enqueue(7);
            queue.enqueue(9);
            queue.enqueue(4);
            queue.enqueue(6);
            queue.enqueue(5);
            queue.enqueue(10);

            Queue[] queueArray = splitQueue(queue);

            Console.WriteLine("Elements in the queue of odd numbers");
            queueArray[0].display();

            Console.WriteLine("\nElements in the queue of even numbers");
            queueArray[1].display();
        }

        public static Queue[] splitQueue(Queue queue)
        {
            //Implement your code here and change the return value accordingly
            int temp;
            Queue oddNum = new Queue(queue.getMaxSize());
            Queue evenNum = new Queue(queue.getMaxSize());

            while (queue.isEmpty() == false)
            {
                temp = queue.dequeue();
                if(temp % 2 == 0)
                {
                    evenNum.enqueue(temp);
                }
                else
                {
                    oddNum.enqueue(temp);
                }
            }

            Queue[] result = new Queue[] { oddNum, evenNum };
            return result;
        }
    }
}
