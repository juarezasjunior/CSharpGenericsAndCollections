using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Collections
{
    [TestFixture]
    public class HashSetTests
    {
        [Test]
        public void HashSetTest()
        {
            // With HashSet you will have unique values
            HashSet<string> myStringHashSet = new HashSet<string>();

            myStringHashSet.Add("John");
            myStringHashSet.Add("Mary");

            // Since that this value is already in the list, it will not be added
            myStringHashSet.Add("Mary");

            Assert.That(myStringHashSet.Count, Is.EqualTo(2));
        }

        [Test]
        public void HashSetUsingIntersectTest()
        {
            HashSet<int> numbersFirstList = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> numbersSecondList = new HashSet<int>() { 2, 3, 4 };

            // Will maintain only objects that are present in both lists
            numbersFirstList.IntersectWith(numbersSecondList); 

            Assert.That(numbersFirstList.SetEquals(new int[] { 2, 3 }), Is.True);
        }

        [Test]
        public void HashSetUsingUnionTest()
        {
            HashSet<int> numbersFirstList = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> numbersSecondList = new HashSet<int>() { 2, 3, 4 };

            // Will join the objects that are present itself in both lists
            numbersFirstList.UnionWith(numbersSecondList);

            Assert.That(numbersFirstList.SetEquals(new int[] { 1, 2, 3, 4 }), Is.True);
        }

        [Test]
        public void HashSetUsingSymmetricExceptTest()
        {
            HashSet<int> numbersFirstList = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> numbersSecondList = new HashSet<int>() { 2, 3, 4 };

            // Modifies the current object to contain only elements that are present
            // either in that object or in the specified collection, but not both.
            numbersFirstList.SymmetricExceptWith(numbersSecondList);

            Assert.That(numbersFirstList.SetEquals(new int[] { 1, 4 }), Is.True);
        }

        [Test]
        public void HashSetWithoutComparerTest()
        {
            HashSet<Person> peopleHashSet = new HashSet<Person>();

            peopleHashSet.Add(new Person { Name = "John" });
            peopleHashSet.Add(new Person { Name = "John" });

            // Since that I don't have a IEqualityComparer, it will allow
            // both persons with the same name
            Assert.That(peopleHashSet.Count, Is.EqualTo(2));

            // But it would not add if I'm working with references
            HashSet<Person> anotherPeopleHashSet = new HashSet<Person>();

            var person = new Person()
            {
                Name = "John"
            };

            anotherPeopleHashSet.Add(person);
            anotherPeopleHashSet.Add(person);

            Assert.That(anotherPeopleHashSet.Count, Is.EqualTo(1));
        }

        [Test]
        public void HashSetWithComparerTest()
        {
            // To fix the comparer problem, my class should implement the
            // IEqualityComparer interface
            HashSet<Person> peopleHashSet = new HashSet<Person>(new PersonComparer());

            peopleHashSet.Add(new Person { Name = "John" });
            peopleHashSet.Add(new Person { Name = "John" });

            Assert.That(peopleHashSet.Count, Is.EqualTo(1));
        }

        public class Person
        {
            public string Name { get; set; }
        }

        public class PersonComparer : IEqualityComparer<Person>
        {
            public bool Equals(Person x, Person y)
            {
                return String.Equals(x.Name, y.Name);
            }

            public int GetHashCode(Person obj)
            {
                return obj.Name.GetHashCode();
            }
        }
    }
}
