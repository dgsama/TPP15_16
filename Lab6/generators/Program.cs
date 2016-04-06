using System;

namespace TPP.Laboratory.Functional.Lab06
{

    class Program
    {
        static void Main()
        {
            int fibonacciNumber = 20;

            int i = 0;
            foreach (int value in Fibonacci.InfiniteFibonacci())
            {
                Console.Write(value + " ");
                if (++i == fibonacciNumber)
                    break;
            }
            Console.WriteLine();

            i = 0;
            foreach (int value in Fibonacci.InfiniteFibonacci())
            {
                Console.Write(value + " ");
                if (++i == fibonacciNumber)
                    break;
            }
            Console.WriteLine();

            foreach (int value in Fibonacci.FiniteFibonacci(fibonacciNumber))
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();

        }
    }
}
