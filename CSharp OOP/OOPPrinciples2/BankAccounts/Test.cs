//Problem 2. Bank accounts
//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based).
//Deposit accounts are allowed to deposit and with draw money.
//Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces.
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

namespace BankAccounts
{
    using System;

    class Test
    {
        static void Main()
        {
            Bank bank = new Bank("SomeBank");

            Customer newOwner = new Customer("Stamat", CustomerType.Individual);
            Deposit deposit = new Deposit(newOwner, 1000, 5.5m);
            bank.AddAccount(deposit);

            Customer secondOwner = new Customer("SomeLargeCompanyWitchConstructsTermometri", CustomerType.Company);
            Mortgage loan = new Mortgage(secondOwner, 10000000, 6.5m);
            bank.AddAccount(loan);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);
            }
        }
    }
}
