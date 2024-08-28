using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_Application
{
    public class Bank
    {
        int accountsId = 1;
        private List<Account> accounts = new List<Account>();

        public void CreateAccount(string accountHolder, decimal initalDeposit)
        {
            accounts.Add(new Account(accountsId++, accountHolder, initalDeposit));
        }

        public void GetAccount(int accountNumber)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);

            if (account != null)
            {
                Console.WriteLine(account);
            }
            else
            {
                Console.WriteLine("Account of this ID doesn't exists");
            }
        }

        public void Deposit(int accountNumber, decimal depositAmount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (depositAmount <= 0)
            {
                Console.WriteLine("Amount cannot be negative or equal to zero");
            }
            else
            {
                account?.Deposit(depositAmount);
            }
        }

        public void Withdraw(int accountNumber, decimal withdrawAmount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (withdrawAmount > account.Balance)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                account?.Withdraw(withdrawAmount);
            }
        }
    }
}
