using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConcurrentQueue;

namespace ConcurrentQueueTests
{

    [TestClass]
    public class Tests
    {


        public concurrentQueue<int> numbers;
        public concurrentQueue<string> words;


        [TestInitialize]
        public void SetUp()
        {
            numbers = new concurrentQueue<int>();
            words = new concurrentQueue<string>();

            numbers.Enqueue(777);
            numbers.Enqueue(2077);

            words.Enqueue("Vegetta");
            words.Enqueue("CiberPunk");

        }


        [TestMethod]
        public void IsEmptyTest()
        {
            //INTS
            Assert.AreEqual(2, numbers.numberOfElements);
            Assert.IsFalse(numbers.IsEmpty());

            numbers.Dequeue();

            Assert.IsFalse(numbers.IsEmpty());

            numbers.Dequeue();

            Assert.AreEqual(0, numbers.Dequeue());
            Assert.IsTrue(numbers.IsEmpty());

            //Strings
            Assert.AreEqual(2, words.numberOfElements);
            Assert.IsFalse(words.IsEmpty());

            words.Dequeue();

            Assert.IsFalse(words.IsEmpty());

            words.Dequeue();

            Assert.AreEqual(null, words.Dequeue());
            Assert.IsTrue(words.IsEmpty());

        }


        [TestMethod]
        public void EnqueueTest()
        {
            //INTS
            Assert.AreEqual(2, numbers.numberOfElements);

            numbers.Enqueue(14);
            numbers.Enqueue(01);

            Assert.AreEqual(4, numbers.numberOfElements);

            numbers.Enqueue(1995);

            Assert.AreEqual(5, numbers.numberOfElements);

            //Strings
            Assert.AreEqual(2, words.numberOfElements);

            words.Enqueue("Mi");
            words.Enqueue("Fecha");

            Assert.AreEqual(4, words.numberOfElements);

            words.Enqueue("Cumpleaños");

            Assert.AreEqual(5, words.numberOfElements);

        }


        [TestMethod]
        public void DequeueTest()
        {
            //INTS
            Assert.AreEqual(2, numbers.numberOfElements);

            Assert.AreEqual(777, numbers.Dequeue());

            Assert.AreEqual(1, numbers.numberOfElements);

            Assert.AreEqual(2077, numbers.Dequeue());

            Assert.AreEqual(0, numbers.numberOfElements);

            Assert.AreEqual(0, numbers.Dequeue());

            //Strings
            Assert.AreEqual(2, words.numberOfElements);

            Assert.AreEqual("Vegetta", words.Dequeue());

            Assert.AreEqual(1, words.numberOfElements);

            Assert.AreEqual("CiberPunk", words.Dequeue());

            Assert.AreEqual(0, words.numberOfElements);

            Assert.AreEqual(null, words.Dequeue());

        }

        [TestMethod]
        public void PeekTest()
        {
            //INTS

            Assert.AreEqual(777, numbers.Peek());
            Assert.AreEqual(2, numbers.numberOfElements);

            numbers.Dequeue();

            Assert.AreEqual(2077, numbers.Peek());
            Assert.AreEqual(1, numbers.numberOfElements);

            //Strings
            Assert.AreEqual("Vegetta", words.Peek());
            Assert.AreEqual(2, words.numberOfElements);

            words.Dequeue();

            Assert.AreEqual("CiberPunk", words.Peek());
            Assert.AreEqual(1, words.numberOfElements);

        }
    }
}

