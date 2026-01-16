using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task7
    {
        static void Main0(string[] args)
        {
            try
            {
                Console.Write("Введите размер массивов: ");
                int size = int.Parse(Console.ReadLine());

                float[] array1 = new float[size];
                float[] array2 = new float[size];
                float[] result = new float[size];

                Console.WriteLine("Введите элементы первого массива:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"[{i}]: ");
                    array1[i] = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("Введите элементы второго массива:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"[{i}]: ");
                    array2[i] = float.Parse(Console.ReadLine());
                }

                for (int i = 0; i < size; i++)
                {
                    if (array1[i] == 0) throw new DivideByZeroException();
                    if (array2[i] == 0) throw new DivideByZeroException();
                    result[i] = array1[i] / array2[i];
                }

                Console.WriteLine("Результат: " + string.Join(" ", result));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое!");
            }
            catch
            {
                Console.WriteLine("Произошла ошибка!");
            }
            finally { }
        }
    }
}
