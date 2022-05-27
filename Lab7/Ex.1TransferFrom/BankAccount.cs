using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1TransferFrom
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

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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
