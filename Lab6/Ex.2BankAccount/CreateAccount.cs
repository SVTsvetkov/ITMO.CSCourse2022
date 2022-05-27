using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2BankAccount
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number   : ");
            //long number = long.Parse(Console.ReadLine());
            //long number = BankAccount.NextNumber();

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;
            created.Populate(balance);

            return created;
        }
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.AccountNumber());
            Console.WriteLine("Account balance is {0}", toWrite.AccountBalance());
            Console.WriteLine("Account type is {0}", toWrite.Type());//.ToString());
        }
    }
}
