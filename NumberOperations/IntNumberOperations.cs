using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    public class IntNumberOperations
    {
        public static int FindNextBiggerNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} should be > 0");
            }

            if (number < 10)
            {
                return -1;
            }

            List<int> listInt = IntToList(number);
            var resultList = Permute(listInt)
                .Where(x => x > number)
                .OrderBy(x => x)
                .ToList();
            if (resultList.Count > 0)
            {
                return resultList[0];
            }
            else
            {
                return -1;
            }
        }

        public static (int NextBiggerNumber, int milliseconds) GetTimeOfFindNextBiggerNumberByDateTime(int number)
        {
            var startTime = DateTime.Now;
            var nextBiggerNumber = FindNextBiggerNumber(number);
            var endTime = DateTime.Now;
            var milliseconds = (endTime - startTime).Milliseconds;
            var result = (nextBiggerNumber, milliseconds);
            return result;
        }

        public static (int NextBiggerNumber, int milliseconds) GetTimeOfFindNextBiggerNumberByStopWatch(int number)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var nextBiggerNumber = FindNextBiggerNumber(number);
            stopwatch.Stop();
            var milliseconds = Convert.ToInt32(stopwatch.ElapsedMilliseconds);
            var result = (nextBiggerNumber, milliseconds);
            return result;
        }

        public static List<int> Permute(List<int> listInt)
        {
            var resultList = new List<int>();
            Permute(listInt, listInt.Count, resultList);
            return resultList;
        }

        private static List<int> IntToList(int number)
        {
            List<int> resultList = new List<int>();
            int tempNumber = number;
            int modulo = 0;
            var divisionResult = 0;
            do
            {
                divisionResult = tempNumber / 10;
                modulo = tempNumber % 10;
                resultList.Add(modulo);
                tempNumber = divisionResult;
            }
            while (divisionResult != 0);
            return resultList;
        }

        private static int ListToInt(List<int> listInt)
        {
            int result = 0;
            int n = 0;
            do
            {
                result += listInt[n] * Convert.ToInt32(Math.Pow(10, n));
                n++;
            }
            while (n < listInt.Count);
            return result;
        }

        private static void Permute(List<int> listInt, int count, List<int> resultList)
        {
            if (count == 1)
            {
                resultList.Add(ListToInt(listInt));
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Permute(listInt, count - 1, resultList);
                    Swap(listInt, count % 2 == 1 ? 0 : i, count - 1);
                }
            }
        }

        private static void Swap(List<int> listInt, int i, int j)
        {
            int temp;
            temp = listInt[i];
            listInt[i] = listInt[j];
            listInt[j] = temp;
        }
    }
}
