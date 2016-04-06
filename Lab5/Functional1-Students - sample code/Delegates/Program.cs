using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        static void Main(string[] args)
        {
            Func<double, double> f = Program.Half;
            Console.WriteLine(f(4));
            f = Program.Square;
            Console.WriteLine(f(4));

            double[] d = { 1.0, 2.0, 3.0, 66.0 };

            // LANDA EXPRESSIONS

            Program.Show(MyMap(param => param / 2, d));
            Program.Show(MyMap(param => Math.Pow(param, 2), d));

            string[] str = { "ASDAS", "DDFKSAF", "SDAF", "DKFS" };
            Program.Show(str);

            Program.Show(MyMap(param => param.Length, str));
        }

        public static void Show<T>(IEnumerable<T> collection)
        {
            foreach (T elem in collection)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }

        // Create the Half and Square methods for doubles
        public static double Half(double d)
        {
            double aux = d / 2;
            return aux;
        }

        public static double Square(double d)
        {
            double aux = Math.Pow(d, 2);
            return aux;
        }

        //Create a delegate able to store Pow and Half

        //delegate double Function_Param_Double_Return_Double(double d);

        static IEnumerable<TReturn> MyMap<TParam, TReturn>(Func<TParam, TReturn> f, IEnumerable<TParam> param)
        {
            List<TReturn> list = new List<TReturn>();
            foreach (var e in param)
            {
                list.Add(f(e));
            }
            return list;
        }


        public static T Find<T>(Predicate<T> f, IEnumerable<T> a)
        {
            foreach (T t in a)
            {
                if (f(t))
                {
                    return t;
                }
            }
            return default(T);
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

        static TResult Reduce<TParam, TResult>(Func<TResult, TParam, TResult> function,
    IEnumerable<TParam> c, TResult seed = default(TResult))
        {
            TResult value = seed;

            foreach (var elem in c)
            {
                value = function(value, elem);
            }
            return value;
        }

    }
}