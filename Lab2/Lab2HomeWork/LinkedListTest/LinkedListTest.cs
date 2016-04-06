using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2HomeWork

{
    [TestClass]
    public class LinkedListTest
    {

        LinkedList list;
        Employee e;

        [TestInitialize]
        public void Initialize()
        {
            list = new LinkedList();
            e = new Employee("Juan", "Palomo", "asdf", "123124B", 4);
        }

        [TestMethod]
        public void TesAdd()
        {
            list.add(e);
            list.add(new Videogame("GTA", 100, 900000, Videogame.Plataforma.PS3,
                2014, "Sandbox", "Rockstar"));
            list.add(13);
            list.add("Hola");
            list.add(13.42);

            Assert.AreEqual(5, list.size);
            Assert.AreEqual("Employee: Palomo asdf, Juan with NIF: 123124B. Total workhours" +
                " = 4.  GTA, for PS3. Editor: Rockstar  13  Hola  13,42  ", list.ToString());

        }
        [TestMethod]
        public void TesRemove()
        {
            list.add(e);
            list.add(new Videogame("GTA", 100, 900000, Videogame.Plataforma.PS3,
                2014, "Sandbox", "Rockstar"));
            list.add(13);
            list.add("Hola");
            list.add(13.42);

            list.remove("Hola");
            list.remove(13);

            Assert.AreEqual(3, list.size);

            list.add("string");

            Assert.AreEqual(4, list.size);

        }

        [TestMethod]
        public void TesContains()
        {
            list.add(e);
            list.add(new Videogame("GTA", 100, 900000, Videogame.Plataforma.PS3,
                2014, "Sandbox", "Rockstar"));
            list.add(13);
            list.add("Hola");
            list.add(13.42);

            Assert.IsTrue(list.contains("Hola"));
            Assert.IsFalse(list.contains("i'm not in the list"));

            list.add("i'm not in the list");

            Assert.IsTrue(list.contains("i'm not in the list"));

        }
        [TestMethod]
        public void TesGetElement()
        {
            list.add(e);
            list.add(new Videogame("GTA", 100, 900000, Videogame.Plataforma.PS3,
                2014, "Sandbox", "Rockstar"));
            list.add(13);
            list.add("Hola");
            list.add(13.42);

            Assert.IsTrue("Hola".Equals(list.getNode(3).value));

        }
    }
}
