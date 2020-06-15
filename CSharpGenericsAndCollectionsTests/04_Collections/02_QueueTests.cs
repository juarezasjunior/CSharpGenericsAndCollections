using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void QueueTest()
        {
            // With Stack you may Enqueue values and Dequeue them.
            // The Dequeue will be done using FIFO (First In, First Out).
            Queue<string> myStringQueue = new Queue<string>();

            myStringQueue.Enqueue("John");
            myStringQueue.Enqueue("Mary");
            myStringQueue.Enqueue("Luke");
            myStringQueue.Enqueue("Peter");
            myStringQueue.Enqueue("Mathew");
            myStringQueue.Enqueue("Mark");

            var firstString = myStringQueue.Dequeue();

            Assert.That(firstString, Is.EqualTo("John"));

            // Using Enqueue, it will remove the object
            Assert.That(myStringQueue.Contains("John"), Is.False);

            // You can use the Peek, that will just get the value without remove it
            var peek = myStringQueue.Peek();
            Assert.That(peek, Is.EqualTo("Mary"));
            Assert.That(myStringQueue.Contains("Mary"), Is.True);
        }
    }
}
