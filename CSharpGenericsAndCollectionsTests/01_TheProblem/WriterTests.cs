using System;
using CSharpGenericsAndCollections._TheProblem;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._TheProblem
{
    [TestFixture]
    public class WriterTests
    {
        [Test]
        public void WriterTest()
        {
            var writer = new Writer();

            // I need a method for each type that I want to write
            writer.Write(true);
            writer.Write("teste");
            writer.Write(1);
            writer.Write(10.5);

            var myNewObject = new MyNewObject();

            // I cannot do this, because my method don't has a parameter of this type
            //writer.Write(myNewObject);

            Assert.That(writer.LogLines.Count, Is.EqualTo(4));
        }

        public class MyNewObject
        {
            public override string ToString()
            {
                return "This is my new object";
            }
        }
    }
}
