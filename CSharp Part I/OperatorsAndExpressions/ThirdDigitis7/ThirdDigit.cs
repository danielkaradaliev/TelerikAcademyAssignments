//Problem 5. Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:
//n	Third digit 7?
//5	        false
//701	    true
//9703	    true
//877	    false
//777877	false
//9999799	true
using System;
class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        num = num / 100; //This way we are making the third digit last
        if (num % 10 == 7)
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}