using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01Employee;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Hideo", "Kojima", "Snake", 5, 0);


            Employee e2 = new Employee
            {
                name = "Konami"
            };


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e + " was fired by " + e2.name);
            Console.ResetColor();

            Videogame v = new Videogame("Metal Gear Solid v", 1000, 9001,
                Videogame.Plataforma.XBOX, 2015, "Action-adventure", "KONAMI");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);

            v.AmericaSales = 4;
            v.EuropeSales = 3;

            Console.WriteLine("The game has more sales in America (" + v.AmericaSales + " millions) "
                + "than in Europe(" + v.EuropeSales + " millions).");
            v.JapanSales = 10;
            Console.WriteLine("In Japan sales " + v.JapanSales + " millions of copies.");


            Console.ResetColor();

            LinkedList list = new LinkedList();

            list.add(1);
            list.add(2);
            list.add(3);
            list.add(5);
            list.add(7);
            list.add(11);

            Console.WriteLine(list);
            Console.WriteLine("The size of the list is = " + list.NumberOfELements());

            list.remove(4);
            list.remove(0);

            Console.WriteLine(list);
            Console.WriteLine("The size of the list is = " + list.NumberOfELements());



        }
    }
}
