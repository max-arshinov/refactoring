using System;
using Calculators;
using ConsoleUtils;
using static ConsoleUtils.ConsoleReader;

namespace CalcRefactoring
{
    public static class App
    {
        public static void Run()
        {
            var calculator = new CheckedCalculator();

            calculator.TryCalculate(
                GetStruct<double>("Please enter val1"),
                GetStruct<MathOperation>("Please enter operation: 'Plus' or 'Minus'"),
                GetStruct<double>("Please enter val2"),
                out var result
            ).EiterOr(
                () => Console.WriteLine($"Result is: {result}"),
                () => Console.WriteLine("Что-то пошло не так:("));
        }

        public static void EiterOr(this bool flag, Action success, Action error)
        {
            if (flag)
            {
                success();
            }
            else
            {
                error();
            }
        }
    }
    
    
}