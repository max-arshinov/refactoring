using System;

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
            var operation = GetStruct<MathOperation>("Please enter operation");
            var val2 = GetStruct<double>("Please enter val2");

            double result = 0;
            
            #warning Exception
            #warning Не нравится (вкусовщина)
            switch (operation)
            {
                #warning Плохая читаемость
                case MathOperation.Plus: result = val1 + val2; break; 
                case MathOperation.Minus: result = val1 - val2; break;
            }
            
            Console.WriteLine($"Result is: {result}");
        }

        private static T GetStruct<T>(string message) 
            where T : struct
        {
            Console.WriteLine(message + ":");
            #warning Exception
            #warning Performance (boxing/unboxing) 
            return typeof(T).IsEnum 
                ? Enum.Parse<T>(Console.ReadLine()) 
                : (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
    }

    public enum MathOperation
    {
        Plus,
        Minus
    }
}