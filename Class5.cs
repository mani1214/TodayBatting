using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class5
    {
        static void Main(string[] args)
        {
            int min = 20;
            int max = 50;
            int step = 5;
            while(min <= max)
            {
                Console.WriteLine(min);
                min = min + step;

            }
        }
    }
}
