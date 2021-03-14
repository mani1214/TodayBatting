using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class4
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 5;
            int step = 1;
            while (min <= max)
            {
                Console.WriteLine(min*min);
                min = min + step;
            }
        }
    }
}
