using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class9
    {
        static void Main(string[] args)
        {
            string[] array = new string[4];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the element in array");
            foreach(string st in array)
            {
                Console.WriteLine(st);
            }
        }
    }
}
