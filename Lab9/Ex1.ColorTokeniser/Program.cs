using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ColorTokeniser
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }
        }

        public static void InnerMain(string[] args)
        {
            var visitor = new HTMLTokenVisitor();
            SourceFile source = new SourceFile(args[0]);
            source.Accept(visitor);
        }
    }
}
