using System.Collections.Generic;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Add(x, y);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,4,2)]
        public void Divide_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            double expected = 0;

            double actual = Calculator.Divide(15, 0);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetCount_should_return_correct_count()
        {
            int[] nums = { 1, 2, 2, 3, 3, 3 };

            Dictionary<int, int> actualCount = Calculator.GetCount(nums);

            Assert.Equal(1, actualCount[1]);
            Assert.Equal(2, actualCount[2]);
            Assert.Equal(3, actualCount[3]);
        }

        [Fact]
        public void GetCount_should_return_correct_count_v2()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };

            Dictionary<int, int> actualCount = Calculator.GetCount(nums);

            Assert.Equal(3, actualCount[1]);
            Assert.Equal(2, actualCount[2]);
            Assert.Equal(1, actualCount[3]);
        }
    }
}

