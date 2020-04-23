using System;

namespace ConsoleUtils
{
    public class ConsoleReader
    {
        public static T GetEnumByItsDisplayName<T>(string message)
            where T : Enum
        {
            throw new NotImplementedException();
        }

        public static T GetStruct<T>(string message)
            where T : struct
        {
            Console.WriteLine(message + ":");
#warning Exception
#warning Performance (boxing/unboxing) 
            return typeof(T).IsEnum
                ? Enum.Parse<T>(Console.ReadLine())
                : (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
    }
}