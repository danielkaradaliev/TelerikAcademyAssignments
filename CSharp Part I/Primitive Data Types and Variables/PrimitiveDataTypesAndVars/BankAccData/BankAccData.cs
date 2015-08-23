//Problem 11. Bank Account Data
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
using System;
class BankAccData
    {
        static void Main()
        {
            Console.WriteLine("Enter Information");
            Console.Write("First Name:");
            string FName = Console.ReadLine();
            Console.Write("Middle Name:");
            string MName = Console.ReadLine();
            Console.Write("Last Name:");
            string LName = Console.ReadLine();
            Console.Write("Account Balance:");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Bank Name:");
            string BankName = Console.ReadLine();
            Console.Write("IBAN:");
            string IBAN = Console.ReadLine();
            Console.WriteLine("Number of the first credit card:");
            string CCN1 = Console.ReadLine();
            Console.WriteLine("Number of the second credit card:");
            string CCN2 = Console.ReadLine();
            Console.WriteLine("Number of the first credit card:");
            string CCN3 = Console.ReadLine();
            Console.WriteLine("\nAccount Information:");
            Console.WriteLine("===========================================================");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Full name: {0} {1} {2}",FName,MName,LName);
            Console.WriteLine("Account Ballance: {0}",amount);
            Console.WriteLine("Bank: {0}",BankName);
            Console.WriteLine("IBAN: {0}",IBAN);
            Console.WriteLine("Credit Cards:");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Credit card 1: {0}",CCN1);
            Console.WriteLine("Credit card 2: {0}", CCN2);
            Console.WriteLine("Credit card 3: {0}", CCN3);
            Console.WriteLine("===========================================================");
        }
    }