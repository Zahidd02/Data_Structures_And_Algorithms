using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Assignment_1
{
    internal class Queue
    {
        private int front;
        private int rear;
        private int maxSize;
        private int[] arr;

        public Queue(int maxSize)
        {
            this.front = 0;
            this.rear = -1;
            this.maxSize = maxSize;
            this.arr = new int[this.maxSize];
        }

        public bool isFull()
        {
            if (rear == maxSize - 1)
            {
                return true;
            }
            return false;
        }

        public bool enqueue(int data)
        {
            if (isFull())
            {
                return false;
            }
            else
            {
                arr[++rear] = data;
                return true;
            }
        }

        public void display()
        {
            if (isEmpty())
                Console.WriteLine("Queue is empty!");
            else
            {
                for (int index = front; index <= rear; index++)
                {
                    Console.WriteLine(arr[index]);
                }
            }
        }

        public bool isEmpty()
        {
            if (front > rear)
                return true;
            return false;
        }

        public int dequeue()
        {
            if (isEmpty())
            {
                return int.MinValue;
            }
            else
            {
                int data = arr[this.front];
                arr[front++] = int.MinValue;
                return data;
            }
        }

        public int getMaxSize()
        {
            return maxSize;
        }
    }
}
