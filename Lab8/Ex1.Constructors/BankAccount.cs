using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Constructors
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }
        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }

        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }

        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }


        public long AccountNumber()
        {
            return accNo;
        }
        public decimal AccountBalance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString(); 
        }

        private bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }

        private decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
    }
}
