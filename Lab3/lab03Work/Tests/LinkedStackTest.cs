using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab03Work

{
    [TestClass]
    public class LinkedStackTest
    {
        public LinkedStack stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new LinkedStack(100);
        }

        [TestMethod]
        public void TestPush()
        {
            stack.push("A");
            Assert.IsTrue(stack.size() == 1);

            Object obj = stack.peek();
            Assert.IsTrue("A".Equals(obj));

            stack.push("A");
            Assert.IsTrue(stack.size() == 2);

            stack.push("");
            Assert.IsTrue(stack.size() == 3);

            stack.push(null);
            Assert.IsTrue(stack.size() == 4);
        }
        [TestMethod]
        public void testPeek()
        {
            stack.push("B");
            stack.push("A");
            Assert.IsTrue(stack.peek().Equals("A"));

            stack.pop();
            Assert.IsTrue(stack.peek().Equals("B"));

        }

        
        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
	public void testOnEmptyPeek()
        {
            stack.peek();
        }


        [TestMethod]
        public void testPop()
        {
            stack.push("C");
            stack.push("B");
            stack.push("A");
            Assert.IsTrue(stack.size() == 3);

            Object obj = stack.pop();
            Console.WriteLine(obj.ToString());

            Assert.IsTrue("A".Equals(obj.ToString()));
            Assert.IsTrue(stack.size() == 2);

            obj = stack.peek();
            Assert.IsTrue("B".Equals(obj));

            obj = stack.pop();
            Assert.IsTrue("B".Equals(obj));
            Assert.IsTrue(stack.size() == 1);

            obj = stack.pop();
            Assert.IsTrue("C".Equals(obj));
            Assert.IsTrue(stack.size() == 0);

        }

        [TestMethod]
        public void testSize()
        {
            Assert.IsTrue(stack.size() == 0);

            stack.push("A");
            Assert.IsTrue(stack.size() == 1);

            stack.push("B");
            Assert.IsTrue(stack.size() == 2);

            stack.pop();
            Assert.IsTrue(stack.size() == 1);
            stack.pop();
            Assert.IsTrue(stack.size() == 0);

        }

        [TestMethod]
        public void testIsEmpty()
        {
            Assert.IsTrue(stack.isEmpty());

            stack.push("A");
            Assert.IsTrue(stack.isEmpty() == false);

            stack.push("B");
            Assert.IsTrue(stack.isEmpty() == false);

            stack.pop();
            stack.pop();
            Assert.IsTrue(stack.isEmpty());
        }

    }
}
