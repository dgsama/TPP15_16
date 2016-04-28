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

        public int Count() {
            lock (innerList)
            {
                return numberOfElements;
            }
        }

        public void IncreaseSize() {
            lock (innerList) {
                numberOfElements++;
            }
        }

        public void DecreaseSize() {
            lock (innerList)
            {
                numberOfElements--;
            }
        }

        public bool IsEmpty()
        {
            lock (innerList)
            {
                return (Count() == 0);
            }
        }

        public void Enqueue(T elem)
        {
            lock (innerList)
            {
                innerList.add(elem);
                IncreaseSize();
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
                    DecreaseSize();
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
