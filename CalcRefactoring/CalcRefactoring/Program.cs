using System;
using System.ComponentModel.DataAnnotations;
using static CalcRefactoring.ConsoleReader;
using static CalcRefactoring.Calculator;

namespace CalcRefactoring
{
    class Program
    {
        // + Заработал с первого раза
        // + Мне было очень просто
        // + Сделал очень быстро
        
        // - Не пройдет код-ревью у преподавателя, потому что он злюка и что-то ему надо про архитектуру и
        // качество ему подавай
        // - Не получу балллов :(
        // - "Сопартийцы" закидают помидорами / будут ругаться
        #warning Нет тестов
        static void Main(string[] args)
        {
            var val1 = GetStruct<double>("Please enter val1");
            var operation = GetStruct<MathOperation>("Please enter operation: 'Plus' or 'Minus'");
            var val2 = GetStruct<double>("Please enter val2");

            #warning Exception
            var result = operation switch
            {
                MathOperation.Plus => Plus(val1, val2),
                MathOperation.Minus => Minus(val1, val2),
            };
            
            Console.WriteLine($"Result is: {result}");
        }


    }

    public enum MathOperation: byte
    {
        [Display(Name = "+")]
        Plus = 0,

        [Display(Name = "-")]
        Minus
    }
}