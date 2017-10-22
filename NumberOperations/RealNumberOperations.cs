using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOperations
{
    public static class RealNumberOperations
    {
        public static double FindNthRoot(double number, int power, double epsilon)
        {
            if (power % 2 == 0 && number < 0)
                throw new ArgumentException($"Even {nameof(power)} can not be taken from a negative number.");
            if (power < 1)
                throw new ArgumentException($"{nameof(power)} should be a natural number.");
            if (epsilon < 0 || epsilon > 1)
            {
                throw new ArgumentException($"{nameof(epsilon)} should be between in 0 to 1");
            }

            double prev, next = 1;
            do
            {
                prev = next;
                next = ((power - 1) * prev + number / Math.Pow(prev, power - 1)) / power;
            } while (Math.Abs(next - prev) > epsilon);
            return next;
        }
    }
}
