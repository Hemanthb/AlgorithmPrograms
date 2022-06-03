using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class UnorderedWordsList
    {
        Node head;
        //To add or append new node to a list
        public void addNode(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data {0} is added to the list", data);

        }
        //Searches and returns position
        public int Search(string findData)
        {
            int position = 0;
            Node current = this.head;
            while (current != null)
            {
                position++;
                if (current.data == findData)
                {
                    return position;
                    break;
                }
                current = current.next;
            }
            return -1;
        }
        //Removes the node if found
        public void Remove(string find)
        {

            Node current = this.head, prevNode = null;
            while (current != null)
            {
                if(current.data == find)
                {
                    prevNode.next = (Node)current.next;
                    break;
                }
                prevNode = current;
                current = current.next;
                
            }
            
            Console.WriteLine("Required Node deleted");
        }
        public void Displaylist()
        {
            Node temp = this.head;
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
