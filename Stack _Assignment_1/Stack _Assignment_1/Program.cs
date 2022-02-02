using System;

namespace Stack__Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(10);
            stack.push(15);
            stack.push(20);
            stack.push(30);
            stack.push(40);

            calculateSum(stack);

            Console.WriteLine("Updated stack");
            stack.display();
        }

        public static void calculateSum(Stack stack)
        {
            //Implement your code here
            int[] temp = new int[100];
            int sum = 0;
            int i = 0;
            while (stack.isEmpty() == false)
            {
                temp[i] = stack.pop();
                sum += temp[i];
                i++;
            }
            i--;
            stack.push(sum);
            while (i >= 0)
            {
                stack.push(temp[i]);
                i--;
            }
        }
    }
}
