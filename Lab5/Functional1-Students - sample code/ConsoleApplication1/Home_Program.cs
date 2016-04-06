using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Home_Program
    {
        static void Main(string[] args)
        {
        }
        /*
                Find: Returns the first element in a collection that fulfils a specific predicate.
         * If no suitable element exists, the default value is returned.
        o Test it to search for employees by name and by NIF numbers ending in a 
         * given letter. Test to search for names that are not possible for employees.
        o Test it to search PS3 games, and for games with a non-existing Genre (like “MusicalRPG”).
           */


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
