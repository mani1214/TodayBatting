using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class10
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            string[] s = { "mani", "vamshi", "madhu", "arun" };
            Console.WriteLine(a.Length);
            Console.WriteLine(s.Length);
            Console.WriteLine("array element are");
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("string elements are");
            foreach(string str in s)
            {
                Console.WriteLine(str);
            }
        }
    }
}
