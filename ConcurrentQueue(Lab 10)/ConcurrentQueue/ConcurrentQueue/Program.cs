using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TPP.Laboratory.Concurrency.Lab10;

namespace ConcurrentQueue
{
    class Program
    {
        static void Main()
        {
            concurrentQueue<Product> queue = new concurrentQueue<Product>();
            Producer producer = new Producer(queue);
            Consumer consumer = new Consumer(queue);
            new Thread(producer.Run).Start();
            Thread.Sleep(200);
            new Thread(consumer.Run).Start();
        }
    }
}
