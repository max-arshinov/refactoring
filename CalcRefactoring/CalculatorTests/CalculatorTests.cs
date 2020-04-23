using System;
using CalcRefactoring;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Calculate()
        {
            var calc = new CheckedCalculator();
            calc.Calculate(1, MathOperation.Plus, 5);
        }
        

    }
}