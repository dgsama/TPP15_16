using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    static class Program
    {
        interface IEqualityPredicate
        {
            bool Compare(object o1, object o2);
        }

        class SameSurname : IEqualityPredicate
        {
            public bool Compare(object o1, object o2)
            {
                Employee e1 = o1 as Employee;
                if (e1 == null)
                {
                    throw new Exception("OMG");
                }
                Employee e2 = o2 as Employee;
                if (e2 == null)
                {
                    throw new Exception("OMG");
                }
                return e1.FirstSurname.Equals(e2.FirstSurname);
            }
        }
        // IN C# System.Array.IndexOf(array, object)
        static int? HIndexOf(this object[] arr, object o)
        {
            int index = 0;
            foreach (object element in arr)
            {
                if (element.Equals(o))
                {
                    return index;
                }
                index++;
            }
            return null;
        }


        // IN C# System.Array.Find
        static int? HIndexOf(this object[] arr, object o, IEqualityPredicate comp)
        {
            int index = 0;
            foreach (object element in arr)
            {
                if (comp.Compare(element, o))
                {
                    return index;
                }
                index++;
            }
            return null;
        }


        static void Main(string[] args)
        {
            Employee[] emp = DefaultParameters.CreateEmployees();

            Employee e = new Employee();
            e.Name = "Juan";
            e.FirstSurname = "Hevia";

            Console.WriteLine("Index: " + emp.HIndexOf(e));
            Console.WriteLine("Index: " + emp.HIndexOf(e, new SameSurname()));
        }
    }
}
