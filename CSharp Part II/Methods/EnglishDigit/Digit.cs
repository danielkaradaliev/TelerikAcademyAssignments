//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.
//Examples:
//
//input	    output
//512	    two
//1024	    four
//12309	    nine
using System;
class Digit
{
    static string Check(int x)
    {
        string output = "";
        int y = x % 10;
        switch (y)
        {
            case 0: output = "zero"; break;
            case 1: output = "one"; break;
            case 2: output = "two"; break;
            case 3: output = "three"; break;
            case 4: output = "four"; break;
            case 5: output = "five"; break;
            case 6: output = "six"; break;
            case 7: output = "seven"; break;
            case 8: output = "eight"; break;
            case 9: output = "nine"; break;
        }
        return output;
    }
    static void Main()
    {
        Console.Write("Enter number:");
        int input = int.Parse(Console.ReadLine());
        string output = Check(input);
        Console.WriteLine("The last digit of the number {0} is {1} !", input, output);
    }
}