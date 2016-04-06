using System;

namespace TPP.Laboratory.Functional.Lab06
{

    /// <summary>
    /// Try to guess the behavior of this program without running it
    /// </summary>
    class Closures
    {

        /// <summary>
        /// Version with a single method
        /// </summary>
        static Func<int> Counter()
        {
            int counter = 0;
            return () => ++counter;
        }

        /// <summary>
        /// Version with three methods
        /// </summary>
        static void Counter2(out Func<int> inc, out Func<int> dec, out Action<int> ass)
        {
            int counter = 0;
            inc = () => ++counter;
            dec = () => --counter;
            ass = b => counter = b;
        }

        static Tuple<Func<int>, Func<int>, Action<int>> CounterWithTuple()
        {
            int counter = 0;
            return new Tuple<Func<int>, Func<int>, Action<int>>(
                () => ++counter,
                () => --counter,
                x => counter = x
                );
        }


        static void Main()
        {
            Func<int> counter = Counter();
            Console.WriteLine(counter());
            Console.WriteLine(counter());

            Func<int> anotherCounter = Counter();
            Console.WriteLine(anotherCounter());
            Console.WriteLine(anotherCounter());

            Console.WriteLine(counter());
            Console.WriteLine(counter());

            /*
            Func<int> Increment;
            Func<int> Decrement;
            Action<int> Assigment;

            Counter2(out Increment, out Decrement, out Assigment);
            Console.WriteLine(Increment());
            Console.WriteLine(Increment());
            Console.WriteLine(Increment());
            Console.WriteLine(Increment());
            Console.WriteLine(Decrement());
            Console.WriteLine(Decrement());
            Console.WriteLine(Decrement());
            Assigment(213423);
            Console.WriteLine(Decrement());
             */


            var tuple = CounterWithTuple();
            Console.WriteLine(tuple.Item1());
            Console.WriteLine(tuple.Item2());

            tuple.Item3(10);

            Console.WriteLine(tuple.Item1());
            Console.WriteLine(tuple.Item2());


        }
    }

}
