using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Employee
    {
        public enum ContractType { Full = 8, Partial = 4 }

        public ContractType NumberOfHours { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string NIF { get; set; }



        public Employee(string name, string FirstSurname, string SecondSurname, string NIF, ContractType NumberOfHours)
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
            return Math.Round(daysWorked * pricePerHour * (int)NumberOfHours);
        }

        override public string ToString()
        {
            string output = "Employee: " + FirstSurname + " " + SecondSurname + ", " + Name +
                " with NIF: " + NIF + ". Total workhours = " + NumberOfHours + ".";
            return output;
        }

        public override bool Equals(object obj)
        {
            Employee person = obj as Employee;
            if (person == null)
                return false;
            return this.Name.Equals(person.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        /*~Employee()
        {
            Console.WriteLine("Deceased :(");
        }*/


    }
}
