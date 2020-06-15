using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void StackTest()
        {
            // With Stack you may Push values and Pop them.
            // The Pop will be done using LIFO (Last In, First Out).
            Stack<string> myStringStack = new Stack<string>();

            myStringStack.Push("John");
            myStringStack.Push("Mary");
            myStringStack.Push("Luke");
            myStringStack.Push("Peter");
            myStringStack.Push("Mathew");
            myStringStack.Push("Mark");

            var pop = myStringStack.Pop();

            Assert.That(pop, Is.EqualTo("Mark"));

            // Using Pop, it will remove the object
            Assert.That(myStringStack.Contains("Mark"), Is.False);

            // You can use the Peek, that will just get the value without remove it
            var peek = myStringStack.Peek();
            Assert.That(peek, Is.EqualTo("Mathew"));
            Assert.That(myStringStack.Contains("Mathew"), Is.True);
        }
    }
}
