using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class7
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (i == j || i + j == 2)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write(arr[i, j] + "\t");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
