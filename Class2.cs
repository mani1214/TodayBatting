using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class2
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 5;
            int step = 1;
            int fact = 1;
            while (min <= max)
            {
            
                fact = fact * min;
                min = min + step;
            }
            Console.WriteLine(fact);
        }
    }
}