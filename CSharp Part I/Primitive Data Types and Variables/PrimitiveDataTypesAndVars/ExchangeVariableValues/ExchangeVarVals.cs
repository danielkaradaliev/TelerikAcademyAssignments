//Problem 9. Exchange Variable Values
//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.
using System;
class ExchangeVarVals
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int flag;
        Console.WriteLine("Before: a = {0}  b = {1}",a,b);
        flag = a;
        a = b;
        b = flag;
        Console.WriteLine("After: a = {0}  b = {1}", a, b);
    }
}