using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberOperations.Tests
{
    [TestClass]
    public class BitNumberOperationsMSTests
    {
        [TestMethod]
        public void InsertNumber_9Insert5Positions0To2_13Returned()
        {
            var actual = BitNumberOperations.InsertNumber(9, 5, 0, 2);
            var expected = 13;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void InsertNumber_10Insert7Positions0To2_15Returned()
        {
            var actual = BitNumberOperations.InsertNumber(10, 7, 0, 2);
            var expected = 15;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_StartPositionBiggerThanEndPosition_ArgumentException()
        {
            BitNumberOperations.InsertNumber(10, 7, 2, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_PositionsOutOfRange_ArgumentOutOfRangeException()
        {
            BitNumberOperations.InsertNumber(10, 7, -1, 32);
        }
    }
}
