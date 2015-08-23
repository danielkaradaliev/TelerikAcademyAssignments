//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
using System;
class Program
    {
        static void Main()
        {
            string FName;
            string LName;
            int age;
            long PID;
            int UEN;
            Console.WriteLine("Enter employee data:\n");
            Console.WriteLine("First Name:");
            FName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            LName = Console.ReadLine();
            Console.WriteLine("Age:");
            age = int.Parse(Console.ReadLine());
            if(age<0 || age>100)
            {
                Console.WriteLine("Invalid age!");
                return;
            }
            Console.WriteLine("Gender:");
            char gender = char.Parse(Console.ReadLine());
            if (gender != 'M' && gender != 'm' && gender != 'F' && gender != 'f')
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Personal Identification Number:");
            PID = long.Parse(Console.ReadLine());
            Console.WriteLine("Unique employee number:");
            UEN = int.Parse(Console.ReadLine());
            if(UEN < 27560000 || UEN > 27569999)
            {
                Console.WriteLine("Invalid Unique employee number(Shoud be higher than 27560000 and lower than 27569999!)");
                return;
            }
                Console.WriteLine("\nEmployee Data:\n");
                Console.WriteLine("Name: {0} {1}",FName,LName);
                Console.WriteLine("Age: {0}",age);
                if(gender == 'M' || gender == 'm' )
                    Console.WriteLine("Gender:Male");
                else
                    Console.WriteLine("Gender:Female");
                Console.WriteLine("Personal ID:{0} ",PID);
                Console.WriteLine("Unique employee number:{0}",UEN);
            }
        }