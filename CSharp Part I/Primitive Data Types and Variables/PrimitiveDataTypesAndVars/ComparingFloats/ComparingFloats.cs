//Problem 13.* Comparing Floats
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
using System;
class ComparingFloats
{
    static void Main()
        {
            double eps;
            double Num1;
            double Num2;
            string StrNum1;
            string StrNum2;
            Console.WriteLine("Enter the first number:");
            StrNum1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            StrNum2 = Console.ReadLine();
            if (double.TryParse(StrNum1, out Num1) && double.TryParse(StrNum2, out Num2))
            {
                eps = Math.Abs(Num1 - Num2);
                if (eps < 0.000001)
                {
                    Console.WriteLine("The numbers are equal");
                }
                else
                {
                    Console.WriteLine("The numbers are different");
                }
            }
            else
                Console.WriteLine("One of the numbers you entered is not correctly formatted");
        }
}