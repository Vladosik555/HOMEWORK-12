using System.Threading;
using System.Threading.Tasks;

namespace ЗАДАЧИ
{
    internal class Computations
    {
        /// <summary>
        /// Статический метод, который возвращает квадрат числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static uint Square(uint number)
        {
            return number * number;
        }
        /// <summary>
        /// Статический метод, который возвращает факториал числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static uint Factorial(uint number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        /// <summary>
        /// Асинхронный метод, который возвращает факториал числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static async Task<uint> Factorial_Async(uint number)
        {
            uint factorial = await Task.Run(() => Factorial(number));
            Thread.Sleep(8000);
            return factorial;
        }

    }
}
