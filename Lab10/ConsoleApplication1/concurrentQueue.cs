using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    class concurrentQueue<T>
    {
        public int numberOfElements { get; set; }
        private MyLinkedList<T> innerList = new MyLinkedList<T>();

        public bool IsEmpty()
        {
            return (numberOfElements == 0);
        }

        public void Enqueue(T elem)
        {
            lock (innerList)
            {
                innerList.add(elem);
                numberOfElements++;
            }
        }

        public void Dequeue()
        {
            lock (innerList)
            {
                if (!IsEmpty())
                {
                    innerList.removeByIndex(numberOfElements--);
                    numberOfElements--;
                }
            }
        }

        public T Peek()
        {
            T value = default(T);
            lock (innerList)
            {
                if (!IsEmpty())
                {
                    value = innerList.getByIndex(numberOfElements--);
                }
            }
            return value;
        }


    }
}
