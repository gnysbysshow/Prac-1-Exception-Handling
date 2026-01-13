using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task2

    {
        static void Main0(string[] args)
        {
            try
            {
                Console.Write("Введите первое целое число: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Введите второе целое число: ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Результат деления: {a / b}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не целое число!");
            }
            catch
            {
                Console.WriteLine("Произошла неизвестная ошибка!");
            }
        }
    }
}
