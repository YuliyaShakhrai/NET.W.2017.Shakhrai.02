using System;
using NUnit.Framework;

namespace NumberOperations.Tests
{
    [TestFixture]

    public class BitNumberOperationsNUnitTests
    {
        [TestCase(9, 5, 0, 2, 13)]
        [TestCase(10, 7, 0, 2, 15)]
        public void InsertNumber_PositiveTests(int firstNumber, int secondNumber, int startPosition, int endPosition, int expected)
        {
            Assert.AreEqual(expected, BitNumberOperations.InsertNumber(firstNumber, secondNumber, startPosition, endPosition));
        }

        [TestCase(9, 5, 32, 5)]
        [TestCase(9, 5, 5, 32)]
        [TestCase(9, 5, -1, 5)]
        [TestCase(9, 5, 5, -1)]
        public void InsertNumber_ThrowsArgumentOutOfRangeException(int firstNumber, int secondNumber, int startPosition, int endPosition)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BitNumberOperations.InsertNumber(firstNumber, secondNumber, startPosition, endPosition));
        }

        [TestCase(9, 5, 11, 7)]
        [TestCase(9, 5, 3, 2)]
        public void InsertNumber_ThrowsArgumentException(int firstNumber, int secondNumber, int startPosition, int endPosition)
        {
            Assert.Throws<ArgumentException>(() => BitNumberOperations.InsertNumber(firstNumber, secondNumber, startPosition, endPosition));
        }
    }
}
