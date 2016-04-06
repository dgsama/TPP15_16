using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Employee
{
    public class Employee
    {
        public double workHours { get; set; }
        public string name { get; set; }
        public string surname1 { get; set; }
        public string surname2 { get; set; }

        private int _id; //Another "shadow" attirbute
        public int ID
        {
            get { return _id; }
            set
            {
                if (value >= 0)
                {
                    _id = value;
                }
            }
        }

        public Employee(string name, string surname1, string surname2, int ID, double workHours)
        {
            Console.WriteLine("Hello! :)");
            this.name = name;
            this.surname1 = surname1;
            this.surname2 = surname2;
            this.ID = ID;
            this.workHours = workHours;
        }

        public Employee() { }

        public double Wages(int daysWorked, double pricePerHour)
        {
            return Math.Round(daysWorked * pricePerHour * workHours);
        }

        override public string ToString()
        {
            string output = "Employee: " + surname1 + " " + surname2 + ", " + name +
                " with ID: " + ID + ". Total workhours = " + workHours + ".";
            return output;
        }

        ~Employee()
        {
            Console.WriteLine("Deceased :(");
        }


    }
}
