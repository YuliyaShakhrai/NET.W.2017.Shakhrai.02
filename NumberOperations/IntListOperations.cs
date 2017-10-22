using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    public static class IntListOperations
    {
        public static List<int> FilterDigit(List<int> intList, int digit)
        {
            if (digit > 9 || digit < 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(digit)} should be between in 0 to 9.");
            }
            if (intList.Count == 0)
            {
                throw new ArgumentNullException($"{nameof(intList)} is empty.");
            }

            for (int i = 0; i < intList.Count; i++)
            {
                if (!IsNumberContainsDigit(intList[i], digit))
                {
                    intList.RemoveAt(i);
                    i--;
                }
            }
            return intList;
        }

        public static bool IsNumberContainsDigit(int listItem, int digit)
        {
            int tempNumber = listItem;
            int modulo = 0;
            var divisionResult = 0;
            do
            {
                divisionResult = tempNumber / 10;
                modulo = tempNumber % 10;
                tempNumber = divisionResult;
                if (modulo == digit) return true;
            } while (divisionResult != 0);
            return false;
        }
    }
}
