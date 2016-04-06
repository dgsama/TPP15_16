using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPP.Laboratory.Functional.Lab07;
using TPP.Laboratory.Functional.Lab01;

namespace lab7.test
{
    [TestClass]
    public class Test
    {
        Videogame[] videogames;
        Videogame[] aux;
        Videogame[] aux1;
        Videogame v1;
        Videogame v2;
        Videogame v3;
        Videogame v4;
        Videogame v5;

        [TestInitialize]
        public void SetUp()
        {
            videogames = VideogameFactory.CreateFullVideoGameLibrary();

            v1 = new Videogame("Grand Theft Auto V", Platform.PS3, 2013, "Action", "Take-Two Interactive", 6.25, 8.02, 0.85, 3.93);
            v2 = new Videogame("FIFA Soccer 14", Platform.PS3, 2013, "Sports", "Electronic Arts", 0.70, 4.04, 0.07, 2.00);
            v3 = new Videogame("SpongeBob's Truth or Square", Platform.Xbox360, 2009, "Action", "THQ", 0.03, 0.04, 0.00, 0.00);
            v4 = new Videogame("Guilty Gear XX Accent Core", Platform.Wii, 2007, "Fighting", "505 Games", 0.03, 0.00, 0.00, 0.00);
            v5 = new Videogame("Thomas & Friends: Hero of the Rails", Platform.Wii, 2010, "Misc", "Unknown", 0.00, 0.01, 0.00, 0.00);

            aux = new Videogame[10];
        }

        [TestMethod]
        public void TestFind()
        {
            Assert.AreEqual(v1, videogames.First(v => v.Title == "Grand Theft Auto V"));
            Assert.AreEqual(v2, videogames.First(v => v.Genre == "Sports" && v.Editor == "Electronic Arts"));
            Assert.AreEqual(v5, videogames.First(v => v.Platform == Platform.Wii && v.Year == 2010 && v.AmericaSales == 0.00 && v.EuropeSales == 0.01));

        }

        [TestMethod]
        public void TestFilter()
        {
            aux[0] = v1;
            aux1 = videogames.Where(v => v.Title == "Grand Theft Auto V").ToArray();
            Assert.AreEqual(aux[0], aux1[0]);

            aux[0] = v3;
            aux1 = videogames.Where(v => v.Platform == Platform.Xbox360 && v.Year == 2009 && v.Editor == "THQ" && v.EuropeSales == 0.04).ToArray();
            Assert.AreEqual(aux[0], aux1[0]);

        }


        [TestMethod]
        public void TestReduce()
        {

        }


        [TestMethod]
        public void TestMap()
        {

        }
    }
}
