using System;
using System.Diagnostics;

namespace TPP.Laboratory.Concurrency.Lab10 {

    class Program {

        static void Main() {
            const int value = 100000000;
            const int numberOfThreads = 10000;

            Summation summation = new Summation(value, numberOfThreads);
            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            summation.Compute();
            chrono.Stop();
            Console.WriteLine("Value after decrementing: {0}. Elapsed milliseconds: {1}.", summation.Value, chrono.ElapsedMilliseconds);
        }

    }
}
