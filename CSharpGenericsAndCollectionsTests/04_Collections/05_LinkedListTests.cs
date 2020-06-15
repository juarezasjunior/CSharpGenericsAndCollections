using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void LinkedListTest()
        {
            var names = new LinkedList<string>();

            names.AddFirst("John");
            names.AddFirst("Mary");

            var firstName = names.First;

            // Mary will be the header
            Assert.That(firstName.Value, Is.EqualTo("Mary"));

            var nextName = firstName.Next;

            // John will be the second name
            Assert.That(nextName.Value, Is.EqualTo("John"));

            // I can add another name between Mary and John
            names.AddAfter(firstName, "Luke");

            // Now, the second name is Luke and not John
            var secondName = firstName.Next;
            Assert.That(secondName.Value, Is.EqualTo("Luke"));
        }
    }
}
