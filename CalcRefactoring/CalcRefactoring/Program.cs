using System;

namespace CalcRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter val1:");
            var val1 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter operation:");
            var operation = Console.ReadLine();

            Console.WriteLine("Please enter val2:");
            var val2 = Double.Parse(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case "+": result = val1 + val2; break; 
                case "-": result = val1 - val2; break;
            }
            
            Console.WriteLine($"Result is: {result}");
        }
    }
}