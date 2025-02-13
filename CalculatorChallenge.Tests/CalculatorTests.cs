using CalculatorChallenge.ConsoleApp;
using NUnit.Framework;

namespace CalculatorChallenge.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            Assert.That(Calculator.Add(string.Empty), Is.EqualTo(0));
        }
    }
}
