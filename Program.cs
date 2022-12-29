using BankAccountException.Entities;
using BankAccountException.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int accountNumber = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw Limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account account = new Account(accountNumber, holder, initialBalance, withdrawLimit);

    Console.WriteLine();

    Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    account.Withdraw(withdraw);

    Console.WriteLine(account);

}
catch (DomainException e)
{
    Console.WriteLine("Operation Error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected Error: " + e.Message);
}
