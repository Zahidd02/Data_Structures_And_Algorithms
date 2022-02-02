using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List_Project
{
    public class Node
    {
        public String data;
        public Node next;
        public Node(String data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
