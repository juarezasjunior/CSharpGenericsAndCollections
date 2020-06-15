using System;
using System.Collections.Generic;
using System.Linq;
using CSharpGenericsAndCollections._Generics;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._Generics
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void RepositoryTest()
        {
            // I cannot do this, because my repository only allows objects inherited from BaseModel class
            //var repositoryString = new Repository<string>();

            var repository = new Repository<Person>();

            repository.Insert(new Person { Id = 1, Name = "John", Age = 15 });
            repository.Insert(new Person { Id = 2, Name = "Mary", Age = 20 });
            repository.Insert(new Person { Id = 3, Name = "Lucy", Age = 30 });


            Assert.That(repository.GetAll().Count(), Is.EqualTo(3));

            var lucy = repository.GetById(3);
            Assert.That(lucy.Name, Is.EqualTo("Lucy"));
        }
    }
}
