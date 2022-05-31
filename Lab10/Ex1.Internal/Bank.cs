using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Internal
{
    public class Bank
    {
        private static Hashtable accounts = new Hashtable();

        private Bank() { }
        public static long CreateAccount()
        {
            BankAccount newAcc = new BankAccount();
            long accNo = newAcc.AccountNumber();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public static long CreateAccount(AccountType aType, decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aType, aBal);
            long accNo = newAcc.AccountNumber();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public static long CreateAccount(AccountType aType)
        {
            BankAccount newAcc = new BankAccount(aType);
            long accNo = newAcc.AccountNumber();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public static long CreateAccount(decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aBal);
            long accNo = newAcc.AccountNumber();
            accounts[accNo] = newAcc;
            return accNo;
        }
        public static bool CloseAccount(long accNo)
        {
            BankAccount closing = (BankAccount)accounts[accNo];
            if (closing != null)
            {
                accounts.Remove(accNo);
                closing.Dispose();
                return true;
            }
            else
            {
                return false;
            }

        }
        public static BankAccount GetAccount(long accNo)
        {
            return (BankAccount)accounts[accNo];
        }

    }
}
