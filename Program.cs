using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;
            int step = 2;
            while (min <= max)
            {
                Console.WriteLine(min);
                min += step;
            }
        }
    }
}
