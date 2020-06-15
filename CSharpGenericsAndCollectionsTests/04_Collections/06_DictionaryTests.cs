using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class DictionaryTests
    {
        [Test]
        public void DictionaryTest()
        {
            var people = new Dictionary<int, string>();

            people.Add(1, "John");
            people.Add(2, "Mary");

            // I can find an item by the key
            var mary = people[2];
            Assert.That(mary, Is.EqualTo("Mary"));

            // I cannot add a record with the same Id
            Assert.Throws<ArgumentException>(() => people.Add(2, "Mary"));
        }
    }
}
