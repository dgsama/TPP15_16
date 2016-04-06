using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Foo
    {
        public int att = 10;

    }
    class Program
    {

        static void PutAZero(ref Foo number)
        {
            number = null;
        }


        /*Create a function than ask the user for its
         * name and surname and return BOTH values using ref
         * 
         * console.ReadLine();
         * */

        static void ReadConsole(out string name, out string surname)
        {

            Console.WriteLine("Write your name!!");
            name = Console.In.ReadLine();

            Console.WriteLine("Write your surname!!");
            surname = Console.In.ReadLine();

        }
        static void Main(string[] args)
        {
            /*Foo x = new Foo();

            PutAZero(ref x);

            Console.WriteLine(x.att);*/

            string n, s;

            ReadConsole(out n, out s);

            Console.WriteLine(n + ";" + s);

        }
    }
}