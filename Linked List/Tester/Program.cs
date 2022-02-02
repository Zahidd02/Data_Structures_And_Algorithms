using System;

namespace Linked_List_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Dummy Values
            LinkedList x = new LinkedList();
            x.addAtEnd("Milan");
            x.addAtEnd("Venice");
            x.addAtEnd("Munich");
            x.addAtEnd("Vienna");
            x.addAtEnd("Himatnagar");
            x.addAtBeginning("Panpur");
            x.addAtEnd("Ilol");

            //x.display();

            //if (x.find("Vienna") != null)
            //    Console.WriteLine("Node found");

            // else
            //    Console.WriteLine("Node not found");
            x.display();
            Console.WriteLine("");
            x.swapAdjecent(x);
            x.display();

            #endregion

            #region Shift LinkedList Problem Lex
            // LinkedList x = new LinkedList();
            // x.addAtEnd("ABC");
            // x.addAtEnd("DFG");
            // x.addAtEnd("XYZ");
            // x.addAtEnd("EFG");

            // LinkedList y = new LinkedList();
            // y.addAtEnd("ABC");
            // y.addAtEnd("DFG");
            // y.addAtEnd("XYZ");
            // y.addAtEnd("EFG");

            // Console.WriteLine("\nList after right shifting by 2 positions");
            // x.shiftListRight(x, 2);
            // x.display();

            // Console.WriteLine("\nList after left shifting by 2 positions");
            // y.shiftListLeft(y, 2);
            // y.display();
            #endregion

            #region Reverse Linked List
            //LinkedList linkedList = new LinkedList();
            //LinkedList reversedLinkedList = new LinkedList();

            //linkedList.addAtEnd("Data");
            //linkedList.addAtEnd("Structures");
            //linkedList.addAtEnd("and");
            //linkedList.addAtEnd("Algorithms");

            //Console.WriteLine("Initial List");
            //linkedList.display();

            //Console.WriteLine();

            //linkedList.reverseList(linkedList.head, reversedLinkedList);
            //Console.WriteLine("Reversed List");
            //reversedLinkedList.display();
            #endregion
        }
    }
}
