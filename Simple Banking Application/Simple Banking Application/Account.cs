using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_Application
{
    public class Account
    {
        public Account(int accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("You can't withdraw amount greater than your current balance, consider a loan ;)");
            }
            else
            {
                Balance -= amount;
            }
        }

        public void GetBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
