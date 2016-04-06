using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensions
{
    class Extensions
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

        static IEnumerable<TReturn> MyMap<TParam, TReturn>(Func<TParam, TReturn> f,this IEnumerable<TParam> param)
        {
            List<TReturn> list = new List<TReturn>();
            foreach (var e in param)
            {
                list.Add(f(e));
            }
            return list;
        }


        //FOR EACH
        public static void ForEach<TElement>(this IEnumerable<TElement> c, Action<TElement> action){
            foreach (TElement x in c)
                action(x);
        }


        //FILTER
        public static IEnumerable<T> Filter<T>(Predicate<T> f, this IEnumerable<T> a)
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
        public static T Find<T>(Predicate<T> f, this IEnumerable<T> a)
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
        public static T FindLast<T>(Predicate<T> f, this IEnumerable<T> a)
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
           static TResult Reduce<TParam, TResult>(Func<TResult, TParam, TResult> function, this 
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
}
