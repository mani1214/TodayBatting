using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1
    {
        static void Main(string[] args)
        {
            int max = 10;
            int min = 1;
            int step = 1;
            while (max >= min)
            {
                Console.WriteLine(max);
                max = max - step;
            }
        }
    }
}
