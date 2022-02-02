using System;

namespace Stack__Assignment_1
{
    public class Stack
    {
        private int top;
        private int maxSize;
        private int[] arr;

        public Stack(int maxSize)
        {
            this.top = -1;
            this.maxSize = maxSize;
            arr = new int[maxSize];
        }

        public bool isFull()
        {
            if (top >= (maxSize - 1))
            {
                return true;
            }
            return false;
        }

        public bool push(int data)
        {
            if (isFull())
            {
                return false;
            }
            else
            {
                arr[++top] = data;
                return true;
            }
        }

        public int peek()
        {
            if (isEmpty())
                return int.MinValue;
            else
                return arr[top];
        }

        public void display()
        {
            if (isEmpty())
                Console.WriteLine("Stack is empty!");
            else
            {
                Console.WriteLine("Displaying stack elements");
                for (int index = top; index >= 0; index--)
                {
                    Console.WriteLine(arr[index]); // accessing element at position index
                }
            }
        }

        public bool isEmpty()
        {
            if (top < 0)
            {
                return true;
            }
            return false;
        }

        public int pop()
        {
            if (isEmpty())
                return int.MinValue;
            else
                return arr[top--];
        }
    }
}
