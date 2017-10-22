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
        public static int InsertNumber(int firstNumber, int secondNumber, int startPosition, int endPosition)
        {
            int[] insertResult = new int[1];
            const int maxBitIndex = 31; //because we are working with Int32, so maxBitIndex is 31

            if (startPosition < 0 || endPosition < 0 || startPosition > maxBitIndex || endPosition > maxBitIndex)
                throw new ArgumentOutOfRangeException($"{nameof(startPosition)} and {nameof(endPosition)} should be between in 0 to 31 ");
            if (startPosition > endPosition)
                throw new ArgumentException($"{nameof(startPosition)} should be less than {nameof(endPosition)}");


            BitArray firstBitArray = new BitArray(new int[] { firstNumber });
            BitArray secondBitArray = new BitArray(new int[] { secondNumber });

            for (int i = endPosition; i >= startPosition; i--)
            {
                firstBitArray[i] = secondBitArray[i];
            }

            firstBitArray.CopyTo(insertResult, 0);
            return insertResult[0];
        }
    }
}
