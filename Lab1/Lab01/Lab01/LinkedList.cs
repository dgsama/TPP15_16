using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class LinkedList
    {

        public class Node
        {
            public int value;
            public Node next;

            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }


        private Node head;
        private int size;

        public LinkedList()
        {
            size = 0;
        }


        public bool isEmpty()
        {
            return size == 0;
        }

        public void addFirst(int value)
        {
            head = new Node(value, null);
            size++;
        }

        public void add(int value)
        {
            if (isEmpty())
            {
                addFirst(value);
            }
            else {
                Node last = (Node)getNode(size - 1);
                last.next = new Node(value, null);
                size++;
            }
        }


        public int remove(int index)
        {
            int value;
            if (index > size)
            {
                throw new IndexOutOfRangeException("The position is not valid");
            }
            else if (isEmpty())
            {
                return 0;
            }
            else if (index == -1)
            {
                return 0;
            }
            else if (index == 0)
            {
                value = head.value;
                head = head.next;
            }
            else {
                Node node = getNode(index - 1);
                value = node.next.value;
                node.next = node.next.next;
            }
            size--;
            return value;

        }

        public Node getNode(int index)
        {
            int position = 0;
            Node node = this.head;
            while (position < index)
            {
                node = node.next;
                position++;
            }
            return node;
        }

        public int indexOf(int value)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (value == getNode(i).value)
                    index = i;
            }
            return index;

        }

        public int NumberOfELements()
        {
            return size;
        }

        public override string ToString()
        {
            string output = null;

            for (int i = 0; i < size; i++) {
                output += getNode(i).value + "  ";
            }

            return output;
        }


    }
}
