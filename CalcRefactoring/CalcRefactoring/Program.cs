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
            #warning Exception
            var val1 = GetDouble("Please enter val1");

            #warning Дублирование
            Console.WriteLine("Please enter operation:");
            var operation = Console.ReadLine();

            #warning Exception
            var val2 = GetDouble("Please enter val2");

            double result = 0;
            
            #warning Не нравится (вкусовщина)
            #warning Exception
            switch (operation)
            {
                #warning Плохая читаемость
                case "+": result = val1 + val2; break; 
                case "-": result = val1 - val2; break;
            }
            
            Console.WriteLine($"Result is: {result}");
        }

        private static double GetDouble(string message)
        {
            Console.WriteLine(message + ":");
            var val1 = Double.Parse(Console.ReadLine());
            return val1;
        }
    }
}