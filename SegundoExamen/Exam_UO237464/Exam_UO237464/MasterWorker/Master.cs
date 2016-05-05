using System;
using System.Collections.Generic;
using System.Threading;

namespace MasterWorker {

    public class Master {

        private string[] vector;

        private int numberOfThreads;

        private Dictionary<string, long> dicMaster;

        public Master(string[] vector, int numberOfThreads, Dictionary<string, long> dicMaster)
        {
            if (numberOfThreads < 1 || numberOfThreads > vector.Length)
                throw new ArgumentException("The number of threads must be lower or equal to the number of elements in the vector.");
            this.vector = vector;
            this.numberOfThreads = numberOfThreads;
            this.dicMaster = dicMaster;
        }

        public Dictionary<string, long> ComputeModulus() {
            Worker[] workers = new Worker[this.numberOfThreads];
            int itemsPerThread = this.vector.Length/numberOfThreads;
            for(int i=0; i < this.numberOfThreads; i++)
                workers[i] = new Worker(this.vector, 
                    i*itemsPerThread, 
                    (i<this.numberOfThreads-1) ? (i+1)*itemsPerThread-1: this.vector.Length-1, dicMaster // last one
                    );

            Thread[] threads = new Thread[workers.Length];
            for(int i=0;i<workers.Length;i++) {
                threads[i] = new Thread(workers[i].Compute); 
                threads[i].Name = "Worker Vector Modulus " + (i+1); 
                threads[i].Priority = ThreadPriority.BelowNormal; 
                threads[i].Start();  
            }

            //To obtain the same result with differents threads
            foreach (var t in threads) {
                t.Join();
            }

            return dicMaster;
        }

    }

}
