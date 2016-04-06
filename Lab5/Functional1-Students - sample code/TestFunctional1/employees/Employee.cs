

using System;
using System.Text;
using TPP.Laboratory.ObjectOriented.Practica1;

namespace TPP.Laboratory.ObjectOriented.Practica1Empleado
{
    public enum ContractType { Partial = 4, Full = 8 }

    public class Employee
    {
        public ContractType NumberOfHours { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string NIF { get; set; }
        public DateTime BirthDate { get; set; }
        public string Comments { get; set; }

        private int _id;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }

        //Non-parameter constructor is needed to allow Property-based construction
        public Employee()
        {
            this.Comments = "";
        } 
        
        public Employee(string name, string NIF, ContractType numberOfHours)
        {
            this.Name = name;
            this.NumberOfHours = numberOfHours;
            this.NIF = NIF;
            this.Comments = "";
        }
        public double Wage(int daysWorked, double pricePerHour)
        {
            return Math.Round(daysWorked * pricePerHour * (int)NumberOfHours);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Name: " + Name);
            sb.Append("; ");
            sb.Append("FirstSurname: " + FirstSurname);
            sb.Append("; ");
            sb.Append("SecondSurname: " + SecondSurname);
            sb.Append("; ");
            sb.Append("NIF: " + NIF);
            sb.Append("; ");
            sb.Append("BirthDate: " + BirthDate);
            sb.Append("; ");
            sb.Append("NumberOfHours: " + NumberOfHours);
            sb.Append("; ");
            sb.Append("Comments: " + Comments);
            sb.Append(";\n");

            return sb.ToString();
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
    }
}
