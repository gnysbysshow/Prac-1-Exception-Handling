using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task3
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
                    Console.Write($"Элемент [{i}]: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Массив: " + string.Join(" ", array));
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }
    }
}
