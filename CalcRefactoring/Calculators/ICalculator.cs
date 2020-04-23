namespace Calculators
{
    public interface ICalculator
    {
        double Minus(double val1, double val2);
        double Plus(double val1, double val2);
        double Calculate(double val1, MathOperation operation, double val2);
    }
}