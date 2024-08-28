namespace Simple_Banking_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.CreateAccount("Kacper", 1500);
            bank.GetAccount(1);
            bank.CreateAccount("Jan", 100);
            bank.GetAccount(2);
            bank.Deposit(1, 200);
            bank.GetAccount(1);
            bank.Withdraw(1, 300);
            bank.GetAccount(1);


        }
    }
}
