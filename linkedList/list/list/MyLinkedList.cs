using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        public class Node
        {
            public T value;
            public Node next;

            public Node(T value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }

        Node head;
        public int size;

        public MyLinkedList()
        {
            size = 0;
        }
        /// <summary>
        /// Create a new list with values from a set.
        /// </summary>
        /// <param name="values"></param>
        public MyLinkedList(IEnumerable<T> values)
        {
            foreach (T value in values)
            {
                add(value);
            }
        }

        public void addFirst(T value)
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


        public void add(T value)
        {
            if (isEmpty())
            {
                addFirst(value);
            }
            else
            {
                Node last = (Node)getNode(size - 1);
                last.next = new Node(value, null);
                size++;
            }
        }


        public T remove(T value)
        {
            return removeByIndex(indexOf(value));

        }


        public bool isEmpty()
        {
            return (size == 0);
        }


        public void addByIndex(int index, T value)
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
            else
            {
                Node node = getNode(index - 1);
                node.next = new Node(value, node.next);
                size++;
            }

        }


        public T removeByIndex(int index)
        {
            T value = default(T);

            if (index > size)
            {
                throw new IndexOutOfRangeException("The position is not valid");
            }
            else if (isEmpty())
            {
                return default(T);
            }
            else if (index == -1)
            {
                return default(T);
            }
            else if (index == 0)
            {
                value = head.value;
                head = head.next;
            }
            else
            {
                Node node = getNode(index - 1);
                value = node.next.value;
                node.next = node.next.next;
            }
            size--;
            return value;

        }


        public int indexOf(T value)
        {
            int index = -1;
            for (int i = 0; i < size; i++)
            {
                if (value.Equals((getNode(i).value)))
                    index = i;
            }
            return index;

        }


        public T getByIndex(int index)
        {
            return getNode(index).value;
        }


        public T set(int index, T value)
        {
            Node node = getNode(index);
            node.value = value;
            return node.value;
        }


        public bool contains(T value)
        {
            return (indexOf(value) >= 0);
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < size; i++)
            {
                output += getNode(i).value + "  ";
            }

            return output;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return getByIndex(i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }

    class LinkedListIEnumerator<T> : IEnumerator<T>
    {
        private MyLinkedList<T> list;
        private int pos;

        public LinkedListIEnumerator(MyLinkedList<T> list)
        {
            this.list = list;
            this.pos = -1;
        }

        public T Current
        {
            get { return list.getByIndex(pos); }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose() { throw new NotImplementedException(); }

        public bool MoveNext()
        {
            if (pos++ != list.size - 1)
            {
                return true;
            }
            else { return false; }
        }

        public void Reset() { this.pos = -1; }
    }

}