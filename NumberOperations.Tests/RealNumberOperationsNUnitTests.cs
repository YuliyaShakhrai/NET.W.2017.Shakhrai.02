using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations.Tests
{
    [TestFixture]
    public class RealNumberOperationsNUnitTests
    {
        [TestCase(8, 15, -7)]
        [TestCase(8, 15, -0.6)]
        [TestCase(8, 15, 2)]
        public void FindNthRoot_IncorrectEpsilon_ThrowsArgumentException(double number, int power, double epsilon)
        {
            Assert.Throws<ArgumentException>(() => RealNumberOperations.FindNthRoot(number, power, epsilon));
        }

        [TestCase(-8, 2, 0.001)]
        [TestCase(-16, 2, 0.0001)]
        public void FindNthRoot_EvenPowerFromNegariveNumber_ThrowsArgumentException(double number, int power, double epsilon)
        {
            Assert.Throws<ArgumentException>(() => RealNumberOperations.FindNthRoot(number, power, epsilon));
        }

        [TestCase(-8, -2, 0.001)]
        [TestCase(-16, -3, 0.0001)]
        public void FindNthRoot_PowerIsNegariveNumber_ThrowsArgumentException(double number, int power, double epsilon)
        {
            Assert.Throws<ArgumentException>(() => RealNumberOperations.FindNthRoot(number, power, epsilon));
        }


        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        public void FindNthRoot_PositiveResultsTests(double number, int power, double epsilon, double expected)
        {
            double actual = RealNumberOperations.FindNthRoot(number, power, epsilon);

            Assert.AreEqual(expected, actual, epsilon);
        }



    }
}
