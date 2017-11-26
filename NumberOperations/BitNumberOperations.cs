using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    public static class BitNumberOperations
    {
        /// <summary>
        /// Takes bits from <paramref name="secondNumber"/> and inserts them into <paramref name="firstNumber"/> to positions from <paramref name="startPosition"/> to <paramref name="endPosition"/>.
        /// </summary>
        public static int InsertNumber(int firstNumber, int secondNumber, int startPosition, int endPosition)
        {
            const int MaxBinIndex = 31;

            if (startPosition < 0 || endPosition < 0 || startPosition > MaxBinIndex || endPosition > MaxBinIndex)
            {
                throw new ArgumentOutOfRangeException($"{nameof(startPosition)} and {nameof(endPosition)} should be between in 0 to 31 ");
            }

            if (startPosition > endPosition)
            {
                throw new ArgumentException($"{nameof(startPosition)} should be less than {nameof(endPosition)}");
            }

            int mask = ((2 << (endPosition - startPosition)) - 1) << startPosition;
            return (firstNumber & ~mask) | ((secondNumber << startPosition) & mask);
        }
    }
}
