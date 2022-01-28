using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Queue
    {
        private int front;
        private int rear;
        private int maxSize;
        private String[] arr;

        public Queue(int maxSize)
        {
            this.front = 0;
            this.rear = -1;
            this.maxSize = maxSize;
            arr = new String[maxSize];
        }

        public bool isFull()
        {
            if(rear == maxSize - 1)
            {
                return true;
            }
            else 
                return false;
        }

        public bool enqueue(String data)
        {
            if(this.isFull())
            {
                return false;
            }
            else
            {
                this.arr[++this.rear] = data;
                return true;
            }
        }

        public void display()
        {
            if (isEmpty())
                Console.WriteLine("Queue is empty!");

            else
            {
                Console.WriteLine("Displaying queue elements");
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

        public String dequeue()
        {
            if (isEmpty())
            {
                return "empty";
            }
            else
            {
                String data = arr[this.front];
                arr[front++] = null;
                return data;
            }
        }
    }
}
