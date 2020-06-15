using System;
using CSharpGenericsAndCollections._TheSolution;
using NUnit.Framework;

namespace CSharpGenericsAndCollectionsTests._TheSolution
{
    [TestFixture]
    public class WriterTests
    {
        [Test]
        public void WriterTest()
        {
            var writer = new Writer();

            // I can use the method in the same way, but now I may send any type as parameter
            writer.Write(true);
            writer.Write("teste");
            writer.Write(1);
            writer.Write(10.5);

            var myNewObject = new MyNewObject();

            writer.Write(myNewObject);

            Assert.That(writer.LogLines.Count, Is.EqualTo(5));
        }

        [Test]
        public void WriterInformingTheTypeTest()
        {
            var writer = new Writer();

            // I could inform the type too, but it's not necessary
            writer.Write<bool>(true);
            writer.Write<string>("teste");
            writer.Write<int>(1);
            writer.Write<double>(10.5);

            var myNewObject = new MyNewObject();

            writer.Write<MyNewObject>(myNewObject);

            Assert.That(writer.LogLines.Count, Is.EqualTo(5));
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
