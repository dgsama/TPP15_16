using Lab01Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        /// <summary>
        ///First program. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            long number = 1;
            Videogame v = new Videogame();

            for (int i = 0; i < 32; i++)
            {
                number *= 2;
                v.Stock = number;
            }

            /* Console.BackgroundColor = ConsoleColor.Blue;
             Console.ForegroundColor = ConsoleColor.Yellow;
             Console.WriteLine(v.Stock);

             Console.ResetColor();*/

            Employee e = new Employee("A", "b", "c", 5, 3);

        }
    }
}
