using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class Dictionary_Test
    {
        /*
        1. Add elements with a given key and value
        2. Obtain the number of pairs in the collection
        3. Get and set the value of a given key
        4. Consult whether or not a key exists in the dictionary
        5. Delete a pair giving its key 6. Iterate throughout the pairs(both key and value) with a foreach loop
         */

        IDictionary<string, string> d;

        [TestInitialize]
        public void SetUp()
        {

            d = new Dictionary<string, string>();

            d.Add("B", "ellsprout");
            d.Add("S", "quirtle");

        }


        [TestMethod]
        public void Add_Test()
        {
            Assert.AreEqual(2, d.Count);

            d.Add("J", "inx");

            Assert.AreEqual(3, d.Count);

        }

        [TestMethod]
        public void Pairs_Test()
        {
            Assert.AreEqual(2, d.Count);

        }

        [TestMethod]
        public void Get_Set_Test()
        {
            Assert.AreEqual(d["B"], "ellsprout");

            d["B"] = "Onix";

            Assert.AreEqual(d["B"], "Onix");


        }

        [TestMethod]
        public void Exists_Test()
        {
            Assert.IsTrue(d.ContainsKey("B"));
            Assert.IsFalse(d.ContainsKey("L"));

        }

        [TestMethod]
        public void Delete_Test()
        {

            Assert.AreEqual(d.Count, 2);
            d.Remove("B");

            Assert.AreEqual(d.Count, 1);
            Assert.IsFalse(d.ContainsKey("B"));
        }

    }
}