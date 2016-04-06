using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2HomeWork
{
    [TestClass]
    public class FilterTest
    {
        Employee[] list = new Employee[5];
        Employee[] aux;

        Employee e1;
        Employee e2;
        Employee e3;
        Employee e4;
        Employee e5;

        [TestInitialize]
        public void Initialize() {
            e1 = new Employee("Juan", "Garcia", "Gonzalez", "1A", 5 );
            e2 = new Employee("Maria", "Garcia", "Alvarez", "1B", 5);
            e3 = new Employee("Juan", "Alvarez", "Gonzalez", "2A", 5);
            e4 = new Employee("Maria", "Garcia", "Fernandez", "3K", 5);
            e5 = new Employee("Juan", "Garcia", "Fernandez", "1B", 5);
            
            list[0] = e1;
            list[1] = e2;
            list[2] = e3;
            list[3] = e4;
            list[4] = e5;
        }


        [TestMethod]
        public void Test()
        {
            aux = DefaultParameters.Filter(list, name: "MariA");
            Assert.AreEqual(2, aux.Length);

            aux = DefaultParameters.Filter(list, name: "Juan");
            Assert.AreEqual(3, aux.Length);

            aux = DefaultParameters.Filter(list, name: "Juan", surname1: "GArciA");
            Assert.AreEqual(2, aux.Length);

            aux = DefaultParameters.Filter(list, nifContains: "3K");
            Assert.AreEqual(1, aux.Length);

        }
    }
}
