using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPP.Laboratory.Functional.Lab08
{

    class Query
    {

        private Model model = new Model();

        private static void Show<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of items in the collection: {0}.", collection.Count());
        }

        static void Main(string[] args)
        {
            Query query = new Query();
            Console.WriteLine(" QUERY 1");
            query.Query1();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\n QUERY 2");
            query.Query2();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n QUERY 3");
            query.Query3();

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("\n QUERY 4");
            query.Query4();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n QUERY 5");
            query.Query5();
            Console.WriteLine(" \n");

            Console.ForegroundColor = ConsoleColor.Red;
            query.Homework1();
            Console.WriteLine(" \n");


            Console.ForegroundColor = ConsoleColor.White;
            query.Homework2();
            Console.WriteLine(" \n");


            Console.ForegroundColor = ConsoleColor.White;
            query.Homework3();
            Console.WriteLine(" \n");


            Console.ForegroundColor = ConsoleColor.Red;
            query.Homework4();
            Console.WriteLine(" \n");


            Console.ForegroundColor = ConsoleColor.White;
            query.Homework5();


            Console.WriteLine("\n");
            Console.ResetColor();

        }

        private void Query1()
        {
            // Modify this query to show the names of the employees older than 50 years
            var employees = model.Employees.Where(e => e.Age > 50).Select(e => e.Name);
            Console.WriteLine("Employees:");
            Show(employees);
        }

        //CLASS FOR QUERY 2
        /* class NameAndEmail
         {
             string Name { get; set; }
             string Email { get; set; }

             public NameAndEmail(string Name, string Email)
             {
                 this.Name = Name;
                 this.Email = Email;
             }
         }*/

        private void Query2()
        {
            // Show the name and email of the employees who work in Asturias.

            //THIS SOLUTION NEEDS A CLASS
            /* var employees = model.Employees.Where(e => e.Province == "Asturias").Select(e => new NameAndEmail(e.Name, e.Email));*/

            //THIS IS AN ANONY MOUS CLASS
            var employees = model.Employees.Where(e => e.Province == "Asturias").Select(e =>
                new { e.Name, ASI_SE_CAMBIA_EL_TO_STRING_ANONIMO = e.Email });

            Console.WriteLine("Employees:");
            Show(employees);
        }

        // Notice: from now on, check out http://msdn.microsoft.com/en-us/library/9eekhta0.aspx



        /// NEW METHODS FOR LINK
        /// 
        /// --Any(predicate): Tells if there is at least one element in the enumerable that
        ///                   fulfills the predicate(true/false).
        ///
        /// --Count(predicate): size of the collection that satisfy the predicate(true/false).
        /// --Count(): size.
        ///
        /// --First(Predicate): Show the first element that satisfy the predicate.
        ///




        private void Query3()
        {
            // Show the names of the departments with more than one employee 18 years old and beyond; 
            // the department should also have any office number starting with "2.1"

            var step1 = model.Departments.Where(d => d.Employees.Count(e => e.Age > 18) > 1);
            var step2 = step1.Where(d => d.Employees.Any(e => e.Office.Number.StartsWith("2.1"))).Select(d => new { d.Name });

            Console.WriteLine("Departments:");
            Show(step2);
        }

        private void Query4()
        {
            // Show the phone calls of each employee. 
            // Each line should show the name of the employee and the phone call duration in seconds.
            var result = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber,
                (call, e) => new { e.Name, call.Seconds });


            Console.WriteLine("Phone Calls:");
            Show(result);
        }

        private void Query5()
        {
            // Show, grouped by each province, the name of the employees 
            // (both province and employees must be shown lexicographically ordered)

            //ESTA FUNCIONA
            /*
            var result = model.Employees.Select(e => new { e.Province, e.Name }).OrderBy(e => e.Province).ThenBy(e => e.Name);
            
            Console.WriteLine("Employees:");
            Show(result);
            
             */

            var step1 = model.Employees.GroupBy(e => e.Province);
            var result = step1.OrderBy(x => x.Key);
            foreach (var x in result)
            {
                foreach (var e in x.OrderBy(e => e.Name))
                {
                    Console.WriteLine(e.Province + " " + e.Name);
                }
            }
        }

        /************ Homework **********************************/

        private void Homework1()
        {
            Console.WriteLine("\n HOMEWORK 1");
            // Show, ordered by age, the names of the employees in the Computer Science department, 
            // who have an office in the Faculty of Science, 
            // and who have done phone calls longer than one minute

            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber, (call, e) =>
                new { Name = e.Name, Age = e.Age, Department = e.Department.Name, Office = e.Office.Building, Seconds_of_the_phone_call = call.Seconds });

            var step2 = step1.Where(e => e.Department.Equals("Computer Science") && e.Office.Equals("Faculty of Science") && e.Seconds_of_the_phone_call > 60);
            var result = step2.OrderBy(e => e.Age);

            foreach (var e in result)
            {
                Console.WriteLine(e.Name);
            }
        }

        private void Homework2()
        {
            Console.WriteLine("\n HOMEWORK 2");
            // Show the summation, in seconds, of the phone calls done by the employees of the Computer Science department
            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber, (call, e) => new { e.Name, e.Department, call.Seconds });
            var step2 = step1.Where(e => e.Department.Name.Equals("Computer Science"));
            var seconds = step2.Sum(e => e.Seconds);

            Console.WriteLine("Total seconds : " + seconds + ".");
        }

        private void Homework3()
        {
            Console.WriteLine("\n HOMEWORK 3");
            // Show the phone calls done by each department, ordered by department names. 
            // Each line must show “Department = <Name>, Duration = <Seconds>”
            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber, (call, e) => new { e.Department, call.Seconds });
            var step2 = step1.OrderBy(e => e.Department.Name);
            Show(step2);

        }

        private void Homework4()
        {

            Console.WriteLine("\n HOMEWORK 4");
            // Show the departments with the youngest employee, 
            // together with the name of the youngest employee and his/her age 
            // (more than one youngest employee may exist)

            var step1 = model.Employees.GroupBy(e => e.Department.Name).OrderBy(e => e.Key);

            
            List<string> s = new List<string>();
            int aux = int.MaxValue;

            foreach (var x in step1)
            {
                var age = int.MaxValue;
                var name = "";
                foreach (var e in x)
                {
                    name = e.Department.Name;
                    if (age > e.Age)
                    {
                        age = e.Age;
                    }
                }
                if (age < aux)
                {
                    s.RemoveRange(0, s.Count);
                    s.Add(name);
                    aux = age;
                }else if(age ==aux){
                    s.Add(name);
                }
            }
            Show(s);


        }

        private void Homework5()
        {
            Console.WriteLine("\n HOMEWORK 5");
            // Show the greatest summation of phone call durations, in seconds, 
            // of the employees in the same department, together with the name of the department 
            // (it can be assumed that there is only one department fulfilling that condition)
            var step1 = model.PhoneCalls.Join(model.Employees, call => call.SourceNumber, e => e.TelephoneNumber, (call, e) => new { e.Department, call.Seconds });
            var step2 = step1.GroupBy(e => e.Department.Name).OrderBy(e => e.Key);

            var res1 = "";
            var res2 = 0;

            foreach (var x in step2)
            {
                var sum = 0;
                var name = "";
                foreach (var e in x)
                {
                    name = e.Department.Name;
                    sum = sum + e.Seconds;
                }
                if (sum > res2)
                {
                    res1 = name;
                    res2 = sum;
                }
            }

            Console.WriteLine(res1 + "->" + res2);

        }


    }

}
