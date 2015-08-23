//Problem 6. Four-Digit Number
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.
//Examples:

//n	sum of digits	reversed	last digit in front	    second and third digits exchanged
//2011	    4	    1102	            1201	                    2101
//3333	    12	    3333	            3333                    	3333
//9876	    30	    6789	            6987	                    9786
using System;
class Four_DigitNumber
{
    static void Main()
    {
        int num, a, b, c, d;
        while (true)                                                                //Loop to check if the number is bigger than 9999 or smaller than 1000
        {
            Console.WriteLine("Enter Number (between 999 and 10000)");
            num = int.Parse(Console.ReadLine());
            if (num < 1000 || num > 9999)
                Console.WriteLine("The number is either too small or too big");
            else
            {                                                                       //If it is in the limits, we preform the following operations and the loop stops...
                a = num / 1000;
                b = (num / 100) % 10;
                c = (num / 10) % 10;
                d = num % 10;
                break;                                                              //here
            }
        }
        Console.WriteLine("The sum of the digits is: {0}",a+b+c+d);
        Console.WriteLine("Reversed: {0}{1}{2}{3}",d,c,b,a);
        num = d * 1000 + a * 100 + b * 10 + c;
        Console.WriteLine("Last digit in front: {0}",num);
        num = a * 1000 + c * 100 + b * 10 + d;
        Console.WriteLine("Second and third digits exchanged: {0}",num);

    }
}