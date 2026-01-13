using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task4
    {
        static void Main0(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                Console.WriteLine("Выберите элемент массива");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(numbers[index]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Выход за границы массива!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода!");
            }
            catch
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
