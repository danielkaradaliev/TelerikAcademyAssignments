//Problem 4. Person class
//Create a class Person with two fields – name and age. Age can be left unspecified
//(may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.
namespace PersonClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Person stamat = new Person("Stamat",22);
            Person sharo = new Person("Sharo");

            Console.WriteLine(stamat);
            Console.WriteLine(sharo);
        }
    }
}
