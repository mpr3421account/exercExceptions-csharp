using System.Globalization;
using exercExceptions.Entities.Exceptions;
using exercExceptions.Entities;
/*Exercício de fixação
Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta.
*/

Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
string holder = Console.ReadLine();
Console.Write("Initial Balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, balance, withdrawLimit);

Console.WriteLine();
Console.Write("Enter amount for withdraw: ");
double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
try
{
    acc.Withdraw(amount);
    Console.Write("New balance: ", acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch(DomainExceptions e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}