using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConcurrentQueue;

namespace TPP.Laboratory.Concurrency.Lab10
{

    class Consumer
    {

        private concurrentQueue<Product> queue;

        public Consumer(concurrentQueue<Product> queue)
        {
            this.queue = queue;
        }

        public void Run()
        {
            Random random = new Random();
            bool finish = true;
            while (finish)
            {
                Console.WriteLine("- Dequeuing a product...");
                Product product = null;
                lock (queue)
                {

                    //Antes habia un while en vez del if, se añadio el if y el else.
                    if (queue.IsEmpty())
                    {

                        Thread.Sleep(20);
                    }
                    else
                    {
                        product = queue.Dequeue();
                        if (product.ProductID == 1000)
                        {
                            finish = false;
                        }

                    }
                }
                Console.WriteLine("- Dequeued {0}.", product);
                Thread.Sleep(20);
            }
        }

    }
}
