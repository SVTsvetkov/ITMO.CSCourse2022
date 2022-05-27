using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1CreateAccount
{
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        public void Populate(long number, decimal balance)
        {
            accNo = number;
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
    }
}
