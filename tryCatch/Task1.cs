using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class Task1
    {
        static void Main0(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Правильно");
            }
            catch
            {
                Console.WriteLine("Ошибка, это не число");
            }
        }
    }
}
