using System;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);
            stack.push(15);
            stack.push(25);
            stack.push(30);
            stack.push(40);

            stack.display();

            if (checkTop(stack))
            {
                Console.WriteLine("The top most element of the stack is an even number");
            }
            else
            {
                Console.WriteLine("The top most element of the stack is an odd number");
            }
        }

        public static Boolean checkTop(Stack stack)
        {
            //Implement your code here and change the return value accordingly
            int num = stack.peek();
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
