using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class vectorTest
    {
        /*
        1. Add elements
        2. Obtain the number of elements
        3. Get and set the element of the ith position
        4. Consult whether or not an element is in the vector
        5. Obtain the index of the first occurrence of an element in the vector
        6. Delete the first occurrence of a given element 7. Iterate throughout the elements with a foreach loop
        */

        IList<string> l;

        [TestInitialize]
        public void SetUp()
        {
            l = new List<string>();

            l.Add("P. Silver");
            l.Add("P. Gold");
        }


        [TestMethod]
        public void Add_Test()
        {

            Assert.AreEqual(l.Count, 2);
            l.Add("Ash");
            Assert.AreEqual(l.Count, 3);
            l.Add("Red");
            Assert.AreEqual(l.Count, 4);
        }

        [TestMethod]
        public void Size_Test()
        {
            Assert.AreEqual(l.Count, 2);
        }

        [TestMethod]
        public void Get_Set_Test()
        {

            Assert.AreEqual(l[0], "P. Silver");
            l[0] = "P. Blue";
            Assert.AreEqual(l[0], "P. Blue");

        }

        [TestMethod]
        public void Exist_Test()
        {
            Assert.IsFalse(l.Contains("P. shaphire"));
            Assert.IsTrue(l.Contains("P. Silver"));

        }

        [TestMethod]
        public void Get_Index_Test()
        {
            Assert.AreEqual(1, l.IndexOf("P. Gold"));
            Assert.AreEqual(-1, l.IndexOf("P. Crystal"));

        }

        [TestMethod]
        public void Delete_Test()
        {
            Assert.AreEqual(2, l.Count);

            l.Remove("P. Silver");

            Assert.AreEqual(1, l.Count);

            l.Remove("P. Gold");

            Assert.AreEqual(0, l.Count);

        }

        [TestMethod]
        public void For_Each_Test()
        {
            l.Add("Ash");
            l.Add("Red");
            l.Add("Misty");
            l.Add("Brook");

            int i = 0;

            foreach (string s in l){
                Assert.IsTrue(s.ToLower().ToString().Equals(l[i].ToLower().ToString()));
                Assert.AreEqual(s, l[i]);
                i++;
            }

        }
    }
}
