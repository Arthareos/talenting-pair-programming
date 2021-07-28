using Application.Library;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
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