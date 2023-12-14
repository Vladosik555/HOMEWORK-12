using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ЗАДАЧИ
{
    internal class Program
    {
        static async Task Main()
        {
            
            Console.WriteLine("Задача 1");
            Console.WriteLine("Создать 3 потока чисел от 0 до 10 и вывести их на экран");
            Thread thread_1 = new Thread(Number.Outputting_Numbers);
            Thread thread_2 = new Thread(Number.Outputting_Numbers);
            Thread thread_3 = new Thread(Number.Outputting_Numbers);

            thread_1.Start();
            thread_2.Start();
            thread_3.Start();

            Thread.Sleep(500);

            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            Console.WriteLine("\nЗадача 2");
            Console.WriteLine("Синхронное возведение числа в квадрат и асинхронное вычисление факториала");
            uint number = 0;

            uint square = Computations.Square(number);
            Console.WriteLine($"{number}^2 = {square}");

            uint factorial = await Computations.Factorial_Async(number);
            Console.WriteLine($"\n{number}! = {factorial}");

            Console.WriteLine("\nДля того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("\nЗадача 3");
            Console.WriteLine("Написать название методов");
            Reflection reflection = new Reflection();
            Type type = reflection.GetType();
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("\nДля того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();


        }
    }
}
