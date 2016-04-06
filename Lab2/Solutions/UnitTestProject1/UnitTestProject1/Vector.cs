using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Vector
    {
        [TestMethod]
        public void Vector()
        {
        }

        public object Size { get; set; }

        internal void Add(int firstValue)
        {
            throw new NotImplementedException();
        }

        internal object GetElement(int p)
        {
            throw new NotImplementedException();
        }

        internal void SetElement(int p, int firstValue)
        {
            throw new NotImplementedException();
        }
    }
}
