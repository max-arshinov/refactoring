using System;

namespace Calculators
{
    public class CalcParameters
    {
        public CalcParameters(double va1, MathOperation mathOperation, double val2)
        {
            Val1 = va1;
            Operation = mathOperation;
            Val2 = val2;

            if (mathOperation == MathOperation.Divide && val2 == 0)
            {
                throw new ArgumentException("You can't divide by zero'", nameof(val2));
            }
        }

        public double Val1 { get; private set; }
        
        public MathOperation Operation { get; private set; }
        public double Val2 { get; private set; }
    }
}