//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
using System;
class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Input expression: ");
        string input = Console.ReadLine();
        int a = 0, b = 0;
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == '(')
            {
                a++;
            }
            else if (ch == ')')
            {
                b++;
            }
        }
        if (a == b)
        {
            Console.WriteLine("The expression is correct!");
        }
        else
        {
            Console.WriteLine("The expression is incorrect!");
        }
    }
}