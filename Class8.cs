using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class8
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < 4; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element in array");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }


    }
}
