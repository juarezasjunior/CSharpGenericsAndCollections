using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class ListTests
    {
        [Test]
        public void ListTest()
        {
            List<string> myStringList = new List<string>();

            myStringList.Add("John");
            myStringList.Add("Mary");
            myStringList.Add("Luke");
            myStringList.Add("Peter");
            myStringList.Add("Mathew");
            myStringList.Add("Mark");

            Assert.That(myStringList.Count, Is.EqualTo(6));
        }

        [Test]
        public void ListCapacity()
        {
            var numbers = new List<int>();

            Assert.That(numbers.Capacity, Is.EqualTo(0));

            // When I add a first element, the list size will be resized for 4
            numbers.Add(50000);
            Assert.That(numbers.Capacity, Is.EqualTo(4));

            numbers.Add(60000);
            numbers.Add(70000);
            numbers.Add(80000);
            numbers.Add(90000);

            // When I reached 4 elements, a list will be resized for the double
            // of capacity that before
            Assert.That(numbers.Capacity, Is.EqualTo(8));

        }
    }
}
