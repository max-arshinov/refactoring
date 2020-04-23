namespace Calculators
{
    public interface ICalculator
    {
        double Minus(double val1, double val2);
        double Plus(double val1, double val2);
        double Calculate(CalcParameters inClassName);
    }
}