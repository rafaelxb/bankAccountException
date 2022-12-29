using BankAccountException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public Double Balance { get; set; }
        public Double WithdrawLimit { get; set; }

        public Account() { }
        
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(Account account,Double amount)
        {
            account.Balance += amount;
        }

        public void Withdraw(Double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Exceed withdrawal amount limit. Withdraw wasn't realized.");
            }

            if (amount > Balance)
            {
                throw new DomainException("Balance insufficient. Withdraw wasn't realized.");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
