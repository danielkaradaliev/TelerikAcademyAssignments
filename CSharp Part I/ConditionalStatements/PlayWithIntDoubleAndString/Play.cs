//Problem 9. Play with Int, Double and String
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:
//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            3
//3 --> string	
//Please enter a string:	hello
//hello*	
//Example 2:
//program	                user
//Please choose a type:	
//1 --> int	
//2 --> double	            2
//3 --> string	
//Please enter a double:	1.5
//2.5
using System;
class Play
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        string choice = Console.ReadLine();
        Console.WriteLine();
        switch (choice)
        {
            case "1": Console.Write("Please enter an int: "); int a = int.Parse(Console.ReadLine()); a = a + 1; Console.WriteLine(a); break;
            case "2": Console.Write("Please enter a double: "); double b = double.Parse(Console.ReadLine()); b = b + 1; Console.WriteLine(b); break;
            case "3": Console.Write("Please enter a string: "); string c = Console.ReadLine(); c = c + "*"; Console.WriteLine(c); break;
            default: Console.WriteLine("Invalid choice"); break;
        }
    }
}