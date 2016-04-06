using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("LINKED LIST TEST\n\n");
            Console.ResetColor();

            LinkedList linkedlista = new LinkedList();

            Videogame v = new Videogame("Battlefront", 0, 90000, Videogame.Plataforma.XBOX, 2015, "action", "EA");

            Employee e1 = new Employee("John", "Snow", "OfTheNightWatch", "DEAD", 5);

            linkedlista.add(v);
            linkedlista.add(e1);
            linkedlista.add("Hello i'm a string");
            linkedlista.add(14);
            linkedlista.add(14.67);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(linkedlista.ToString() + "\n");
            Console.WriteLine("The size of the list is: " + linkedlista.size + "\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("COUNT WORD TEST\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            String phrase = "Tis sentence is for prove that the method count words works";
            Console.WriteLine("The number of words is : " + phrase.ContarPalabras() + "\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FILTER TEST\n");
            Console.ResetColor();

            /// FILTER
            
            Employee[] list = DefaultParameters.CreateEmployees();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Employees whose name is 'Maria':\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Employee e in DefaultParameters.Filter(list, name: "María"))
                Console.WriteLine(e.ToString() + "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Employees with its two surnames equal to 'Pérez':\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Employee e in DefaultParameters.Filter(list, surname1: "Pérez", surname2: "Pérez"))
                Console.WriteLine(e.ToString() + "\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Employees whose NIF contains 'A':\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (Employee e in DefaultParameters.Filter(list, nifContains: "A"))
                Console.WriteLine(e.ToString() + "\n");


            Console.ResetColor();


        }
    }
}
