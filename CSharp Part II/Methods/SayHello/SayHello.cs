﻿//Problem 1. Say Hello
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:
//input	    output
//Peter	    Hello, Peter!
using System;
class SayHello
{
    static void Hello(string name)
    {
        Console.WriteLine("Hello, {0}!",name);
    }
    static void Main()
    {
        Console.Write("What is your name?:");
        string name = Console.ReadLine();
        Hello(name);
    }
}