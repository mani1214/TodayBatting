using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class11
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2,2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < 2; i++)
            {
                for (int j  = 0; j  < 2; j ++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
