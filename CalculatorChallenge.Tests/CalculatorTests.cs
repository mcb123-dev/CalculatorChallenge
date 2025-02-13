﻿using CalculatorChallenge.ConsoleApp;
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

        [Test]
        public void Add_MultipleNumbers_ReturnsTheirSum()
        {
            Assert.That(Calculator.Add("1,2,3,4,5,6,7,8,9,10,11,12"), Is.EqualTo(78));
        }

        [Test]
        public void Add_NewlineDelimiter_ReturnsSum()
        {
            Assert.That(Calculator.Add("1\n2,3"), Is.EqualTo(6));
        }
    }
}
