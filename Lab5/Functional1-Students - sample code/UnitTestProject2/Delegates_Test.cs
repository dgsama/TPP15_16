using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPP.Laboratory.Functional.Lab01;
using Delegates;
using TPP.Laboratory.ObjectOriented.Practica1;
using System.Collections.Generic;
using TPP.Laboratory.ObjectOriented.Practica1Empleado;

namespace UnitTestProject2
{
    [TestClass]
    public class Delegates_Test
    {
        Employee e1;
        Employee e2;
        Employee e3;
        Employee e4;
        Employee e5;
        Employee e6;
        Employee e7;
  
        [TestInitialize]
        public void SetUp()
        {

            e1 = new Employee("John", "1A", ContractType.Full);
            e2 = new Employee("Lily", "2B", ContractType.Partial);
            e3 = new Employee("Barney", "3C", ContractType.Partial);
            e4 = new Employee("Josh", "4D", ContractType.Full);
            e5 = new Employee("Josefa", "5E", ContractType.Partial);
            e6 = new Employee("Amanda", "6F", ContractType.Full);
            e7 = new Employee("Katy", "7G", ContractType.Partial);

            var arr2 = VideogameFactory.CreateFullVideoGameLibrary();
            var arr1 = new List<Employee>();

            arr1.Add(e1);
            arr1.Add(e2);
            arr1.Add(e3);
            arr1.Add(e4);
            arr1.Add(e5);
            arr1.Add(e6);
            arr1.Add(e7);
        }


        [TestMethod]
        public void TestFind()
        {
        }

        [TestMethod]
        public void TestFilter()
        {
        }

        [TestMethod]
        public void TestReduce()
        {
        }
    }
}
