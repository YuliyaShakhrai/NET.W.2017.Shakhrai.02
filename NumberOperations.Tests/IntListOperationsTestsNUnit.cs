using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NumberOperations.Tests
{
    [TestFixture]
    public class IntListOperationsTestsNUnit
    {
        [Test]
        public void FilterDigit_PositiveResultTest()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, 28, 307 };
            List<int> expected = new List<int> { 7, 70, 17, 307 };
            int digit = 7;
            List<int> actual = IntListOperations.FilterDigit(testList, digit);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void FilterDigit_NegativeResultTest()
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<int> expected = new List<int>();
            int digit = 8;
            List<int> actual = IntListOperations.FilterDigit(testList, digit);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(11, 1, true)]
        [TestCase(11, 0, false)]
        [TestCase(1231, 6, false)]
        public void IsNumberContainsDigit_Tests(int listItem, int digit, bool expected)
        {
            Assert.AreEqual(expected, IntListOperations.IsNumberContainsDigit(listItem, digit));
        }

        [TestCase(-5)]
        [TestCase(-11)]
        [TestCase(118)]
        public void FilterDigit_ThrowsArgumentOutOfRangeException(int digit)
        {
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, 28, 307 };
            Assert.Throws<ArgumentOutOfRangeException>(() => IntListOperations.FilterDigit(testList, digit));
        }

        [Test]
        public void FilterDigit_ThrowsArgumentNullException()
        {
            List<int> emptyList = new List<int>();
            int digit = 2;
            Assert.Throws<ArgumentNullException>(() => IntListOperations.FilterDigit(emptyList, digit));
        }
    }
}
