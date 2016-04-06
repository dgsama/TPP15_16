using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPP.Laboratory.Functional.Lab01;

namespace Factories
{
    class Program
    {
        public static void Show<T>(T[] collection)
        {
            foreach (T elem in collection)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var arr1 = EmployeeFactory.CreateEmployees(10);
            var arr2 = VideogameFactory.CreateRandomVideoGames(10);

            Show(arr1);
            Show(arr2);
        }
    }
}
