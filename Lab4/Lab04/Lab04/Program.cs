using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            Console.WriteLine("a=" + a + "b=" + b);

            Swap(ref a, ref b);

            Console.WriteLine("a=" + a + "b=" + b);

            Console.WriteLine(Maximum(a, b));
            Console.WriteLine(Maximum2(a, b));
            Console.WriteLine(Maximum3(a, b));

            var rx = Maximum(3, 5);
            var rx2 = Maximum2(3, 5);
            var rx3 = Maximum3(3, 5);
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }

        public static T Maximum<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;

            /*if(a.compareTo(b) > 0){
            return a;
            }
            else{return b;}*/
        }

        public static IComparable<T> Maximum2<T>(IComparable<T> a, IComparable<T> b)
        {
            return a.CompareTo((T)b) > 0 ? a : b;
        }

        public static IComparable Maximum3(IComparable a, IComparable b)
        {
            return a.CompareTo(b) > 0 ? a : b;

        }
    }
}
