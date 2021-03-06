﻿using System;
using System.Threading;

namespace TPP.Laboratory.Concurrency.Lab09
{

    public class Master
    {

        private char[] vector;

        private char[] gen;

        private int numberOfThreads;

        public Master(char[] vector, int numberOfThreads, string gen)
        {
            if (numberOfThreads < 1 || numberOfThreads > vector.Length)
                throw new ArgumentException("The number of threads must be lower or equal to the number of elements in the vector.");
            this.vector = vector;
            this.numberOfThreads = numberOfThreads;
            this.gen = gen.ToCharArray();
        }

        public double ComputeModulus()
        {
            Worker[] workers = new Worker[this.numberOfThreads];
            int itemsPerThread = this.vector.Length / numberOfThreads;
            for (int i = 0; i < this.numberOfThreads; i++)
                workers[i] = new Worker(this.vector,
                    i * itemsPerThread,
                    (i < this.numberOfThreads - 1) ? (i + 1) * itemsPerThread : this.vector.Length - gen.Length, gen);

            Thread[] threads = new Thread[workers.Length];
            for (int i = 0; i < workers.Length; i++)
            {
                threads[i] = new Thread(workers[i].Compute);
                threads[i].Name = "Worker Vector Modulus " + (i + 1);
                threads[i].Priority = ThreadPriority.BelowNormal;
                threads[i].Start();
            }

            //To obtain the same result with differents threads
            foreach (var t in threads)
            {
                t.Join();
            }

            long result = 0;
            foreach (Worker worker in workers)
            {
                result += worker.Result;
            }
            return result;
        }

    }

}
