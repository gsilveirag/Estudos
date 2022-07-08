using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios_Try.Entities.Exceptions;

namespace Exercicios_Try.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get; set; }

        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (Double amount)
        {
            Balance += amount;
        }

        public void Withdraw (Double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new AccountException("Not enough balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance: "
                + Balance.ToString("F2");
        }
    }
}
