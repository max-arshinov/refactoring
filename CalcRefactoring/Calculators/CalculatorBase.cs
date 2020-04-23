namespace Calculators
{
    public abstract class CalculatorBase : ICalculator
    {
        public virtual double Minus(double val1, double val2)
            => val1 - val2;

        public virtual double Plus(double val1, double val2)
            => val1 + val2;

        public double Calculate(CalcParameters inClassName)
            => inClassName.Operation switch
            {
                MathOperation.Plus => Plus(inClassName.Val1, inClassName.Val2),
                MathOperation.Minus => Minus(inClassName.Val1, inClassName.Val2),
            };
    }
}