using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex2.Assembly
{
    class CreateAccount
    {
        static void Main(string[] args)
        {
            //new BankTransaction(0.0M);
            Console.WriteLine("Sid's Account");
            long sidsAccNo = Bank.CreateAccount();
            BankAccount sids = Bank.GetAccount(sidsAccNo);
            TestDeposit(sids);
            TestWithdraw(sids);
            Write(sids);
            if (Bank.CloseAccount(sidsAccNo))
                Console.WriteLine("Account closed");
            else
                Console.WriteLine("Something went wrong closing the account");
        }

        static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Withdraw(amount);
        }
        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.AccountNumber());
            Console.WriteLine("Account balance is {0}", acc.AccountBalance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }

    }
}
