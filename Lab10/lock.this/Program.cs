using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LockThis
{
    /**
     * This example shows the consequences of using lock(this) instead of a private ad-hoc object as a blocker in certain situations.
     */
    class LockThis
    {
        private List<int> locker = new List<int>();
        public void ThreadSafeOperation()
        {
            lock (locker)//Puedes usar esto creandolo arriba o this(mejor esto)
            {
                Console.WriteLine("Secondary thread starts");
                while (true)
                {
                    Thread.Sleep(1000);//Simulates processing
                    Console.WriteLine("Secondary thread iterates");
                }
            }
        }
        static void Main(string[] args)
        {
            LockThis oneObject = new LockThis();
            Thread thread = new Thread(oneObject.ThreadSafeOperation);

            Console.WriteLine("Main thread starts");
            thread.Start();
            Thread.Sleep(3000);//Simulates processing
            Console.WriteLine("Main thread is about to execute its only operation");
            lock (oneObject) //oneObject is already blocked by the secondary thread!
            {
                Thread.Sleep(1000);//Simulates processing
                Console.WriteLine("Main thread finishes its operations");
            }
            Console.WriteLine("*** MAIN THREAD ENDS ***");
        }
    }
}