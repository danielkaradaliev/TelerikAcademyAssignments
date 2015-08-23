//Problem 2. Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:
//weight	weight on the Moon
//86	14.62
//74.6	12.682
//53.7	9.129
using System;
class Gravitation
{
    static void Main()
    {
        double Eweight;
        double Mweight;
        Console.Write("Enter your Earth weight(In Kilograms!): ");
        Eweight = double.Parse(Console.ReadLine());
        Mweight = Eweight * 17 / 100;
        Console.WriteLine("Your Moon weight is {0} kilograms!", Mweight);

    }
}