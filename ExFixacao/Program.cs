using System;
using ExFixacao.Entities;
using ExFixacao.Entities.Exception;
using System.Globalization;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }

            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }
        }
    }
}
