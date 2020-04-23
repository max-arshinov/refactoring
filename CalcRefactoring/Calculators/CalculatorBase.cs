namespace Calculators
{
    public abstract class CalculatorBase : ICalculator
    {
        public virtual double Minus(double val1, double val2)
            => val1 - val2;

        public virtual double Plus(double val1, double val2)
            => val1 + val2;

        public double Calculate(double val1, MathOperation operation, double val2)
            => operation switch
            {
                MathOperation.Plus => Plus(val1, val2),
                MathOperation.Minus => Minus(val1, val2),
            };
    }
}