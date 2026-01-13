using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task5
    {
        static void Main0(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива: ");
                int size = int.Parse(Console.ReadLine());

                int[] array = new int[size];

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Введите элемент {i}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                foreach (int num in array)
                    sum += num;

                Console.WriteLine($"Сумма элементов: {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое!");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка!");
            }
        }
    }
}
