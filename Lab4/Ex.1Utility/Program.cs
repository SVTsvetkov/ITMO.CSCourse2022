using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1Utility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int greater;
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
        }
    }
}
