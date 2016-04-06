using System.Linq;
using System.Collections.Generic;
using System;
namespace TPP.Laboratory.Functional.Lab07
{

    static public class Functions
    {

        public static IEnumerable<TResult> Map<TElement, TResult>(this IEnumerable<TElement> collection,
            Func<TElement, TResult> function)
        {

            TResult[] result = new TResult[collection.Count()];
            int i = 0;
            foreach (TElement x in collection)
                result[i++] = function(x);
            return result;
        }

        //CONVERTIR MAP A LAZY
        public static IEnumerable<TResult> MapLazy<TElement, TResult>(this IEnumerable<TElement> c, Func<TElement, TResult> f)
        {
            foreach (TElement x in c)
                yield return f(x);
            yield break;
        }

        public static void ForEach<TElement>(this IEnumerable<TElement> c, Action<TElement> action){
            foreach (TElement x in c)
                action(x);
        }


    }
}
