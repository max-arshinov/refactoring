using System;

namespace CalcRefactoring
{
    class Program
    {
        // + Заработал с первого раза
        // + Мне было очень
        // + Сделал очень быстро
        #warning Нет тестов
        static void Main(string[] args)
        {
            #warning Дублирование
            Console.WriteLine("Please enter val1:");
            #warning Exception
            var val1 = Double.Parse(Console.ReadLine());
            
            #warning Дублирование
            Console.WriteLine("Please enter operation:");
            var operation = Console.ReadLine();

            #warning Дублирование
            Console.WriteLine("Please enter val2:");
            #warning Exception
            var val2 = Double.Parse(Console.ReadLine());

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
    }
}