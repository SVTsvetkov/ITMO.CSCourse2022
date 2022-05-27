using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2Reverse
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Utils.Reverse(ref str);
            Console.WriteLine(str);
        }
    }
}
