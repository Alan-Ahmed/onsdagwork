using NUnit.Framework;
using MyService.Api.Services;

namespace MyService.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_WithValidInputs_ReturnsCorrectSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            var result = Calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
