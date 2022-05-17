using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Enter first number");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Enter second number");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine(k);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception was thrown: {0}", ex);
            }
            

        }
    }
}
