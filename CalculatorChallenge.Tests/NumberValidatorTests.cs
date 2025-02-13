using CalculatorChallenge.ConsoleApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
