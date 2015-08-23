//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:
//n	   Prime?
//1	   false
//2	   true
//3	   true
//4	   false
//9	   false
//97   true
//51   false
//-3   false
//0	   false
using System;
class Check
{
    static void Main()
    {
        int num;
       // while (true)        Uncomment for easier check
       // {                   Uncomment for easier check
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num < 3)
            {
                if (num == 2)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
            else
            {
                if (num % 2 == 0)                                  //If the number is even it cannot be a prime
                {
                    Console.WriteLine("false");
                }
                else                                               // If number is odd, it could be a prime
                {
                    int div;
                    for (div = 3; num % div != 0; div += 2)        // This loop starts and 3 and does a modulo operation on all numbers.  As soon as there is no remainder, the loop stops.
                        ;                                          // do nothing

                    if (div == num)                                // if theNum and div are equal it must be a prime
                    {
                        Console.WriteLine("true");
                    }
                    else                                           // some other number divided evenly into num, and it is not itself, so it is not a prime
                    {
                        Console.WriteLine("false");
                    }
                }
            }
       //Uncomment for easier check }   
    }
}