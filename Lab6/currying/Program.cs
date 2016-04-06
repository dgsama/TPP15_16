using System;
using System.Collections.Generic;

namespace TPP.Laboratory.Functional.Lab06
{

    class Program
    {

        static int Addition(int a, int b)
        {
            return a + b;
        }
        static Func<int, int> CurryfyingAddition(int a)
        {
            return b => a + b;
        }

        static Predicate<int> GreaterThan(int a)
        {
            return b => a < b;
        }

        static IEnumerable<TReturn> MyMap<TParam, TReturn>(Func<TParam, TReturn> f, IEnumerable<TParam> param)
        {
            List<TReturn> list = new List<TReturn>();
            foreach (var e in param)
            {
                list.Add(f(e));
            }
            return list;
        }

        public static IEnumerable<T> Filter<T>(Predicate<T> f, IEnumerable<T> a)
        {
            List<T> ret = new List<T>();
            foreach (T t in a)
            {
                if (f(t))
                {
                    ret.Add(t);
                }
            }
            return ret;
        }



        static void Main()
        {
            var increment = CurryfyingAddition(1);

            Console.WriteLine(Addition(1, 2));
            Console.WriteLine(CurryfyingAddition(1)(2));
            Console.WriteLine(increment(100));

            int[] d = { 1, 2, 3, 66 };
            Program.Show(MyMap(increment, d));

            int[] aux = new int[10];
            var random = new Random();
            var col = MyMap(x => random.Next(-100, 100), aux);

            Show(MyMap(increment, col));

            var greater = GreaterThan(0);
            Show(Filter(greater, col));
        }

        public static void Show<T>(IEnumerable<T> collection)
        {
            foreach (T elem in collection)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

    }
}
