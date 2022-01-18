package LinkedList_Exercise;

public class Tester {
	public static void main(String args[]) {
        //#region Dummy Values 
		// LinkedList x = new LinkedList();
		// x.addAtEnd("Milan");
		// x.addAtEnd("Venice");
		// x.addAtEnd("Munich");
		// x.addAtEnd("Vienna");
		// x.addAtEnd("Himatnagar");
		// x.swapAdjecent();
		// x.display();	
        //#endregion
        
        //#region Shift LinkedList Problem Lex
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
            
        // System.out.println("\nList after right shifting by 2 positions");
        // x.shiftListRight(x, 2);
        // x.display();

        // System.out.println("\nList after left shifting by 2 positions");
        // y.shiftListLeft(y, 2);
        // y.display();
        //#endregion
        
        //#region Reverse Linked List
        LinkedList linkedList = new LinkedList();
        LinkedList reversedLinkedList = new LinkedList();
            
        linkedList.addAtEnd("Data");
        linkedList.addAtEnd("Structures");
        linkedList.addAtEnd("and");
        linkedList.addAtEnd("Algorithms");
            
        System.out.println("Initial List");
        linkedList.display();

        System.out.println();
            
        linkedList.reverseList(linkedList.head, reversedLinkedList);
        System.out.println("Reversed List");
        reversedLinkedList.display();
        //#endregion
    }
}