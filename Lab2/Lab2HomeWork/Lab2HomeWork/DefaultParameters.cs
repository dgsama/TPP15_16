using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab2HomeWork
{
    public class DefaultParameters
    {


        /// <summary>
        /// This method should filter all Employess that:
        /// - Have a concrete name.
        /// - Have a certain first surname (same for second)
        /// - Have a NIF that contains a concrete string
        /// 
        /// Comparisons will not be case-sensitive.
        /// 
        /// 
        /// </summary>
        /// <param name="employees">The original Employee collection</param>
        /// <param name="name">Name that an Employee has to have to not to be filtered</param>
        /// <param name="surname1">First Surname that an Employee has to have to not to be filtered</param>
        /// <param name="surname2">Second Surname that an Employee has to have to not to be filtered</param>
        /// <param name="nifContains">String that an Employee's NIF has to have to not to be filtered</param>
        /// <returns>It will only return those employees that fulfill ALL the passed criteria (0, 1 or more can be passed). 
        /// No criteria returns the passed Employee array.</returns>
        /// 
        public static Employee[] Filter(Employee[] employees, string name = "", string surname1 = "", string surname2 = "", string nifContains = "")
        {
            List<Employee> l = new List<Employee>();

            foreach (Employee e in employees)
            {
                if (name != null && name.Length > 0 && !e.Name.ToLower().Equals(name.ToLower())) { continue; }
                if (surname1 != null && surname1.Length > 0 && !e.FirstSurname.ToLower().Equals(surname1.ToLower())) { continue; }
                if (surname2 != null && surname2.Length > 0 && !e.SecondSurname.ToLower().Equals(surname2.ToLower())) { continue; }
                if (nifContains != null && nifContains.Length > 0 && !e.NIF.ToLower().Contains(nifContains.ToLower())) { continue; }
                l.Add(e);
            }

            return l.ToArray();
        }


        /// <summary>
        /// Creates a random Employee array
        /// </summary>
        /// <returns>An employee array</returns>
        public static Employee[] CreateEmployees(int numEmployees = 100)
        {
            string[] names = { "María", "Juan", "Pepe", "Luis", "Carlos", "Miguel", "Cristina" };
            string[] surnames = { "Díaz", "Pérez", "Hevia", "García", "Rodríguez", "Pérez", "Sánchez" };

            Employee[] listing = new Employee[numEmployees];
            Random random = new Random();

            for (int i = 0; i < numEmployees; i++)
                listing[i] = new Employee
                {
                    Name = names[random.Next(0, names.Length)],
                    FirstSurname = surnames[random.Next(0, surnames.Length)],
                    SecondSurname = surnames[random.Next(0, surnames.Length)],
                    NIF = random.Next(9000000, 90000000) + "-" + (char)random.Next('A', 'Z'),
                    //NumberOfHours = i % 2 == 0 ? ContractType.Full : ContractType.Partial,
                };

            return listing;
        }

        /// <summary>
        /// Show an employee collection through the console
        /// </summary>
        public static void Show(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Finish the following code
        /// </summary>
        public static void run()
        {
            Employee[] employees = CreateEmployees();

            Console.WriteLine("Employees whose name is 'Maria':");
            Filter(employees, name: "Maria");

            Console.WriteLine("Employees with its two surnames equal to 'Perez':");
            Filter(employees, surname1: "Perez", surname2: "Perez");

            Console.WriteLine("Employees whose NIF contains 'A':");
            Filter(employees, nifContains: "A");
        }
    }

}

