using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentQueue
{
    public class concurrentQueue<T>
    {
        public int numberOfElements { get; set; }
        private MyLinkedList<T> innerList = new MyLinkedList<T>();

        public concurrentQueue()
        {
            numberOfElements = 0;
        }

        public bool IsEmpty()
        {
            lock (innerList)
            {
                return (numberOfElements == 0);
            }
        }

        public void Enqueue(T elem)
        {
            lock (innerList)
            {
                innerList.add(elem);
                numberOfElements++;
            }
        }

        public T Dequeue()
        {
            lock (innerList)
            {
                T value = default(T);

                if (!IsEmpty())
                {
                    value = innerList.getByIndex(0);
                    innerList.removeByIndex(0);
                    numberOfElements--;
                }
                return value;
            }
        }

        public T Peek()
        {
            lock (innerList)
            {
                T value = default(T);
                if (!IsEmpty())
                {
                    value = innerList.getByIndex(0);
                }
                return value;
            }
        }
    }
}
