using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class OrderedLinkedList
    {
        OrderedNode head=null;
        public int[] insertArray = new int[10];
        public int position = 0;

        public int InsertPosition(int newNodeData)
        {
            if (position == 0)
            {
                insertArray[position] = newNodeData;
                return position;
            }
            while (newNodeData < insertArray[position])
            {
                position++;
            }
            insertArray[position] = newNodeData;
            return position;
        }
        //To Insert a node at a given position
        public int InsertNewNode(int newNodeData)
        {
            
            OrderedNode newNode = new OrderedNode(newNodeData);
            OrderedNode temp = null, next = null, prevNode = null;
            int pos = InsertPosition(newNodeData);
            if (pos==0)
            {
                temp = this.head;
                newNode.next = this.head;
                this.head = newNode;
                position++;
                return pos;

            }
            else if (pos > 0)
            {
                prevNode = this.head;
                while (pos != 0)
                {
                    if (pos == 1)
                    {
                        //OrderedNode newNode = new OrderedNode(newNodeData);
                        newNode.next = prevNode.next;
                        prevNode.next = newNode;
                        return pos;
                        break;
                    }
                    prevNode = prevNode.next;
                    pos--;
                }
                if (position != 1)
                {
                    Console.WriteLine("Invalid Postion");
                    return pos;
                }
                return pos;
            }
            else
            {
                Console.WriteLine("Invalid Postion");
                return pos;
            }
        }
       
        public void sortElement()
        {
            if (this.head == null)
            {
                return;
            }
            var temp = this.head;
            OrderedNode hold = null;
            this.head = null;
            // iterate linked list nodes and add in sorted order
            while (temp != null)
            {
                hold = temp;
                temp = temp.next;
                hold.next = null;
                // Logic to add node
                if (this.head == null)
                {
                    this.head = hold;
                }
                else if (this.head.data >= hold.data)
                {
                    hold.next = this.head;
                    this.head = hold;
                }
                else
                {
                    var temp1 = this.head;
                    // Finding location of inserting nodes
                    while (temp1.next != null &&
                           temp1.next.data < hold.data)
                    {
                        
                        temp1 = temp1.next;
                    }
                    hold.next = temp1.next;
                    temp1.next = hold;
                }
            }
        }
        public void Displaylist()
        {
            OrderedNode temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
