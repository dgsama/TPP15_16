using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2HomeWork
{
    public class Employee
    {
        public double NumberOfHours { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string NIF { get; set; }
        


        public Employee(string name, string FirstSurname, string SecondSurname, string NIF, double NumberOfHours)
        {
            this.Name = name;
            this.FirstSurname = FirstSurname;
            this.SecondSurname = SecondSurname;
            this.NIF = NIF;
            this.NumberOfHours = NumberOfHours;
        }

        public Employee() { }

        public double Wages(int daysWorked, double pricePerHour)
        {
            return Math.Round(daysWorked * pricePerHour * NumberOfHours);
        }

        override public string ToString()
        {
            string output = "Employee: " + FirstSurname + " " + SecondSurname + ", " + Name +
                " with NIF: " + NIF + ". Total workhours = " + NumberOfHours + ".";
            return output;
        }

        /*~Employee()
        {
            Console.WriteLine("Deceased :(");
        }*/


    }
}
