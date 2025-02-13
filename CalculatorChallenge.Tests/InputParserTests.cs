using NUnit.Framework.Legacy;
using NUnit.Framework;
using CalculatorChallenge.ConsoleApp;

namespace CalculatorChallenge.Tests
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
    }
}
