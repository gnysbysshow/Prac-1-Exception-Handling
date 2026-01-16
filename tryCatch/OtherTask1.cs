using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    internal class OtherTask1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(row[j]);
            }

            bool symmetric = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        symmetric = false;
                        break;
                    }
                }
            }

            Console.WriteLine(symmetric ? "YES" : "NO");
        }
    }
}
