using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03Work
{
    public class LinkedStack
    {
        public uint MaximumNumberOfElements { get; set; }

        LinkedList list = new LinkedList();

        public LinkedStack(uint MaximumSize) {
            this.MaximumNumberOfElements = MaximumSize;
        }

        public void push(Object element)
        {
            if (list.size < MaximumNumberOfElements)
            {
                list.add(element);
            }
            else {
                throw new InvalidOperationException("The stack is full of stars!");
            }
        }

        public Object peek()
        {
            checkNotEmpty();
            return list.get(list.size - 1);
        }


        public Object pop()
        {
            checkNotEmpty();
            return list.removeByIndex(list.size-1);
        }

        private void checkNotEmpty()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("The stack is empty");
            }
        }


        public int size()
        {
            return list.size;
        }


        public bool isEmpty()
        {

            return list.isEmpty();
        }


    }
}
