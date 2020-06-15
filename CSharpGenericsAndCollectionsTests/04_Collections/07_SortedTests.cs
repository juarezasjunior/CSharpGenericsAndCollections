using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class SortedTests
    {
        [Test]
        public void SortedListTest()
        {
            var sortedList = new SortedList<int, string>();

            sortedList.Add(3, "John");
            sortedList.Add(1, "Mary");
            sortedList.Add(2, "Mike");

            // Notice that the first position is for Mary
            var maryIndex = sortedList.IndexOfValue("Mary");
            Assert.That(maryIndex, Is.EqualTo(0));
        }

        [Test]
        public void SortedDictionaryTest()
        {
            var dictionary = new SortedDictionary<int, string>();

            dictionary.Add(3, "John");
            dictionary.Add(1, "Mary");
            dictionary.Add(2, "Mike");

            // Notice that the first position is for Mary
            var name = dictionary.Values.FirstOrDefault();
            Assert.That(name, Is.EqualTo("Mary"));
        }

        [Test]
        public void SortedSetTest()
        {
            var sortedSet = new SortedSet<string>();

            sortedSet.Add("C");
            sortedSet.Add("A");
            sortedSet.Add("B");

            // Notice that the first position is for A
            var letters = sortedSet.GetEnumerator();
            letters.MoveNext();
            var firstLetter = letters.Current;

            Assert.That(firstLetter, Is.EqualTo("A"));
        }
    }
}
