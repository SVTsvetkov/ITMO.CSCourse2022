using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;

        internal BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }

        public decimal Amount()
        {
            return amount;
        }

        public DateTime When()
        {
            return when;
        }
    }
}
