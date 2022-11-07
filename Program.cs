using Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        // var account = new BankAccount("SmithaKamath", 1000);
        // Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        BankAccount account;
        try
        {
            account = new BankAccount("Initial deposit", 100);
            account.MakeDeposit(200, DateTime.Now, "Deposited 200");
            account.MakeWithdrawal(100, DateTime.Now, "Money Withdrawn");

           Console.WriteLine(account.GetAccountHistory());
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
            return;
        }
    }
}