using System;

namespace Calculators
{
    public class CheckedCalculator : CalculatorBase
    {
        public override double Minus(double val1, double val2)
        {
            return checked(base.Minus(val1, val2));
        }

        public override double Plus(double val1, double val2)
        {
            return checked(base.Plus(val1, val2));
        }
    }
}