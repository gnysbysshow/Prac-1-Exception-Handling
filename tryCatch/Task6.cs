using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task6
    {
        static void Main0(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Введите 5 целых чисел:");

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"[{i + 1}]: ");
                        numbers[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введено не целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое!");
                    }
                    catch
                    {
                        Console.WriteLine("Произошла ошибка!");
                    }
                }
            }

            Console.WriteLine("Массив: " + string.Join(" ", numbers));
        }
    }
}
