﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPP.Laboratory.Concurrency.Lab10
{

    class Consumer
    {

        private Queue<Product> queue;

        public Consumer(Queue<Product> queue)
        {
            this.queue = queue;
        }

        public void Run()
        {
            Random random = new Random();
            while (true)
            {
                Console.WriteLine("- Dequeuing a product...");
                Product product = null;
                lock (queue)
                {

                    //Antes habia un while en vez del if, se añadio el if y el else.
                    if (queue.Count == 0)
                    {

                        Thread.Sleep(100);
                    }
                    else
                    {
                        product = queue.Dequeue();
                    }
                }
                Console.WriteLine("- Dequeued {0}.", product);
                Thread.Sleep(random.Next(300, 700));
            }
        }

    }
}
