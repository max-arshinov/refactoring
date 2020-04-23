namespace Calculators
{
    public class UncheckedCalculator : CalculatorBase
    {
        public override double Minus(double val1, double val2)
        {
            return unchecked(base.Minus(val1, val2));
        }

        public override double Plus(double val1, double val2)
        {
            return unchecked(base.Plus(val1, val2));
        }
    }
}