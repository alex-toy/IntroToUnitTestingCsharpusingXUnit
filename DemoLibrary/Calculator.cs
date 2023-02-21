using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y; 
            }
            else
            {
                // Custom business logic for divide by zero
                return 0;
            }
        }

        public static Dictionary<int, int> GetCount(int[] numbers)
        {

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (!counts.ContainsKey(number))
                {
                    counts[number] = 1;
                }
                else
                {
                    counts[number]++;
                }
            }

            return counts;
        }
    }
}
