using System;
using NUnit.Framework;

namespace Application.Library.Tests
{
    [TestFixture]
    public class TestClass1
    {
        [Test]
        public void GreetOneNameTest()
        {
            // Arrange
            string name = "Alina";

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Assert.That(text, Is.EqualTo("Hello, Alina."));
        }

        [Test]
        public void GreetNullTest()
        {
            // Arrange
            string name = null;

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Assert.That(text, Is.EqualTo("Hello, my friend."));
        }

        [Test]
        public void GreetShoutingNameTest()
        {
            // Arrange
            string name = "MARIA";

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Assert.That(text, Is.EqualTo("HELLO, MARIA!"));
        }

        [Test]
        public void GreetTwoNamesTest()
        {
            // Arrange
            string[] name = {"George", "Ioana"};

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Assert.That(text, Is.EqualTo("Hello, George and Ioana."));
        }

        [Test]
        public void GreetMultipleNamesTest()
        {
            // Arrange
            string[] name = { "Marius", "Vali", "Ana" };

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Assert.That(text, Is.EqualTo("Hello, Marius, Vali, and Ana."));
        }

        [Test]
        public void GreetMixedTest()
        {
            // Arrange
            string[] names = { "Ana", "MARIA", "George" };

            // Act
            var text = Greeter.Greet(names);

            // Assert
            Assert.That(text, Is.EqualTo("Hello, Ana and George. AND HELLO MARIA!"));
        }
    }
}
