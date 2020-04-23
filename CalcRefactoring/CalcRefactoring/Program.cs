using System;
using static CalcRefactoring.ConsoleReader;

namespace CalcRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CheckedCalculator();
            try
            {
                var result = calculator.Calculate(
                    GetStruct<double>("Please enter val1"),
                    GetStruct<MathOperation>("Please enter operation: 'Plus' or 'Minus'"),
                    GetStruct<double>("Please enter val2")
                );

                Console.WriteLine($"Result is: {result}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("You entered a wrong operaion :(");   
            }
            catch (FormatException e)
            {
                Console.WriteLine("You entered a wrong number :(");   
            }
            catch (MatchOperationException e)
            {
                Console.WriteLine("This operation doesn't make sense':(");   
            }
        }
    }
}