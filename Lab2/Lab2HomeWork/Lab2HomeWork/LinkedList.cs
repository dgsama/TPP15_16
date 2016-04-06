using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2HomeWork
{
    public class LinkedList
    {
        public class Node
        {
            public Object value;
            public Node next;

            public Node(Object value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }

        Node head;
        public int size;

        public LinkedList()
        {
            size = 0;
        }

        public void addFirst(Object value)
        {
            head = new Node(value, null);
            size++;
        }

        /**
         * Returns the object at pos position
         * 
         * @param index
         * @return
         */
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


        public void add(Object value)
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


        public Object remove(Object value)
        {
            return removeByIndex(indexOf(value));

        }


        public bool isEmpty()
        {
            return (size == 0);
        }


        public void addByIndex(int index, Object value)
        {
            Node aux;
            if (index < 0 && index > size)
            {
                throw new IndexOutOfRangeException("The position is not valid");
            }
            else if (index == 0)
            {
                aux = head;
                addFirst(value);
                getNode(index).next = aux;
            }
            else {
                Node node = getNode(index - 1);
                node.next = new Node(value, node.next);
                size++;
            }

        }


        public Object removeByIndex(int index)
        {
            Object value;
            if (index > size)
            {
                throw new IndexOutOfRangeException("The position is not valid");
            }
            else if (isEmpty())
            {
                return null;
            }
            else if (index == -1)
            {
                return null;
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


        public int indexOf(Object value)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (value.Equals((getNode(i).value)))
                    index = i;
            }
            return index;

        }


        public Object get(int index)
        {
            return getNode(index).value;
        }


        public Object set(int index, Object value)
        {
            Node node = getNode(index);
            node.value = value;
            return node;
        }


        public bool contains(Object value) {
            return (indexOf(value) >= 0);
        }

        public override string ToString()
        {
            string output = null;

            for (int i = 0; i < size; i++)
            {
                output += getNode(i).value + "  ";
            }

            return output;
        }




    }
}
