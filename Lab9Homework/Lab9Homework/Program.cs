using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.Laboratory.Concurrency.Lab09;

namespace Lab9Homework
{
    class Program
    {

        static void Main(string[] args)
        {

            // int size = 100000;
            // RandomVector v = new RandomVector(size);
            char[] v = { 'A', 'A', 'T', 'C', 'G', 'A', 'A', 'T', 'C', 'G' };

            Console.WriteLine("Give a string that is compose with 'A', 'T', 'C' and 'G'");

            string gen = Console.ReadLine().ToUpper();


            Master master = new Master(v, 1);
            DateTime before = DateTime.Now;
            double result = master.ComputeModulus(gen);
            DateTime after = DateTime.Now;
            Console.WriteLine("Result with one thread: {0:N2}.", result);
            Console.WriteLine("Elapsed time: {0:N0} ticks.",
                (after - before).Ticks);

            master = new Master(v, 4);
            before = DateTime.Now;
            result = master.ComputeModulus(gen);
            after = DateTime.Now;
            Console.WriteLine("Result with 4 threads: {0:N2}.", result);
            Console.WriteLine("Elapsed time: {0:N0} ticks.",
                (after - before).Ticks);
        }

    }
}
