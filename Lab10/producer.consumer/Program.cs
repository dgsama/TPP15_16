﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPP.Laboratory.Concurrency.Lab10 {

    class Program {
        /*
         * Can you tell why this program blocks after running several iterations? Can you fix the problem?
         */
        static void Main() {
            Queue<Product> queue = new Queue<Product>();
            Producer producer = new Producer(queue);
            Consumer consumer = new Consumer(queue);
            new Thread(producer.Run).Start();
            Thread.Sleep(2000);
            new Thread(consumer.Run).Start();
        }

    }
}
