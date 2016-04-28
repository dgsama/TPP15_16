using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConcurrentQueue;

namespace TPP.Laboratory.Concurrency.Lab10
{

    class Producer
    {

        private concurrentQueue<Product> queue;
        private int numberOfProductsProduced;


        public void Run()
        {
            Random random = new Random();
            bool finish = true;

            while (finish)
            {
                Product product = new Product(++numberOfProductsProduced);
                if (product.ProductID == 1000) {
                    finish = false;
                }
                Console.WriteLine("+ Enqueuing {0}...", product);
                lock (queue)
                {
                    queue.Enqueue(product);
                }
                Console.WriteLine("+ {0} enqueued.", product);
                Thread.Sleep(30);
            }
        }


        public Producer(concurrentQueue<Product> queue)
        {
            this.queue = queue;
        }
    }
}
