package LinkedList_Exercise;

public class LinkedList {
    public Node head;
	public Node tail;

	public void addAtEnd(String city) {
		Node x = new Node(city);

		if (this.head == null) {
            this.head = this.tail = x;
        }
		else {
			this.tail.next = x;
			this.tail = x;
		}
	}

	public void addAtBeginning(String city) {
		Node x = new Node(city);

		if (this.head == null) {
            this.head = this.tail = x;
        }
		else {
			x.next = this.head;
			this.head = x;
		}
	}

	public void display() {
		Node temp = this.head;

		while (temp != null) {
			System.out.println(temp.data);
			temp = temp.next;
		}
	}

	public Node find(String data) {
		Node temp = this.head;
		Node result = null;
	
		while (temp != null) {
			if(temp.data.equals(data)) {
				result = temp;
				break;
			}
			temp = temp.next;
		}
		return result;
	}

	public void insert(String data, String dataBefore) {
		Node node = new Node(data);
	
		if (this.head == null)
			this.head = this.tail = node;
		else {
	
			Node nodeBefore = this.find(dataBefore);
			if (nodeBefore != null) {
	
				Node temp = nodeBefore.next;
				nodeBefore.next = node;
				node.next = temp;
	
				if (nodeBefore == this.tail) {
					this.tail = node;	
				}
			} else
				System.out.println("Node not found");
		}
	}

	public void delete(String data) {
		if (this.head == null)
			System.out.println("List is empty");
		else {
	
			Node node = this.find(data);

			if (node == null)
				System.out.println("Node not found");

			else if (node == this.head) {
				this.head = this.head.next;
				node.next = null;

				if (node == this.tail)
					tail = null;
			} 
			else {

				Node nodeBefore = null;
				Node temp = this.head;
				while (temp != null) {
					if (temp.next == node) {
						nodeBefore = temp;
						break;
					}
					temp = temp.next;
				}

				nodeBefore.next = node.next;
				if (node == this.tail)
					this.tail = nodeBefore;
					node.next = null;
			}
		}
	}

	public int findPosition(String data) {
		int count = 0;
		Node temp = this.head;
		while(temp != null) {
			count++;
			if(temp.data.equals(data)) {
				return count;
			}
			else {
				temp = temp.next;
			}
		}
		return 0;
	}

	public void swapAdjecent(LinkedList x, int n) {
		Node temp = x.head;
		for (int i = 1; i <= n; i++) {
			while (temp.next != null) {
				temp.next.data = temp.data;
			}
			temp = temp.next;
		}
	}

	//#region Left/Right Shift Problem Lex
	public void shiftListRight(LinkedList x, int n) {
        for (int i = 1; i <= n; i++) { //For shifting individual element tail to head
            Node tempHead = x.head;
            Node counter = x.head;
            Node newTail = null;

            while (counter != null) {
                if(counter.next.next == null) {
                    newTail = counter;
                    break;
                }
                counter = counter.next;
            }
			
            x.head = x.tail;
            x.head.next = tempHead;
            x.tail = newTail;
            x.tail.next = null;
        }
    }

	public void shiftListLeft(LinkedList x, int n) {
        //Implement your code here
            for (int i = 1; i <= n; i++) { //For shifting individual element head to tail
                Node tempHead = x.head;
                Node tempTail = x.tail;

                x.head = tempHead.next;
                tempTail.next = tempHead;
                x.tail = tempTail.next;
                x.tail.next = null;
            }
            
    }
	//#endregion

	//#region Reverse Linked List Problem Lex
	public void reverseList(Node head, LinkedList reversedLinkedList) {
        //Implement your code here  
        Node temp = head;
        while(temp != null) {
            Node x = new Node(temp.data);
            if(reversedLinkedList.head == null) {
                reversedLinkedList.head = x;
                reversedLinkedList.tail = x;
            }
            else {
                x.next = reversedLinkedList.head;
                reversedLinkedList.head = x;
            }
            temp = temp.next;
        }
    }
	//#endregion
}
