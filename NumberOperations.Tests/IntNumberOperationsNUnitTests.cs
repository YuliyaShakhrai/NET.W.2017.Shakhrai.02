using System;
using NUnit.Framework;

namespace NumberOperations.Tests
{
    [TestFixture]

    public class IntNumberOperationsNUnitTests
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432, 3462345)]
        public void FindNextBiggerNumber_PositiveTests(int number, int expected)
        {
            Assert.AreEqual(expected, IntNumberOperations.FindNextBiggerNumber(number));
        }

        [TestCase(10)]
        [TestCase(20)]
        [TestCase(1)]
        public void FindNextBiggerNumber_NegativeTests(int number)
        {
            var expected = -1;
            Assert.AreEqual(expected, IntNumberOperations.FindNextBiggerNumber(number));
        }

        [TestCase(-5)]
        [TestCase(-11)]
        public void FindNextBiggerNumber_ThrowsArgumentException(int number)
        {
            Assert.Throws<ArgumentException>(() => IntNumberOperations.FindNextBiggerNumber(number));
        }
    }
}
