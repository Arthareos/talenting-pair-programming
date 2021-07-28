using System;
using Application.Library;

namespace Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Arrange
            string name = null;

            // Act
            var text = Greeter.Greet(name);

            // Assert
            Console.WriteLine(text);
        }
    }
}