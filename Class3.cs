using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class3
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int step = 3;
            while (min <= max)
            {
                Console.WriteLine(min);
                min = min + step;
            }
        }
    }
}
