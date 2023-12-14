using System;

namespace ЗАДАЧИ
{
    public class Reflection
    {
        /// <summary>
        /// Метод Main_1
        /// </summary>
        static void Main_1()
        {
            Console.WriteLine(Output());
            Console.WriteLine(AddInts(1, 2));
        }
        /// <summary>
        /// Статический метод, который возвращает строку
        /// </summary>
        /// <returns></returns>
        public static string Output()
        {
            return "Test-Output";
        }
        /// <summary>
        /// Статический метод, который возвращает число
        /// </summary>
        /// <param name="i1"></param>
        /// <param name="i2"></param>
        /// <returns></returns>
        public static int AddInts(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
