using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab04
{
    [TestClass]
    public class LinkedListTest
    {

        LinkedList<string> listStrings;
        LinkedList<int> listInts;


        [TestInitialize]
        public void Initialize()
        {
            listStrings = new LinkedList<string>();
            listInts = new LinkedList<int>();

            listStrings.add("L");
            listStrings.add("Ñ");
            listStrings.add("M");
            listStrings.add("HH");

            listInts.add(3);
            listInts.add(6);
            listInts.add(50);
            listInts.add(22);
            listInts.add(1);
        }

        [TestMethod]
        public void TesAdd()
        {
            listStrings.add("df");
            listStrings.add("h");
            listStrings.add("aqdad");

            Assert.AreEqual(7, listStrings.size);

            listInts.add(112);
            listInts.add(23);
            listInts.add(2);

            Assert.AreEqual(8, listInts.size);

        }
        [TestMethod]
        public void TesRemove()
        {
            listStrings.remove("HH");
            listStrings.removeByIndex(0);

            Assert.AreEqual(2, listStrings.size);
            Assert.IsTrue(listStrings.get(0)=="Ñ");

            listInts.remove(50);
            listInts.removeByIndex(0);
            listInts.removeByIndex(0);

            Assert.AreEqual(2, listStrings.size);
            Assert.IsTrue(listInts.get(0)==(22));

        }

        [TestMethod]
        public void TesContains()
        {
            Assert.IsTrue(listStrings.contains("L"));
            Assert.IsTrue(listStrings.contains("Ñ"));
            Assert.IsTrue(listStrings.contains("HH"));

            Assert.IsFalse(listStrings.contains("HOLA"));
            Assert.IsFalse(listStrings.contains("SOY UN TEST"));

            Assert.IsTrue(listInts.contains(1));
            Assert.IsTrue(listInts.contains(50));
            Assert.IsTrue(listInts.contains(3));

            Assert.IsFalse(listInts.contains(1213));
            Assert.IsFalse(listInts.contains(2131));
         

        }
        [TestMethod]
        public void TesGetElement()
        {
            Assert.IsTrue(listStrings.get(1)==("Ñ"));

            Assert.IsTrue(listInts.get(3)==(22));
        }
    }
}