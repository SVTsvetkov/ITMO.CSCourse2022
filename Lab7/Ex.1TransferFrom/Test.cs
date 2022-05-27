using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1TransferFrom
{
    class Test
    {
        public static void Main()
        {
            BankAccount b1 = new BankAccount();
            b1.Populate(100);

            BankAccount b2 = new BankAccount();
            b2.Populate(100);

            Console.WriteLine("Before transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.AccountNumber(), b1.AccountBalance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.AccountNumber(), b2.AccountBalance());

            b1.TransferFrom(b2, 10);

            Console.WriteLine("After transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.AccountNumber(), b1.AccountBalance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.AccountNumber(), b2.AccountBalance());
        }

    }
}
