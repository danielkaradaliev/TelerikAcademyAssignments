//Problem 9. Print a Sequence
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
using System;
class LongSequence
{
    static void Main()
    {
        int i;
        for (i = 2; i < 1002; i++)
        {
            if (i % 2 == 0) //if i is even 
                Console.WriteLine(i);
            else
            {
                Console.WriteLine(i = i * (-1)); // if i is odd
                i = Math.Abs(i); //When i is an odd number, whe must return its absolute value in order to keep the operator "for" working properly!
            }                    //When i is an odd number and we do not return its absolute value, the next step of the "for" will be, for example
        }                        //-7+1=6 , which we must avoid!
    }
}