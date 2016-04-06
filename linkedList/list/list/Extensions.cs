using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    public static class Extensions
    {
        //MAPS
        public static IEnumerable<TResult> Map<TElement, TResult>(this IEnumerable<TElement> collection,
            Func<TElement, TResult> function)
        {

            TResult[] result = new TResult[collection.Count()];
            int i = 0;
            foreach (TElement x in collection)
                result[i++] = function(x);
            return result;
        }

        public static IEnumerable<TResult> MapLazy<TElement, TResult>(this IEnumerable<TElement> c, Func<TElement, TResult> f)
        {
            foreach (TElement x in c)
                yield return f(x);
            yield break;
        }

        static IEnumerable<TReturn> MyMap<TParam, TReturn>(this IEnumerable<TParam> param, Func<TParam, TReturn> f)
        {
            List<TReturn> list = new List<TReturn>();
            foreach (var e in param)
            {
                list.Add(f(e));
            }
            return list;
        }


        //FOR EACH
        public static void ForEach<TElement>(this IEnumerable<TElement> c, Action<TElement> action)
        {
            foreach (TElement x in c)
                action(x);
        }


        //FILTER
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> a, Predicate<T> f)
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

        //FIND
        public static T Find<T>(this IEnumerable<T> a, Predicate<T> f)
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

        //FIND LAST
        public static T FindLast<T>(this IEnumerable<T> a, Predicate<T> f)
        {
            IEnumerable<T> b = a;
            b.Reverse();

            foreach (T t in b)
            {
                if (f(t))
                {
                    return t;
                }
            }
            return default(T);
        }

        //SHOW
        public static void Show<T>(this IEnumerable<T> collection)
        {
            foreach (T elem in collection)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        //REDUCE 
        static TResult Reduce<TParam, TResult>(this
 IEnumerable<TParam> c, Func<TResult, TParam, TResult> function, TResult seed = default(TResult))
        {
            TResult value = seed;

            foreach (var elem in c)
            {
                value = function(value, elem);
            }
            return value;
        }

        //INVERT
        public static IEnumerable<T> Invert<T>(this IEnumerable<T> items)
        {
            for (int i = items.Count() - 1; i >= 0; i--)
            {
                yield return items.ElementAt(i);
            }
        }


    }
}
