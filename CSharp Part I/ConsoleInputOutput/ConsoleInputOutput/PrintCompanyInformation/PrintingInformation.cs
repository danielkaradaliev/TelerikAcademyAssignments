//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//program	    user
//Company name:	Telerik Academy
//Company address:	231 Al. Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981

//Example output:
//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)
using System;
class PrintingInformation
{
    static void Main()
    {
        Console.Write("Company Name:");
        string CompanyName = Console.ReadLine();
        Console.Write("Company Address:");
        string CompanyAddress = Console.ReadLine();
        Console.Write("Phone number:");
        string PhoneNumber = Console.ReadLine();
        Console.Write("Fax number:");
        string FaxNumber = Console.ReadLine();
        Console.Write("Web site:");
        string WebSite = Console.ReadLine();
        Console.Write("Manager's first name:");
        string ManagerFName = Console.ReadLine();
        Console.Write("Manager's last name:");
        string ManagerLName = Console.ReadLine();
        Console.Write("Manager's age:");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Manager's phone:");
        string ManagerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(CompanyName);
        Console.WriteLine("Address: {0}",CompanyAddress);
        Console.WriteLine("Tel. {0}",PhoneNumber);
        if(FaxNumber=="")
            Console.WriteLine("Fax: (no fax)");
        else
            Console.WriteLine("Fax: {0}",FaxNumber);
        Console.WriteLine("Web site: {0}",WebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",ManagerFName,ManagerLName,age,ManagerPhone);

    }
}