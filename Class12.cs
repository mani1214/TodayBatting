using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class12
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)//rows
            {
                for (int j = 0; j < 3; j++)//cols
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
