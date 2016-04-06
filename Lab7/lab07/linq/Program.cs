using System.Collections.Generic;
using System;
using System.Linq;

namespace TPP.Laboratory.Functional.Lab07
{

    class Program
    {

        static void Main()
        {
            IEnumerable<int> integers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            //integers.MapLazy(element => { Console.Write(element + " "); return element; }).Last();

            integers.ForEach(element => Console.WriteLine(element));

        }
    }
}
