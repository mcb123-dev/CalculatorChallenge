using CalculatorChallenge.ConsoleApp;
using NUnit.Framework;

namespace CalculatorChallenge.Tests
{
    [TestFixture]
    public class NumberValidatorTests
    {

        [Test]
        public void Validate_NegativeNumbers_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => NumberValidator.Validate([4,-3]));
            Assert.That(ex?.Message, Is.EqualTo("Negative numbers not allowed: -3"));
        }

        [Test]
        public void Add_NumbersGreaterThan1000_Ignored()
        {
            Assert.That(Calculator.Add("2,5001,6"), Is.EqualTo(8));
        }
    }
}
