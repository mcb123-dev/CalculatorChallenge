﻿using NUnit.Framework.Legacy;
using NUnit.Framework;
using CalculatorChallenge.ConsoleApp.Core;

namespace CalculatorChallenge.Tests.Core
{
    [TestFixture]
    public class InputParserTests
    {
        [Test]
        public void Parse_ValidSingleNumber_ReturnsListWithOneNumber()
        {
            var result = InputParser.Parse("5");
            CollectionAssert.AreEqual(new List<int> { 5 }, result);
        }

        [Test]
        public void Parse_ValidTwoNumbers_ReturnsListWithTwoNumbers()
        {
            var result = InputParser.Parse("3,7");
            CollectionAssert.AreEqual(new List<int> { 3, 7 }, result);
        }

        [Test]
        public void Parse_ValidThreeNumbers_ReturnsListWithThreeNumbers()
        {
            var result = InputParser.Parse("3,7,8");
            CollectionAssert.AreEqual(new List<int> { 3, 7, 8 }, result);
        }

        [Test]
        public void Parse_EmptyString_ReturnsListWithZero()
        {
            var result = InputParser.Parse("");
            CollectionAssert.AreEqual(new List<int> { 0 }, result);
        }

        [Test]
        public void Parse_InvalidNumber_ReplacesWithZero()
        {
            var result = InputParser.Parse("5,abc");
            CollectionAssert.AreEqual(new List<int> { 5, 0 }, result);
        }

        [Test]
        public void Parse_NewlineDelimiter_ReturnsListWithThreeNumbers()
        {
            var result = InputParser.Parse("1\n2,3");
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, result);
        }

        [Test]
        public void Parse_CustomSingleDelimiter_ReturnsListWithTwoNumbers()
        {
            var result = InputParser.Parse("//#\n2#5");
            CollectionAssert.AreEqual(new List<int> { 2, 5 }, result);
        }

        [Test]
        public void Parse_CustomLongDelimiter_ReturnsListWithThreeNumbers()
        {
            var result = InputParser.Parse("//[***]\n11***22***33");
            CollectionAssert.AreEqual(new List<int> { 11, 22, 33 }, result);
        }

        [Test]
        public void Add_MultipleCustomDelimiters_ReturnsListWithFourNumbers()
        {
            var result = InputParser.Parse("//[*][!!][r9r]\n11r9r22*hh*33!!44");
            CollectionAssert.AreEqual(new List<int> { 11, 22, 0, 33, 44 }, result);
        }
    }
}
