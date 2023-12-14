using System;

namespace ЗАДАЧИ
{
    internal class Number
    {
        /// <summary>
        /// Статический метод, который выводит на экран числа от 0 до 10
        /// </summary>
        public static void Outputting_Numbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
